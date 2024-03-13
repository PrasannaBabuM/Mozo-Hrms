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
    public class EmployeeTypeController : BaseController
    {
        private readonly IMapper _mapper;
        private readonly IEmployeeTypeServices _employeeTypeService;

        public EmployeeTypeController(IEmployeeTypeServices employeeTypeService, IMapper mapper)
        {
            _employeeTypeService = employeeTypeService;
            _mapper = mapper;
        }

        [Route("employee-type")]
        public IActionResult Index()
        {
            return View("List", new EmployeeTypeDTO());
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View("Add");
        }

        [HttpPost]
        public async Task<IActionResult> Add(EmployeeTypeDTO model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await _employeeTypeService.AddAsync(_mapper.Map<EmployeeType>(model));
                    TempData["Message"] = "Employee Type Added Successfully!";
                    TempData["Success"] = true;
                    return RedirectToAction("Index", "EmployeeType");
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
        //public async Task<IActionResult> GetALLBranchs()               /// GetALLBranchs Method only refernce please don't take it 
        //{
        //    var _allbranch = await _branchService.GetAll().Select(s => new { s.Id, s.LocationName }).ToListAsync();
        //    return new JsonResult(_allbranch);
        //}

        [HttpGet]
        public async Task<IActionResult> GetAllEmployeeTpye()
        {
            var EmployeeType = await _employeeTypeService.GetAll().Select(d => new { d.Id, d.Name }).ToListAsync();
            return new JsonResult(EmployeeType);
        }




        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var employeeType = await _employeeTypeService.FirstOrDefaultAsync(x => x.Id == id);
            return View("Add", _mapper.Map<EmployeeTypeDTO>(employeeType));
        }

        [HttpPost]
        public async Task<IActionResult> Edit(EmployeeTypeDTO model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await _employeeTypeService.UpdateAsync(_mapper.Map<EmployeeType>(model));
                    TempData["Message"] = "Employee Type Updated Successfully!";
                    TempData["Success"] = true;
                    return RedirectToAction("Index", "EmployeeType");
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
                await _employeeTypeService.DeleteSoftAsync(id);
                TempData["Message"] = "Employee Type Deleted Successfully!";
                TempData["Success"] = true;
                return RedirectToAction("Index", "EmployeeType");
            }
            catch (Exception ex)
            {
                TempData["Message"] = ex.Message;
                TempData["Success"] = false;
                return RedirectToAction("Index", "EmployeeType");
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetEmployeeType()
        {
            var employeeType = await _employeeTypeService.GetAll()
                .Select(v => new { v.Id, v.Name }).ToListAsync();
            return new JsonResult(employeeType);
        }


        #region Use for Datatable
        [HttpPost]
        public async Task<IActionResult> GetEmployeeType([FromBody] JqueryDataTablesParameters param)
        {
            try
            {
                var results = await _employeeTypeService.GetEmployeeType(param);
                HttpContext.Session.SetString(nameof(JqueryDataTablesParameters), JsonSerializer.Serialize(param));
                return new JsonResult(new JqueryDataTablesResult<EmployeeTypeDTO>
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
            var results = await _employeeTypeService.GetEmployeeType(JsonSerializer.Deserialize<JqueryDataTablesParameters>(param));
            return new JqueryDataTablesExcelResult<EmployeeTypeDTO>(results.Items, "EmployeeType", "HRMS-EmployeeType-Master");
        }

        #endregion
    }
}
