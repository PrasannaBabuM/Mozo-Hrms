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
    public class RoleController : BaseController
    {
        private readonly IMapper _mapper;
        private readonly IRoleService _roleService;

        public RoleController(IRoleService roleService, IMapper mapper)
        {
            _roleService = roleService;
            _mapper = mapper;
        }

        [Route("role")]
        public IActionResult Index()
        {
            return View("List", new RoleDTO());
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View("Add");
        }

        [HttpPost]
        public async Task<IActionResult> Add(RoleDTO model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await _roleService.AddAsync(_mapper.Map<Role>(model));
                    TempData["Message"] = "Role Added Successfully!";
                    TempData["Success"] = true;
                    return RedirectToAction("Index", "Role");
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
        public async Task<IActionResult> GetAllEmployeeRole()
        {
            var EmployeeRole = await _roleService.GetAll().Select(d => new { d.Id, d.Name }).ToListAsync();
            return new JsonResult(EmployeeRole);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var role = await _roleService.FirstOrDefaultAsync(x => x.Id == id);
            return View("Add", _mapper.Map<RoleDTO>(role));
        }

        [HttpPost]
        public async Task<IActionResult> Edit(RoleDTO model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await _roleService.UpdateAsync(_mapper.Map<Role>(model));
                    TempData["Message"] = "Role Updated Successfully!";
                    TempData["Success"] = true;
                    return RedirectToAction("Index", "Role");
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
                await _roleService.DeleteSoftAsync(id);
                TempData["Message"] = "Role Deleted Successfully!";
                TempData["Success"] = true;
                return RedirectToAction("Index", "Role");
            }
            catch (Exception ex)
            {
                TempData["Message"] = ex.Message;
                TempData["Success"] = false;
                return RedirectToAction("Index", "Role");
            }
        }

        #region Use for Datatable
        [HttpPost]
        public async Task<IActionResult> GetRole([FromBody] JqueryDataTablesParameters param)
        {
            try
            {
                var results = await _roleService.GetRole(param);
                HttpContext.Session.SetString(nameof(JqueryDataTablesParameters), JsonSerializer.Serialize(param));
                return new JsonResult(new JqueryDataTablesResult<RoleDTO>
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
            var results = await _roleService.GetRole(JsonSerializer.Deserialize<JqueryDataTablesParameters>(param));
            return new JqueryDataTablesExcelResult<RoleDTO>(results.Items, "Role", "HRMS-Role-Master");
        }

        #endregion
    }
}
