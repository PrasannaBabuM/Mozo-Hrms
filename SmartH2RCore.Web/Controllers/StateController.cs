using AutoMapper;

using JqueryDataTables.ServerSide.AspNetCoreWeb.ActionResults;
using JqueryDataTables.ServerSide.AspNetCoreWeb.Models;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using SmartH2RCore.Models.Common;
using SmartH2RCore.Models.DTO.Master;
using SmartH2RCore.Services.Interface;

using System;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace SmartH2RCore.Web.Controllers
{

    public class StateController : BaseController
    {
        private readonly IMapper _mapper;
        private readonly IStateService _stateService;

        public StateController(IStateService stateService, IMapper mapper)
        {
            _stateService = stateService;
            _mapper = mapper;
        }

        [Route("State")]
        public IActionResult Index()
        {
            return View("List", new StateDTO());
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View("Add");
        }

        [HttpPost]
        public async Task<IActionResult> Add(StateDTO model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await _stateService.AddAsync(_mapper.Map<State>(model));
                    TempData["Message"] = "State Added Successfully!";
                    TempData["Success"] = true;
                    return RedirectToAction("Index", "State");
                }
                catch (Exception ex)
                {
                    TempData["Message"] = ex.Message;
                    TempData["Success"] = false;
                    return View("Add", model);
                }
            }
            return View("Add", model);
        }
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var State = await _stateService.FirstOrDefaultAsync(x => x.Id == id);
            return View("Add", _mapper.Map<StateDTO>(State));
        }

        [HttpPost]
        public async Task<IActionResult> Edit(StateDTO model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await _stateService.UpdateAsync(_mapper.Map<State>(model));
                    TempData["Message"] = "State Updated Successfully!";
                    TempData["Success"] = true;
                    return RedirectToAction("Index", "State");
                }
                catch (Exception ex)
                {
                    TempData["Message"] = ex.Message;
                    TempData["Success"] = false;
                    return View("Add", model);
                }
            }
            return View("Add", model);
        }

        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                await _stateService.DeleteSoftAsync(id);
                TempData["Message"] = "State Deleted Successfully!";
                TempData["Success"] = true;
                return RedirectToAction("Index", "State");
            }
            catch (Exception ex)
            {
                TempData["Message"] = ex.Message;
                TempData["Success"] = false;
                return RedirectToAction("Index", "State");
            }
        }


        [HttpGet]
        public async Task<IActionResult> GetSateList(int countryId)
        {
            var states = await _stateService.GetAll().Where(v => v.CountryId == countryId)
                .Select(v => new { v.Id, v.Name }).ToListAsync();
            return new JsonResult(states);
        }

        #region Use for Datatable
        [HttpPost]
        public async Task<IActionResult> GetState([FromBody] JqueryDataTablesParameters param)
        {
            try
            {
                var results = await _stateService.GetState(param);
                HttpContext.Session.SetString(nameof(JqueryDataTablesParameters), JsonSerializer.Serialize(param));
                return new JsonResult(new JqueryDataTablesResult<StateDTO>
                {
                    Draw = param.Draw,
                    Data = results.Items.ToArray(),
                    RecordsFiltered = results.TotalSize,
                    RecordsTotal = results.TotalSize
                });
            }
            catch (Exception e)
            {
                return new JsonResult(new { error = e.Message });
            }
        }

        public async Task<IActionResult> GetExcel()
        {
            var param = HttpContext.Session.GetString(nameof(JqueryDataTablesParameters));
            var results = await _stateService.GetState(JsonSerializer.Deserialize<JqueryDataTablesParameters>(param));
            return new JqueryDataTablesExcelResult<StateDTO>(results.Items, "State", "HRMS-State-Master");
        }

        #endregion
    }
}
