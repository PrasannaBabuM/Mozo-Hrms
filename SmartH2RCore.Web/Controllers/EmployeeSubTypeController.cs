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
    public class EmployeeSubTypeController : BaseController
    {
        private readonly IMapper _mapper;
        private readonly IEmployeeSubTypeServices _employeeSubTypeService;

        public EmployeeSubTypeController(IEmployeeSubTypeServices employeeSubTypeService, IMapper mapper)
        {
            _employeeSubTypeService = employeeSubTypeService;
            _mapper = mapper;
        }

        [Route("employee-sub-type")]
        public IActionResult Index()
        {
            return View("List", new EmployeeSubTypeDTO());
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View("Add");
        }

        [HttpPost]
        public async Task<IActionResult> Add(EmployeeSubTypeDTO model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await _employeeSubTypeService.AddAsync(_mapper.Map<EmployeeSubType>(model));
                    TempData["Message"] = "Employee Sub Type Added Successfully!";
                    TempData["Success"] = true;
                    return RedirectToAction("Index", "EmployeeSubType");
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
       
        //public async Task<IActionResult> GetALLBranchs()    //// this only take refernce don't this copy paste same write method employeesubtype
        //{
        //    var _allbranch = await _branchService.GetAll().Select(s => new { s.Id, s.LocationName }).ToListAsync();
        //    return new JsonResult(_allbranch);
         //}

        [HttpGet]
        public async Task<IActionResult> GetAllEmployeeSubType()
        {
            var EmployeeSubTpye = await _employeeSubTypeService.GetAll().Select(d => new { d.Id, d.Name }).ToListAsync();
            return new  JsonResult(EmployeeSubTpye);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var employeeSubType = await _employeeSubTypeService.FirstOrDefaultAsync(x => x.Id == id);
            return View("Add", _mapper.Map<EmployeeSubTypeDTO>(employeeSubType));
        }

        [HttpPost]
        public async Task<IActionResult> Edit(EmployeeSubTypeDTO model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await _employeeSubTypeService.UpdateAsync(_mapper.Map<EmployeeSubType>(model));
                    TempData["Message"] = "Employee Sub Type Updated Successfully!";
                    TempData["Success"] = true;
                    return RedirectToAction("Index", "EmployeeSubType");
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
                await _employeeSubTypeService.DeleteSoftAsync(id);
                TempData["Message"] = "Employee Sub Type Deleted Successfully!";
                TempData["Success"] = true;
                return RedirectToAction("Index", "EmployeeSubType");
            }
            catch (Exception ex)
            {
                TempData["Message"] = ex.Message;
                TempData["Success"] = false;
                return RedirectToAction("Index", "EmployeeSubType");
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetEmployeeSubType()
        {
            var employeeSubType = await _employeeSubTypeService.GetAll()
                .Select(v => new { v.Id, v.Name }).ToListAsync();
            return new JsonResult(employeeSubType);
        }


        #region Use for Datatable
        [HttpPost]
        public async Task<IActionResult> GetEmployeeSubType([FromBody] JqueryDataTablesParameters param)
        {
            try
            {
                var results = await _employeeSubTypeService.GetEmployeeSubType(param);
                HttpContext.Session.SetString(nameof(JqueryDataTablesParameters), JsonSerializer.Serialize(param));
                return new JsonResult(new JqueryDataTablesResult<EmployeeSubTypeDTO>
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
            var results = await _employeeSubTypeService.GetEmployeeSubType(JsonSerializer.Deserialize<JqueryDataTablesParameters>(param));
            return new JqueryDataTablesExcelResult<EmployeeSubTypeDTO>(results.Items, "EmployeeSubType", "HRMS-EmployeeSubType-Master");
        }

        #endregion
    }
}
