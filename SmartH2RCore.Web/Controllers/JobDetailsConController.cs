using AutoMapper;
using DocumentFormat.OpenXml.Office.CustomXsn;
using JqueryDataTables.ServerSide.AspNetCoreWeb.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartH2RCore.Core.Migrations;
using SmartH2RCore.Models.Common;
using SmartH2RCore.Models.DTO;
using SmartH2RCore.Models.DTO.Employee;
using SmartH2RCore.Models.DTO.EmployeeDTO;
using SmartH2RCore.Models.DTO.Master;
using SmartH2RCore.Models.Employee;
using SmartH2RCore.Models.Identity;
using SmartH2RCore.Services.Interface.Employee;
using SmartH2RCore.Services.Service.Employee;
using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;



namespace SmartH2RCore.Web.Controllers
{
    public class JobDetailsConController : BaseController

    {
        private readonly IMapper _mapper;
        private readonly IJobDetailsService _jobDetailsService;
        //private readonly Microsoft.Extensions.Configuration.IConfiguration _iconfiguration;
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        //private readonly object employeeData;
      
        public JobDetailsConController(IJobDetailsService jobDetailsService, IMapper mapper, /*Microsoft.Extensions.Configuration.IConfiguration iconfiguration,*/ UserManager<User> userManager, SignInManager<User> signInManager)
        {
            _jobDetailsService = jobDetailsService;
            _mapper = mapper;
            //_iconfiguration = iconfiguration;
            _userManager = userManager;
            _signInManager = signInManager;
           
        }

        [Route("JobDetailsCon")]
        [HttpGet]
        public IActionResult Index()
        {
            return View("List", new JobDetailsDTO());
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View("Add");
        }

        //public static string Encrypt(string plainText)
        //{
        //    if (plainText == null) throw new ArgumentNullException(nameof(plainText));

        //    byte[] data = Encoding.Unicode.GetBytes(plainText);

        //    // Set the data protection scope
        //    DataProtectionScope scope = DataProtectionScope.CurrentUser; // or DataProtectionScope.LocalMachine;

        //    byte[] encrypted = ProtectedData.Protect(data, null, scope);

        //    return Convert.ToBase64String(encrypted);
        //}

       


        [HttpPost]
        public async Task<IActionResult> Add(JobDetailsDTO model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    


                    var user = new User
                    {
                        UserName = model.UserName,
                        PasswordHash = model.PasswordHash,
                        
                        //NormalizedUserName = model.NormalizedUserName
                    };

                    // Assuming _userManager is used to create the user
                    var result = await _userManager.CreateAsync(user, model.PasswordHash);

                    // User creation successful
                    model.Employee.PasswordHash = model.PasswordHash;
                    model.Employee.UserName = model.UserName;
                    var files = HttpContext.Request.Form.Files;
                    if (model.Employee.Photo != null)
                    {



                        string folder = "~/wwwroot/images/profiles/";
                        var filecount = Directory.GetFiles(folder).Length;
                        folder += (model.Employee.Photo + Guid.NewGuid().ToString());
                        string serverFolder = Path.Combine(folder);
                    }



                    if (model.Employee.Photo != null)
                    {
                        string folder = "ImageName/Cover";
                        folder += (model.Employee.Photo + Guid.NewGuid().ToString());
                        string serverFolder = Path.Combine(folder);
                    }
                    //model.Employee.NormalizedUserName = model.NormalizedUserName;

                    if (result.Succeeded)
                    {
                        await _jobDetailsService.AddAsync(_mapper.Map<JobDetails>(model));

                        TempData["Message"] = "Jobdetails Added Successfully!";
                        TempData["Success"] = true;
                        return RedirectToAction("Index", "JobDetailsCon");
                    }
                    else
                    {
                        // User creation failed, handle the errors
                        foreach (var error in result.Errors)
                        {
                            ModelState.AddModelError(string.Empty, error.Description);
                        }
                        return View("Add", model);
                    }
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
        public async Task<IActionResult> GetJobdetails(int companyId, int BranchId, int DepartmentId)
        {
            var jobdetail = await _jobDetailsService.GetAll().Where(v => v.CompanyId == companyId).Select(v => new { v.Id, v.BranchId }).ToListAsync();
            return new JsonResult(jobdetail);
        }
        [HttpGet]
        
        public async Task<IActionResult> GetJobdetail(int BranchId)
        {
            var jobdtl = await _jobDetailsService.GetAll().Where(v => v.BranchId == BranchId).Select(v => new { v.Id, v.BranchId }).ToListAsync();
            return new JsonResult(jobdtl);
        }
        [HttpGet]
        public async Task<IActionResult> GetDepatment(int DepartmentId)
        {
            var Department = await _jobDetailsService.GetAll().Where(v => v.DepartmentId == DepartmentId).Select(v => new { v.Id, v.DepartmentId }).ToListAsync();
            return new JsonResult(Department);
        }
        [HttpGet]
        public async Task<IActionResult> GetAlluser()
        {
            var user = await _jobDetailsService.GetAll().Select(d => new { d.Employee.Id }).ToListAsync(); 
            return new JsonResult(user);
        }

        #region Use for Datatable
        [HttpPost]
        public async Task<IActionResult> GetJobDetailes([FromBody] JqueryDataTablesParameters param)
        {
            try
            {
                var result = await _jobDetailsService.GetJobDetailes(param, LoginUser.Id);
                HttpContext.Session.SetString(nameof(JqueryDataTablesParameters), JsonSerializer.Serialize(param));
                return new JsonResult(new JqueryDataTablesResult<JobDetailsDTO>
                {
                    Draw = param.Draw,
                    Data = result.Items.ToArray(),
                    RecordsFiltered = result.TotalSize,
                    RecordsTotal = result.TotalSize
                }) ;
            }
            catch (Exception e)
            {
                return new JsonResult(new { error = e.Message });
            }
        }
        #endregion
      

    }
}
