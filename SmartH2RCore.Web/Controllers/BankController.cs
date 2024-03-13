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
    public class BankController : BaseController
    {
        private readonly IMapper _mapper;
        private readonly IBankService _bankService;

        public BankController(IBankService bankService, IMapper mapper)
        {
            _bankService = bankService;
            _mapper = mapper;
        }

        [Route("Bank")]
        public IActionResult Index()
        {
            return View("List", new BankDTO());
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View("Add");
        }

        [HttpPost]
        public async Task<IActionResult> Add(BankDTO model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await _bankService.AddAsync(_mapper.Map<Bank>(model));
                    TempData["Message"] = "Bank Added Successfully!";
                    TempData["Success"] = true;
                    return RedirectToAction("Index", "Bank");
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
            var bank = await _bankService.FirstOrDefaultAsync(x => x.Id == id);
            return View("Add", _mapper.Map<BankDTO>(bank));
        }

        [HttpPost]
        public async Task<IActionResult> Edit(BankDTO model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await _bankService.UpdateAsync(_mapper.Map<Bank>(model));
                    TempData["Message"] = "Bank Updated Successfully!";
                    TempData["Success"] = true;
                    return RedirectToAction("Index", "Bank");
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
                await _bankService.DeleteSoftAsync(id);
                TempData["Message"] = "Bank Deleted Successfully!";
                TempData["Success"] = true;
                return RedirectToAction("Index", "Bank");
            }
            catch (Exception ex)
            {
                TempData["Message"] = ex.Message;
                TempData["Success"] = false;
                return RedirectToAction("Index", "Bank");
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetBankList()
        {
            var bank = await _bankService.GetAll().ToListAsync();
            return new JsonResult(bank);
        }


        #region Use for Datatable
        [HttpPost]
        public async Task<IActionResult> GetBank([FromBody] JqueryDataTablesParameters param)
        {
            try
            {
                var results = await _bankService.GetBank(param);
                HttpContext.Session.SetString(nameof(JqueryDataTablesParameters), JsonSerializer.Serialize(param));
                return new JsonResult(new JqueryDataTablesResult<BankDTO>
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
            var results = await _bankService.GetBank(JsonSerializer.Deserialize<JqueryDataTablesParameters>(param));
            return new JqueryDataTablesExcelResult<BankDTO>(results.Items, "Bank", "HRMS-Bank-Master");
        }

        #endregion
    }
}
