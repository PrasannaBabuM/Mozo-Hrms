using AutoMapper;

using JqueryDataTables.ServerSide.AspNetCoreWeb.ActionResults;
using JqueryDataTables.ServerSide.AspNetCoreWeb.Models;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using SmartH2RCore.Models.Common;
using SmartH2RCore.Models.DTO.Master;
using SmartH2RCore.Services.Interface;

using System;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace SmartH2RCore.Web.Controllers
{
    public class AccountTypeController : BaseController
    {
        private readonly IMapper _mapper;
        private readonly IAccountTypeService _accountTypeService;

        public AccountTypeController(IAccountTypeService accountTypeService, IMapper mapper)
        {
            _accountTypeService = accountTypeService;
            _mapper = mapper;
        }

        [Route("account-types")]
        public IActionResult Index()
        {
            return View("List", new AccountTypeDTO());
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View("Add");
        }

        [HttpPost]
        public async Task<IActionResult> Add(AccountTypeDTO model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await _accountTypeService.AddAsync(_mapper.Map<AccountType>(model));
                    TempData["Message"] = "Account Type Added Successfully!";
                    TempData["Success"] = true;
                    return RedirectToAction("Index", "AccountType");
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
            var accountType = await _accountTypeService.FirstOrDefaultAsync(x => x.Id == id);
            return View("Add", _mapper.Map<AccountTypeDTO>(accountType));
        }

        [HttpPost]
        public async Task<IActionResult> Edit(AccountTypeDTO model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await _accountTypeService.UpdateAsync(_mapper.Map<AccountType>(model));
                    TempData["Message"] = "Account Type Updated Successfully!";
                    TempData["Success"] = true;
                    return RedirectToAction("Index", "AccountType");
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
                await _accountTypeService.DeleteSoftAsync(id);
                TempData["Message"] = "Account Type Deleted Successfully!";
                TempData["Success"] = true;
                return RedirectToAction("Index", "AccountType");
            }
            catch (Exception ex)
            {
                TempData["Message"] = ex.Message;
                TempData["Success"] = false;
                return RedirectToAction("Index", "AccountType");
            }
        }

        #region Use for Datatable
        [HttpPost]
        public async Task<IActionResult> GetAccountType([FromBody] JqueryDataTablesParameters param)
        {
            try
            {
                var results = await _accountTypeService.GetAccountType(param);
                HttpContext.Session.SetString(nameof(JqueryDataTablesParameters), JsonSerializer.Serialize(param));
                return new JsonResult(new JqueryDataTablesResult<AccountTypeDTO>
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
            var results = await _accountTypeService.GetAccountType(JsonSerializer.Deserialize<JqueryDataTablesParameters>(param));
            return new JqueryDataTablesExcelResult<AccountTypeDTO>(results.Items, "AccountType", "HRMS-AccountType-Master");
        }

        #endregion
    }
}
