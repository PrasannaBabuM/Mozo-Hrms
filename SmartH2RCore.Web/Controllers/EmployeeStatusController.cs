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
    public class EmployeeStatusController : BaseController
    {
        private readonly IMapper _mapper;
        private readonly IEmployeeStatusService _employeeStatusService;

        public EmployeeStatusController(IEmployeeStatusService employeeStatusService, IMapper mapper)
        {
            _employeeStatusService = employeeStatusService;
            _mapper = mapper;
        }

        [Route("employeeStatus")]
        public IActionResult Index()
        {
            return View("List", new EmployeeStatusDTO());
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View("Add");
        }

        [HttpPost]
        public async Task<IActionResult> Add(EmployeeStatusDTO model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await _employeeStatusService.AddAsync(_mapper.Map<EmployeeStatus>(model));
                    TempData["Message"] = "Employee Status Added Successfully!";
                    TempData["Success"] = true;
                    return RedirectToAction("Index", "EmployeeStatus");
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
        public async Task<IActionResult> GetAllEmployeeStatus()
        {
            var _allbranch = await _employeeStatusService.GetAll().Select(s => new { s.Id, s.Name }).ToListAsync();
            return new JsonResult(_allbranch);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var employeeStatus = await _employeeStatusService.FirstOrDefaultAsync(x => x.Id == id);
            return View("Add", _mapper.Map<EmployeeStatusDTO>(employeeStatus));
        }

        [HttpPost]
        public async Task<IActionResult> Edit(EmployeeStatusDTO model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await _employeeStatusService.UpdateAsync(_mapper.Map<EmployeeStatus>(model));
                    TempData["Message"] = "Employee Status Updated Successfully!";
                    TempData["Success"] = true;
                    return RedirectToAction("Index", "EmployeeStatus");
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
                await _employeeStatusService.DeleteSoftAsync(id);
                TempData["Message"] = "Employee Status Deleted Successfully!";
                TempData["Success"] = true;
                return RedirectToAction("Index", "EmployeeStatus");
            }
            catch (Exception ex)
            {
                TempData["Message"] = ex.Message;
                TempData["Success"] = false;
                return RedirectToAction("Index", "EmployeeStatus");
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetEmployeeStatus()
        {
            var employeeStatus = await _employeeStatusService.GetAll().ToListAsync();
            return new JsonResult(employeeStatus);
        }


        #region Use for Datatable
        [HttpPost]
        public async Task<IActionResult> GetEmployeeStatus([FromBody] JqueryDataTablesParameters param)
        {
            try
            {
                var results = await _employeeStatusService.GetEmployeeStatus(param);
                HttpContext.Session.SetString(nameof(JqueryDataTablesParameters), JsonSerializer.Serialize(param));
                return new JsonResult(new JqueryDataTablesResult<EmployeeStatusDTO>
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
            var results = await _employeeStatusService.GetEmployeeStatus(JsonSerializer.Deserialize<JqueryDataTablesParameters>(param));
            return new JqueryDataTablesExcelResult<EmployeeStatusDTO>(results.Items, "EmployeeStatus", "HRMS-EmployeeStatus-Master");
        }

        #endregion
    }
}
