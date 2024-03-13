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
    public class DepartmentController : BaseController
    {
        private readonly IMapper _mapper;
        private readonly IDepartmentServices _departmentService;

        public DepartmentController(IDepartmentServices departmentServices, IMapper mapper)
        {
            _departmentService = departmentServices;
            _mapper = mapper;
        }
       

        [Route("department")]
        public IActionResult Index()
        {
            return View("List", new DepartmentDTO());
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View("Add");
        }

        [HttpPost]
        public async Task<IActionResult> Add(DepartmentDTO model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await _departmentService.AddAsync(_mapper.Map<Department>(model));
                    TempData["Message"] = "Department Added Successfully!";
                    TempData["Success"] = true;
                    return RedirectToAction("Index", "Department");
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

        // public async Task<IActionResult> GetALLBranchs()
        //{
        //    var _allbranch= await _branchService.GetAll().Select(s=>new { s.Id, s.LocationName }).ToListAsync();
        //    return new JsonResult(_allbranch);
        //}


        [HttpGet]
        public async Task<IActionResult> GetAllDepartment()
        {
            var department= await _departmentService.GetAll().Select(d => new {d.Id, d.Name}).ToListAsync();
            return new JsonResult(department);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var department = await _departmentService.FirstOrDefaultAsync(x => x.Id == id);
            return View("Add", _mapper.Map<DepartmentDTO>(department));
        }

        [HttpPost]
        public async Task<IActionResult> Edit(DepartmentDTO model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await _departmentService.UpdateAsync(_mapper.Map<Department>(model));
                    TempData["Message"] = "Department Updated Successfully!";
                    TempData["Success"] = true;
                    return RedirectToAction("Index", "Department");
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
                await _departmentService.DeleteSoftAsync(id);
                TempData["Message"] = "Department Deleted Successfully!";
                TempData["Success"] = true;
                return RedirectToAction("Index", "Department");
            }
            catch (Exception ex)
            {
                TempData["Message"] = ex.Message;
                TempData["Success"] = false;
                return RedirectToAction("Index", "Department");
            }
        }


        #region Use for Datatable
        [HttpPost]
        public async Task<IActionResult> GetDepartment([FromBody] JqueryDataTablesParameters param)
        {
            try
            {
                var results = await _departmentService.GetDepartment(param);
                HttpContext.Session.SetString(nameof(JqueryDataTablesParameters), JsonSerializer.Serialize(param));
                return new JsonResult(new JqueryDataTablesResult<DepartmentDTO>
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
            var results = await _departmentService.GetDepartment(JsonSerializer.Deserialize<JqueryDataTablesParameters>(param));
            return new JqueryDataTablesExcelResult<DepartmentDTO>(results.Items, "Department", "HRMS-Department-Master");
        }

        #endregion
    }
}
