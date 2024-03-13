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

    public class CountryController : BaseController
    {
        private readonly IMapper _mapper;
        private readonly ICountryService _countryService;

        public CountryController(ICountryService countryService, IMapper mapper)
        {
            _countryService = countryService;
            _mapper = mapper;
        }

        [Route("country")]
        public IActionResult Index()
        {
            return View("List", new CountryDTO());
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View("Add");
        }

        [HttpPost]
        public async Task<IActionResult> Add(CountryDTO model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await _countryService.AddAsync(_mapper.Map<Country>(model));
                    TempData["Message"] = "Country Added Successfully!";
                    TempData["Success"] = true;
                    return RedirectToAction("Index", "Country");
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
            var country = await _countryService.FirstOrDefaultAsync(x => x.Id == id);
            return View("Add", _mapper.Map<CountryDTO>(country));
        }

        [HttpPost]
        public async Task<IActionResult> Edit(CountryDTO model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await _countryService.UpdateAsync(_mapper.Map<Country>(model));
                    TempData["Message"] = "Country Updated Successfully!";
                    TempData["Success"] = true;
                    return RedirectToAction("Index", "Country");
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
                await _countryService.DeleteSoftAsync(id);
                TempData["Message"] = "Country Deleted Successfully!";
                TempData["Success"] = true;
                return RedirectToAction("Index", "Country");
            }
            catch (Exception ex)
            {
                TempData["Message"] = ex.Message;
                TempData["Success"] = false;
                return RedirectToAction("Index", "Country");
            }
        }


        [HttpGet]
        public async Task<IActionResult> GetCountry()
        {
            var country = await _countryService.GetAll()
                .Select(v => new { v.Id, v.Name }).ToListAsync();
            return new JsonResult(country);
        }

        #region Use for Datatable
        [HttpPost]
        public async Task<IActionResult> GetCountry([FromBody] JqueryDataTablesParameters param)
        {
            try
            {
                var results = await _countryService.GetCountry(param);
                HttpContext.Session.SetString(nameof(JqueryDataTablesParameters), JsonSerializer.Serialize(param));
                return new JsonResult(new JqueryDataTablesResult<CountryDTO>
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
            var results = await _countryService.GetCountry(JsonSerializer.Deserialize<JqueryDataTablesParameters>(param));
            return new JqueryDataTablesExcelResult<CountryDTO>(results.Items, "Country", "HRMS-Country-Master");
        }

        #endregion
    }
}
