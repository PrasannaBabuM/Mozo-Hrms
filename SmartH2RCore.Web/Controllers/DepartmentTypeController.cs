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
    public class DepartmentTypeController : BaseController
    {
        private readonly IMapper _mapper;
        private readonly IDepartmentTypeServices _departmentTypeServices;

        public DepartmentTypeController(IDepartmentTypeServices departmentTypeServices, IMapper mapper)
        {
            _departmentTypeServices = departmentTypeServices;
            _mapper = mapper;
        }

        [Route("department-type")]
        public IActionResult Index()
        {
            return View("List", new DepartmentTypeDTO());
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View("Add");
        }

        [HttpPost]
        public async Task<IActionResult> Add(DepartmentTypeDTO model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await _departmentTypeServices.AddAsync(_mapper.Map<DepartmentType>(model));
                    TempData["Message"] = "Department Type Added Successfully!";
                    TempData["Success"] = true;
                    return RedirectToAction("Index", "DepartmentType");
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
            var departmentType = await _departmentTypeServices.FirstOrDefaultAsync(x => x.Id == id);
            return View("Add", _mapper.Map<DepartmentTypeDTO>(departmentType));
        }

        [HttpPost]
        public async Task<IActionResult> Edit(DepartmentTypeDTO model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await _departmentTypeServices.UpdateAsync(_mapper.Map<DepartmentType>(model));
                    TempData["Message"] = "Department Type Updated Successfully!";
                    TempData["Success"] = true;
                    return RedirectToAction("Index", "DepartmentType");
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
                await _departmentTypeServices.DeleteSoftAsync(id);
                TempData["Message"] = "Department Type Deleted Successfully!";
                TempData["Success"] = true;
                return RedirectToAction("Index", "DepartmentType");
            }
            catch (Exception ex)
            {
                TempData["Message"] = ex.Message;
                TempData["Success"] = false;
                return RedirectToAction("Index", "DepartmentType");
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetDepartmentType()
        {
            var employeeType = await _departmentTypeServices.GetAll()
                .Select(v => new { v.Id, v.Name }).ToListAsync();
            return new JsonResult(employeeType);
        }

        #region Use for Datatable
        [HttpPost]
        public async Task<IActionResult> GetDepartmentType([FromBody] JqueryDataTablesParameters param)
        {
            try
            {
                var results = await _departmentTypeServices.GetDepartmentType(param);
                HttpContext.Session.SetString(nameof(JqueryDataTablesParameters), JsonSerializer.Serialize(param));
                return new JsonResult(new JqueryDataTablesResult<DepartmentTypeDTO>
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
            var results = await _departmentTypeServices.GetDepartmentType(JsonSerializer.Deserialize<JqueryDataTablesParameters>(param));
            return new JqueryDataTablesExcelResult<DepartmentTypeDTO>(results.Items, "DepartmentType", "HRMS-DepartmentType-Master");
        }

        #endregion
    }
}
