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
    public class CurrencyController : BaseController
    {
        private readonly IMapper _mapper;
        private readonly ICurrencyService _currencyService;

        public CurrencyController(ICurrencyService currencyService, IMapper mapper)
        {
            _currencyService = currencyService;
            _mapper = mapper;
        }

        [Route("currency")]
        public IActionResult Index()
        {
            return View("List", new CurrencyDTO());
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View("Add");
        }

        [HttpPost]
        public async Task<IActionResult> Add(CurrencyDTO model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await _currencyService.AddAsync(_mapper.Map<Currency>(model));
                    TempData["Message"] = "Currency Added Successfully!";
                    TempData["Success"] = true;
                    return RedirectToAction("Index", "Currency");
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
            var currency = await _currencyService.FirstOrDefaultAsync(x => x.Id == id);
            return View("Add", _mapper.Map<CurrencyDTO>(currency));
        }

        [HttpPost]
        public async Task<IActionResult> Edit(CurrencyDTO model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await _currencyService.UpdateAsync(_mapper.Map<Currency>(model));
                    TempData["Message"] = "Currency Updated Successfully!";
                    TempData["Success"] = true;
                    return RedirectToAction("Index", "Currency");
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
                await _currencyService.DeleteSoftAsync(id);
                TempData["Message"] = "Currency Deleted Successfully!";
                TempData["Success"] = true;
                return RedirectToAction("Index", "Currency");
            }
            catch (Exception ex)
            {
                TempData["Message"] = ex.Message;
                TempData["Success"] = false;
                return RedirectToAction("Index", "Currency");
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetCurrency()
        {
            var currency = await _currencyService.GetAll().ToListAsync();
            return new JsonResult(currency);
        }


        #region Use for Datatable
        [HttpPost]
        public async Task<IActionResult> GetCurrency([FromBody] JqueryDataTablesParameters param)
        {
            try
            {
                var results = await _currencyService.GetCurrency(param);
                HttpContext.Session.SetString(nameof(JqueryDataTablesParameters), JsonSerializer.Serialize(param));
                return new JsonResult(new JqueryDataTablesResult<CurrencyDTO>
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
            var results = await _currencyService.GetCurrency(JsonSerializer.Deserialize<JqueryDataTablesParameters>(param));
            return new JqueryDataTablesExcelResult<CurrencyDTO>(results.Items, "Currency", "HRMS-Currency-Master");
        }

        #endregion
    }
}
