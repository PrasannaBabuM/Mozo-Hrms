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
    public class BranchController : BaseController
    {
        private readonly IMapper _mapper;
        private readonly IBranchService _branchService;

        public BranchController(IBranchService branchService, IMapper mapper)
        {
            _branchService = branchService;
            _mapper = mapper;
        }

        [Route("branch")]
        public IActionResult Index()
        {
            return View("List", new BranchDTO());
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View("Add");
        }

        [HttpPost]
        public async Task<IActionResult> Add(BranchDTO model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await _branchService.AddAsync(_mapper.Map<Branch>(model));
                    TempData["Message"] = "Branch Added Successfully!";
                    TempData["Success"] = true;
                    return RedirectToAction("Index", "Branch");
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
            var branch = await _branchService.FirstOrDefaultAsync(x => x.Id == id);
            return View("Add", _mapper.Map<BranchDTO>(branch));
        }

        [HttpPost]
        public async Task<IActionResult> Edit(BranchDTO model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await _branchService.UpdateAsync(_mapper.Map<Branch>(model));
                    TempData["Message"] = "Branch Updated Successfully!";
                    TempData["Success"] = true;
                    return RedirectToAction("Index", "Branch");
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
        public async Task<IActionResult> GetALLBranchs()
        {
            var _allbranch = await _branchService.GetAll().Select(s => new { s.Id, s.LocationName }).ToListAsync();
            return new JsonResult(_allbranch);
        }

        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                await _branchService.DeleteSoftAsync(id);
                TempData["Message"] = "Branch Deleted Successfully!";
                TempData["Success"] = true;
                return RedirectToAction("Index", "Branch");
            }
            catch (Exception ex)
            {
                TempData["Message"] = ex.Message;
                TempData["Success"] = false;
                return RedirectToAction("Index", "Branch");
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetBranch(int companyId)
        {
            var branch = await _branchService.GetAll().Where(v => v.CompanyId == companyId).Select(v => new { v.Id, v.LocationName }).ToListAsync();
            return new JsonResult(branch);
        }


        #region Use for Datatable
        [HttpPost]
        public async Task<IActionResult> GetBranch([FromBody] JqueryDataTablesParameters param)
        {

            try
            {
                var results = await _branchService.GetBranch(param, LoginUser.Id);
                HttpContext.Session.SetString(nameof(JqueryDataTablesParameters), JsonSerializer.Serialize(param));
                return new JsonResult(new JqueryDataTablesResult<BranchDTO>
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
            var results = await _branchService.GetBranch(JsonSerializer.Deserialize<JqueryDataTablesParameters>(param), 0);
            return new JqueryDataTablesExcelResult<BranchDTO>(results.Items, "Branch", "HRMS-Branch-Master");
        }

        #endregion
    }
}
