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
    public class GradeController : BaseController
    {
        private readonly IMapper _mapper;
        private readonly IGradeService _gradeService;

        public GradeController(IGradeService gradeService, IMapper mapper)
        {
            _gradeService = gradeService;
            _mapper = mapper;
        }

        [Route("grade")]
        public IActionResult Index()
        {
            return View("List", new GradeDTO());
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View("Add");
        }

        [HttpPost]
        public async Task<IActionResult> Add(GradeDTO model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await _gradeService.AddAsync(_mapper.Map<Grade>(model));
                    TempData["Message"] = "Grade Added Successfully!";
                    TempData["Success"] = true;
                    return RedirectToAction("Index", "Grade");
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
            var grade = await _gradeService.FirstOrDefaultAsync(x => x.Id == id);
            return View("Add", _mapper.Map<GradeDTO>(grade));
        }

        [HttpPost]
        public async Task<IActionResult> Edit(GradeDTO model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await _gradeService.UpdateAsync(_mapper.Map<Grade>(model));
                    TempData["Message"] = "Grade Updated Successfully!";
                    TempData["Success"] = true;
                    return RedirectToAction("Index", "Grade");
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
                await _gradeService.DeleteSoftAsync(id);
                TempData["Message"] = "Grade Deleted Successfully!";
                TempData["Success"] = true;
                return RedirectToAction("Index", "Grade");
            }
            catch (Exception ex)
            {
                TempData["Message"] = ex.Message;
                TempData["Success"] = false;
                return RedirectToAction("Index", "Grade");
            }
        }

        #region Use for Datatable
        [HttpPost]
        public async Task<IActionResult> GetGrade([FromBody] JqueryDataTablesParameters param)
        {
            try
            {
                var results = await _gradeService.GetGrade(param);
                HttpContext.Session.SetString(nameof(JqueryDataTablesParameters), JsonSerializer.Serialize(param));
                return new JsonResult(new JqueryDataTablesResult<GradeDTO>
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
            var results = await _gradeService.GetGrade(JsonSerializer.Deserialize<JqueryDataTablesParameters>(param));
            return new JqueryDataTablesExcelResult<GradeDTO>(results.Items, "Grade", "HRMS-Grade-Master");
        }

        #endregion
    }
}
