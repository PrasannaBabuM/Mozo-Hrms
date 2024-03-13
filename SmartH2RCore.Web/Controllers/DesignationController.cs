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
    public class DesignationController : BaseController
    {
        private readonly IMapper _mapper;
        private readonly IDesignationService _designationService;

        public DesignationController(IDesignationService designationService, IMapper mapper)
        {
            _designationService = designationService;
            _mapper = mapper;
        }
      

        [Route("designation")]
        public IActionResult Index()
        {
            return View("List", new DesignationDTO());
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View("Add");
        }

        [HttpPost]
        public async Task<IActionResult> Add(DesignationDTO model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await _designationService.AddAsync(_mapper.Map<Designation>(model));
                    TempData["Message"] = "Designation Added Successfully!";
                    TempData["Success"] = true;
                    return RedirectToAction("Index", "Designation");
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
        //public async Task<IActionResult> GetALLBranchs()                                                            //Such take reference this one help for method caling to sites Json
        //{
        //    var _allbranch = await _branchService.GetAll().Select(s => new { s.Id, s.LocationName }).ToListAsync();
        //    return new JsonResult(_allbranch);
        //}
        [HttpGet]
        public async Task<IActionResult> GetAllDesgination()
        {
            var Desgination = await _designationService.GetAll().Select(d => new { d.Id, d.Name }).ToListAsync();
            return new JsonResult ( Desgination );
        }
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var designation = await _designationService.FirstOrDefaultAsync(x => x.Id == id);
            return View("Add", _mapper.Map<DesignationDTO>(designation));
        }

        [HttpPost]
        public async Task<IActionResult> Edit(DesignationDTO model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await _designationService.UpdateAsync(_mapper.Map<Designation>(model));
                    TempData["Message"] = "Designation Updated Successfully!";
                    TempData["Success"] = true;
                    return RedirectToAction("Index", "Designation");
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
                await _designationService.DeleteSoftAsync(id);
                TempData["Message"] = "Designation Deleted Successfully!";
                TempData["Success"] = true;
                return RedirectToAction("Index", "Designation");
            }
            catch (Exception ex)
            {
                TempData["Message"] = ex.Message;
                TempData["Success"] = false;
                return RedirectToAction("Index", "Designation");
            }
        }

        #region Use for Datatable
        [HttpPost]
        public async Task<IActionResult> GetDesignation([FromBody] JqueryDataTablesParameters param)
        {
            try
            {
                var results = await _designationService.GetDesignation(param);
                HttpContext.Session.SetString(nameof(JqueryDataTablesParameters), JsonSerializer.Serialize(param));
                return new JsonResult(new JqueryDataTablesResult<DesignationDTO>
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
            var results = await _designationService.GetDesignation(JsonSerializer.Deserialize<JqueryDataTablesParameters>(param));
            return new JqueryDataTablesExcelResult<DesignationDTO>(results.Items, "Designation", "HRMS-Designation-Master");
        }

        #endregion
    }
}
