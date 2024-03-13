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

    public class CityController : BaseController
    {
        private readonly IMapper _mapper;
        private readonly ICityService _cityService;

        public CityController(ICityService cityService, IMapper mapper)
        {
            _cityService = cityService;
            _mapper = mapper;
        }

        [Route("City")]
        public IActionResult Index()
        {
            return View("List", new CityDTO());
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View("Add");
        }

        [HttpPost]
        public async Task<IActionResult> Add(CityDTO model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await _cityService.AddAsync(_mapper.Map<City>(model));
                    TempData["Message"] = "City Added Successfully!";
                    TempData["Success"] = true;
                    return RedirectToAction("Index", "City");
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
        public IActionResult Edit(int id)
        {
            var City = _cityService.FindBy(x => x.Id == id).FirstOrDefault();
            return View("Add", _mapper.Map<CityDTO>(City));
        }

        [HttpPost]
        public async Task<IActionResult> Edit(CityDTO model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await _cityService.UpdateAsync(_mapper.Map<City>(model));
                    TempData["Message"] = "City Updated Successfully!";
                    TempData["Success"] = true;
                    return RedirectToAction("Index", "City");
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
                await _cityService.DeleteSoftAsync(id);
                TempData["Message"] = "City Deleted Successfully!";
                TempData["Success"] = true;
                return RedirectToAction("Index", "City");
            }
            catch (Exception ex)
            {
                TempData["Message"] = ex.Message;
                TempData["Success"] = false;
                return RedirectToAction("Index", "City");
            }
        }


        [HttpGet]
        public async Task<IActionResult> GetCityList(int stateid)
        {
            var City = await _cityService.GetAll().Where(x => x.StateId == stateid).ToListAsync();
            return new JsonResult(City);
        }

        #region Use for Datatable
        [HttpPost]
        public async Task<IActionResult> GetCity([FromBody] JqueryDataTablesParameters param)
        {
            try
            {
                var results = await _cityService.GetCity(param);
                HttpContext.Session.SetString(nameof(JqueryDataTablesParameters), JsonSerializer.Serialize(param));
                return new JsonResult(new JqueryDataTablesResult<CityDTO>
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
            var results = await _cityService.GetCity(JsonSerializer.Deserialize<JqueryDataTablesParameters>(param));
            return new JqueryDataTablesExcelResult<CityDTO>(results.Items, "City", "HRMS-City-Master");
        }

        #endregion
    }
}
