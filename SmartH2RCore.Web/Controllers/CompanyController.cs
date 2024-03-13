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
    public class CompanyController : BaseController
    {
        private readonly IMapper _mapper;
        private readonly ICompanyServices _companyService;

        public CompanyController(ICompanyServices companyService, IMapper mapper)
        {
            _companyService = companyService;
            _mapper = mapper;
        }

        [Route("company")]
        public IActionResult Index()
        {
            return View("List", new CompanyDTO());
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View("Add");
        }

        [HttpPost]
        public async Task<IActionResult> Add(CompanyDTO model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    model.OwnerId = LoginUser.Id;
                    await _companyService.AddAsync(_mapper.Map<Company>(model));
                    TempData["Message"] = "Company Added Successfully!";
                    TempData["Success"] = true;
                    return RedirectToAction("Index", "Company");
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
            var company = await _companyService.FirstOrDefaultAsync(x => x.Id == id);
            return View("Add", _mapper.Map<CompanyDTO>(company));
        }

        [HttpPost]
        public async Task<IActionResult> Edit(CompanyDTO model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    model.OwnerId = LoginUser.Id;
                    await _companyService.UpdateAsync(_mapper.Map<Company>(model));
                    TempData["Message"] = "Company Updated Successfully!";
                    TempData["Success"] = true;
                    return RedirectToAction("Index", "Company");
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
                await _companyService.DeleteSoftAsync(id);
                TempData["Message"] = "Company Deleted Successfully!";
                TempData["Success"] = true;
                return RedirectToAction("Index", "Company");
            }
            catch (Exception ex)
            {
                TempData["Message"] = ex.Message;
                TempData["Success"] = false;
                return RedirectToAction("Index", "Company");
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetCompany()
        {
            var company = await _companyService.GetAll().Where(v => v.OwnerId == LoginUser.Id).ToListAsync();
            return new JsonResult(company);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCompany()
        {
            //var company = await _companyService.GetAll().Where(v => v.IsActive == true).ToListAsync();
            var company = await _companyService.GetAll().ToListAsync();
            return new JsonResult(company);
        }



        #region Use for Datatable
        [HttpPost]
        public async Task<IActionResult> GetCompany([FromBody] JqueryDataTablesParameters param)
        {
            try
            {
                var results = await _companyService.GetCompany(param);
                HttpContext.Session.SetString(nameof(JqueryDataTablesParameters), JsonSerializer.Serialize(param));
                return new JsonResult(new JqueryDataTablesResult<CompanyDTO>
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
            var results = await _companyService.GetCompany(JsonSerializer.Deserialize<JqueryDataTablesParameters>(param));
            return new JqueryDataTablesExcelResult<CompanyDTO>(results.Items, "Company", "HRMS-Company-Master");
        }

        #endregion
    }
}
