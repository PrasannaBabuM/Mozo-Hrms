using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

using SmartH2RCore.Models.Common;
using SmartH2RCore.Models.Enumes;
using SmartH2RCore.Services.Interface;
using SmartH2RCore.Web.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartH2RCore.Web.Controllers
{
    public class CompanySettingsController : BaseController
    {
        private readonly ICurrencyService _currencyService;
        private readonly IBranchCurrencyCodeServices _branchCurrencyCodeServices;
        private readonly IBranchCityServices _branchCityService;
        private readonly ICityService _cityService;
        private readonly IBranchStateService _branchStateService;
        private readonly IStateService _stateService;
        private readonly IBranchCountryService _branchCountryService;
        private readonly ICountryService _countryService;
        private readonly IBranchDepartmentServices _branchDepartmentService;
        private readonly IDepartmentServices _departmentService;
        private readonly IBranchEmployeeStatusServices _branchEmployeeStatusServices;
        private readonly IEmployeeStatusService _employeeStatusService;
        private readonly IBranchEmployeeTypeServices _branchEmployeeTypeServices;
        private readonly IEmployeeTypeServices _employeeTypeServices;
        private readonly IBranchyEmployeeSubTypeServices _branchyEmployeeSubTypeServices;
        private readonly IEmployeeSubTypeServices _employeeSubTypeServices;
        private readonly IBranchBankService _branchBankService;
        private readonly IBankService _bankService;
        private readonly IBranchDepartmentTypeService _branchDepartmentTypeService;
        private readonly IDepartmentTypeServices _departmentTypeServices;
        private readonly IBranchDesignationService _branchDesignationService;
        private readonly IDesignationService _designationService;
        private readonly IBranchGradeService _branchGradeService;
        private readonly IGradeService _gradeService;
        private readonly IBranchAccountTypeService _branchAccountTypeService;
        private readonly IAccountTypeService _accountTypeService;

        public CompanySettingsController(ICurrencyService currencyService,
            IBranchCurrencyCodeServices branchCurrencyCodeServices,
            IBranchCityServices branchCityServices, ICityService cityService,
            IBranchStateService branchStateService, IStateService stateService,
            IBranchCountryService branchCountryService, ICountryService countryService,
            IBranchDepartmentServices branchDepartmentServices, IDepartmentServices departmentServices,
            IBranchEmployeeStatusServices branchEmployeeStatusServices, IEmployeeStatusService employeeStatusService,
            IBranchEmployeeTypeServices branchEmployeeTypeServices, IEmployeeTypeServices employeeTypeServices,
            IBranchyEmployeeSubTypeServices branchyEmployeeSubTypeServices, IEmployeeSubTypeServices employeeSubTypeServices,
            IBranchBankService branchBankService, IBankService bankService,
            IBranchDepartmentTypeService branchDepartmentTypeService, IDepartmentTypeServices departmentTypeServices,
            IBranchDesignationService branchDesignationService, IDesignationService designationService,
            IBranchGradeService branchGradeService, IGradeService gradeService,
            IBranchAccountTypeService branchAccountTypeService, IAccountTypeService accountTypeService)
        {
            _currencyService = currencyService;
            _branchCurrencyCodeServices = branchCurrencyCodeServices;
            _branchCityService = branchCityServices;
            _cityService = cityService;
            _branchStateService = branchStateService;
            _stateService = stateService; ;
            _branchCountryService = branchCountryService;
            _countryService = countryService;
            _branchDepartmentService = branchDepartmentServices;
            _departmentService = departmentServices;
            _branchEmployeeStatusServices = branchEmployeeStatusServices;
            _employeeStatusService = employeeStatusService;
            _branchEmployeeTypeServices = branchEmployeeTypeServices;
            _employeeTypeServices = employeeTypeServices;
            _branchyEmployeeSubTypeServices = branchyEmployeeSubTypeServices;
            _employeeSubTypeServices = employeeSubTypeServices;
            _branchBankService = branchBankService;
            _bankService = bankService;
            _branchDepartmentTypeService = branchDepartmentTypeService;
            _departmentTypeServices = departmentTypeServices;
            _branchDesignationService = branchDesignationService;
            _designationService = designationService;
            _branchGradeService = branchGradeService;
            _gradeService = gradeService;
            _branchAccountTypeService = branchAccountTypeService;
            _accountTypeService = accountTypeService;
        }

        [Route("company-settings")]
        public IActionResult MasterSettings()
        {
            return View();
        }

        [Route("company-settings"), HttpPost]
        public async Task<IActionResult> MasterSettings(CompanySettingViewModel model, int[] DestinationItems)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    switch (model.MasterType)
                    {
                        case MasterType.AccountType:
                            var addedAccountType = _branchAccountTypeService.GetAll().Where(v => v.BranchId == model.BranchId).ToList();
                            foreach (var item in addedAccountType)
                            {
                                await _branchAccountTypeService.DeleteHardAsync(item.BranchId, item.AccountTypeId);
                            }
                            foreach (var item in DestinationItems)
                            {
                                await _branchAccountTypeService.AddAsync(
                                new BranchAccountType
                                {
                                    BranchId = model.BranchId,
                                    AccountTypeId = item
                                });
                            }
                            break;
                        case MasterType.Bank:
                            var addedBank = _branchBankService.GetAll().Where(v => v.BranchId == model.BranchId).ToList();
                            foreach (var item in addedBank)
                            {
                                await _branchBankService.DeleteHardAsync(item.BranchId, item.BankId);
                            }
                            foreach (var item in DestinationItems)
                            {
                                await _branchBankService.AddAsync(
                                new BranchBank
                                {
                                    BranchId = model.BranchId,
                                    BankId = item
                                });
                            }
                            break;
                        case MasterType.Country:
                            var addedCountry = _branchCountryService.GetAll().Where(v => v.BranchId == model.BranchId).ToList();
                            foreach (var item in addedCountry)
                            {
                                await _branchCountryService.DeleteHardAsync(item.BranchId, item.CountryId);
                            }
                            foreach (var item in DestinationItems)
                            {
                                await _branchCountryService.AddAsync(
                                new BranchCountry
                                {
                                    BranchId = model.BranchId,
                                    CountryId = item
                                });
                            }
                            break;
                        case MasterType.Currency:
                            var addedCurrencyCode = _branchCurrencyCodeServices.GetAll().Where(v => v.BranchId == model.BranchId).ToList();
                            foreach (var item in addedCurrencyCode)
                            {
                                await _branchCurrencyCodeServices.DeleteHardAsync(item.BranchId, item.CurrencyId);
                            }
                            foreach (var item in DestinationItems)
                            {
                                await _branchCurrencyCodeServices.AddAsync(
                                new BranchCurrencyCode
                                {
                                    BranchId = model.BranchId,
                                    CurrencyId = item
                                });
                            }
                            break;
                        case MasterType.Department:
                            var addedDepartment = _branchDepartmentService.GetAll().Where(v => v.BranchId == model.BranchId).ToList();
                            foreach (var item in addedDepartment)
                            {
                                await _branchDepartmentService.DeleteHardAsync(item.BranchId, item.DepartmentId);
                            }
                            foreach (var item in DestinationItems)
                            {
                                await _branchDepartmentService.AddAsync(
                                new BranchDepartment
                                {
                                    BranchId = model.BranchId,
                                    DepartmentId = item
                                });
                            }
                            break;
                        case MasterType.DepartmentType:
                            var addedDepartmentType = _branchDepartmentTypeService.GetAll().Where(v => v.BranchId == model.BranchId).ToList();
                            foreach (var item in addedDepartmentType)
                            {
                                await _branchDepartmentTypeService.DeleteHardAsync(item.BranchId, item.DepartmentTypeId);
                            }
                            foreach (var item in DestinationItems)
                            {
                                await _branchDepartmentTypeService.AddAsync(
                                new BranchDepartmentType
                                {
                                    BranchId = model.BranchId,
                                    DepartmentTypeId = item
                                });
                            }
                            break;
                        case MasterType.Designation:
                            var addedDesignation = _branchDesignationService.GetAll().Where(v => v.BranchId == model.BranchId).ToList();
                            foreach (var item in addedDesignation)
                            {
                                await _branchDesignationService.DeleteHardAsync(item.BranchId, item.DesignationId);
                            }
                            foreach (var item in DestinationItems)
                            {
                                await _branchDesignationService.AddAsync(
                                new BranchDesignation
                                {
                                    BranchId = model.BranchId,
                                    DesignationId = item
                                });
                            }
                            break;
                        case MasterType.EmployeeStatus:
                            var addedEmployeeStatus = _branchEmployeeStatusServices.GetAll().Where(v => v.BranchId == model.BranchId).ToList();
                            foreach (var item in addedEmployeeStatus)
                            {
                                await _branchEmployeeStatusServices.DeleteHardAsync(item.BranchId, item.EmployeeStatusId);
                            }
                            foreach (var item in DestinationItems)
                            {
                                await _branchEmployeeStatusServices.AddAsync(
                                new BranchEmployeeStatus
                                {
                                    BranchId = model.BranchId,
                                    EmployeeStatusId = item
                                });
                            }
                            break;
                        case MasterType.EmployeeSubType:
                            var addedEmployeeSubType = _branchyEmployeeSubTypeServices.GetAll().Where(v => v.BranchId == model.BranchId).ToList();
                            foreach (var item in addedEmployeeSubType)
                            {
                                await _branchyEmployeeSubTypeServices.DeleteHardAsync(item.BranchId, item.EmployeeSubTypeId);
                            }
                            foreach (var item in DestinationItems)
                            {
                                await _branchyEmployeeSubTypeServices.AddAsync(
                                new BranchEmployeeSubType
                                {
                                    BranchId = model.BranchId,
                                    EmployeeSubTypeId = item
                                });
                            }
                            break;
                        case MasterType.EmployeeType:
                            var addedEmployeeType = _branchEmployeeTypeServices.GetAll().Where(v => v.BranchId == model.BranchId).ToList();
                            foreach (var item in addedEmployeeType)
                            {
                                await _branchEmployeeTypeServices.DeleteHardAsync(item.BranchId, item.EmployeeTypeId);
                            }
                            foreach (var item in DestinationItems)
                            {
                                await _branchEmployeeTypeServices.AddAsync(
                                new BranchEmployeeType
                                {
                                    BranchId = model.BranchId,
                                    EmployeeTypeId = item
                                });
                            }
                            break;
                        case MasterType.Grade:
                            var addedGrade = _branchGradeService.GetAll().Where(v => v.BranchId == model.BranchId).ToList();
                            foreach (var item in addedGrade)
                            {
                                await _branchGradeService.DeleteHardAsync(item.BranchId, item.GradeId);
                            }
                            foreach (var item in DestinationItems)
                            {
                                await _branchGradeService.AddAsync(
                                new BranchGrade
                                {
                                    BranchId = model.BranchId,
                                    GradeId = item
                                });
                            }
                            break;
                        case MasterType.State:
                            var addedState = _branchStateService.GetAll().Where(v => v.BranchId == model.BranchId).ToList();
                            foreach (var item in addedState)
                            {
                                await _branchStateService.DeleteHardAsync(item.BranchId, item.StateId);
                            }
                            foreach (var item in DestinationItems)
                            {
                                await _branchStateService.AddAsync(
                                new BranchState
                                {
                                    BranchId = model.BranchId,
                                    StateId = item
                                });
                            }
                            break;
                        case MasterType.City:
                            var addedCity = _branchCityService.GetAll().Where(v => v.BranchId == model.BranchId).ToList();
                            foreach (var item in addedCity)
                            {
                                await _branchCityService.DeleteHardAsync(item.BranchId, item.CityId);
                            }
                            foreach (var item in DestinationItems)
                            {
                                await _branchCityService.AddAsync(
                                new BranchCity
                                {
                                    BranchId = model.BranchId,
                                    CityId = item
                                });
                            }
                            break;
                        default:
                            break;
                    }
                    TempData["Message"] = "Company Setting Updated Successfully!";
                    TempData["Success"] = true;
                    ModelState.Clear();
                    return View();
                }
                catch (Exception ex)
                {
                    TempData["Message"] = ex.Message;
                    TempData["Success"] = false;
                    return View(model);
                }
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult GetMasterData([FromQuery] MasterType masterType, int branchId)
        {
            List<SelectListItem> sourceItems = new List<SelectListItem>();
            List<SelectListItem> destinationItems = new List<SelectListItem>();

            switch (masterType)
            {
                case MasterType.AccountType:
                    destinationItems = _branchAccountTypeService.GetAll().Where(b => b.BranchId == branchId).Include(v => v.AccountType)
                       .Select(v => new SelectListItem { Text = v.AccountType.Name, Value = v.AccountTypeId.ToString() }).ToList();
                    sourceItems = _accountTypeService.GetAll().Select(v => new SelectListItem { Text = v.Name, Value = v.Id.ToString() }).ToList()
                        .Where(v => !destinationItems.Select(b => b.Value).Contains(v.Value)).ToList();
                    break;
                case MasterType.City:
                    destinationItems = _branchCityService.GetAll().Where(b => b.BranchId == branchId).Include(v => v.City)
                       .Select(v => new SelectListItem { Text = v.City.Name, Value = v.CityId.ToString() }).ToList();
                    sourceItems = _cityService.GetAll().Select(v => new SelectListItem { Text = v.Name, Value = v.Id.ToString() }).ToList()
                        .Where(v => !destinationItems.Select(b => b.Value).Contains(v.Value)).ToList();
                    break;
                case MasterType.Bank:
                    destinationItems = _branchBankService.GetAll().Where(b => b.BranchId == branchId).Include(v => v.Bank)
                      .Select(v => new SelectListItem { Text = v.Bank.Name, Value = v.BankId.ToString() }).ToList();
                    sourceItems = _bankService.GetAll().Select(v => new SelectListItem { Text = v.Name, Value = v.Id.ToString() }).ToList()
                        .Where(v => !destinationItems.Select(b => b.Value).Contains(v.Value)).ToList();
                    break;
                case MasterType.Country:
                    destinationItems = _branchCountryService.GetAll().Where(b => b.BranchId == branchId).Include(v => v.Country)
                      .Select(v => new SelectListItem { Text = v.Country.Name, Value = v.CountryId.ToString() }).ToList();
                    sourceItems = _countryService.GetAll().Select(v => new SelectListItem { Text = v.Name, Value = v.Id.ToString() }).ToList()
                        .Where(v => !destinationItems.Select(b => b.Value).Contains(v.Value)).ToList();
                    break;
                case MasterType.Currency:
                    destinationItems = _branchCurrencyCodeServices.GetAll().Where(b => b.BranchId == branchId).Include(v => v.Currency)
                        .Select(v => new SelectListItem { Text = v.Currency.Name, Value = v.CurrencyId.ToString() }).ToList();
                    sourceItems = _currencyService.GetAll().Select(v => new SelectListItem { Text = v.Name, Value = v.Id.ToString() }).ToList()
                        .Where(v => !destinationItems.Select(b => b.Value).Contains(v.Value)).ToList();
                    break;
                case MasterType.Department:
                    destinationItems = _branchDepartmentService.GetAll().Where(b => b.BranchId == branchId).Include(v => v.Department)
                     .Select(v => new SelectListItem { Text = v.Department.Name, Value = v.DepartmentId.ToString() }).ToList();
                    sourceItems = _departmentService.GetAll().Select(v => new SelectListItem { Text = v.Name, Value = v.Id.ToString() }).ToList()
                        .Where(v => !destinationItems.Select(b => b.Value).Contains(v.Value)).ToList();
                    break;
                case MasterType.DepartmentType:
                    destinationItems = _branchDepartmentTypeService.GetAll().Where(b => b.BranchId == branchId).Include(v => v.DepartmentType)
                      .Select(v => new SelectListItem { Text = v.DepartmentType.Name, Value = v.DepartmentTypeId.ToString() }).ToList();
                    sourceItems = _departmentTypeServices.GetAll().Select(v => new SelectListItem { Text = v.Name, Value = v.Id.ToString() }).ToList()
                        .Where(v => !destinationItems.Select(b => b.Value).Contains(v.Value)).ToList();
                    break;
                case MasterType.Designation:
                    destinationItems = _branchDesignationService.GetAll().Where(b => b.BranchId == branchId).Include(v => v.Designation)
                      .Select(v => new SelectListItem { Text = v.Designation.Name, Value = v.DesignationId.ToString() }).ToList();
                    sourceItems = _designationService.GetAll().Select(v => new SelectListItem { Text = v.Name, Value = v.Id.ToString() }).ToList()
                        .Where(v => !destinationItems.Select(b => b.Value).Contains(v.Value)).ToList();
                    break;
                case MasterType.EmployeeStatus:
                    destinationItems = _branchEmployeeStatusServices.GetAll().Where(b => b.BranchId == branchId).Include(v => v.EmployeeStatus)
                      .Select(v => new SelectListItem { Text = v.EmployeeStatus.Name, Value = v.EmployeeStatusId.ToString() }).ToList();
                    sourceItems = _employeeStatusService.GetAll().Select(v => new SelectListItem { Text = v.Name, Value = v.Id.ToString() }).ToList()
                        .Where(v => !destinationItems.Select(b => b.Value).Contains(v.Value)).ToList();
                    break;
                case MasterType.EmployeeSubType:
                    destinationItems = _branchyEmployeeSubTypeServices.GetAll().Where(b => b.BranchId == branchId).Include(v => v.EmployeeSubType)
                    .Select(v => new SelectListItem { Text = v.EmployeeSubType.Name, Value = v.EmployeeSubTypeId.ToString() }).ToList();
                    sourceItems = _employeeSubTypeServices.GetAll().Select(v => new SelectListItem { Text = v.Name, Value = v.Id.ToString() }).ToList()
                        .Where(v => !destinationItems.Select(b => b.Value).Contains(v.Value)).ToList();
                    break;
                case MasterType.EmployeeType:
                    destinationItems = _branchEmployeeTypeServices.GetAll().Where(b => b.BranchId == branchId).Include(v => v.EmployeeType)
                     .Select(v => new SelectListItem { Text = v.EmployeeType.Name, Value = v.EmployeeTypeId.ToString() }).ToList();
                    sourceItems = _employeeTypeServices.GetAll().Select(v => new SelectListItem { Text = v.Name, Value = v.Id.ToString() }).ToList()
                        .Where(v => !destinationItems.Select(b => b.Value).Contains(v.Value)).ToList();
                    break;
                case MasterType.Grade:
                    destinationItems = _branchGradeService.GetAll().Where(b => b.BranchId == branchId).Include(v => v.Grade)
                    .Select(v => new SelectListItem { Text = v.Grade.Name, Value = v.GradeId.ToString() }).ToList();
                    sourceItems = _gradeService.GetAll().Select(v => new SelectListItem { Text = v.Name, Value = v.Id.ToString() }).ToList()
                        .Where(v => !destinationItems.Select(b => b.Value).Contains(v.Value)).ToList();
                    break;
                case MasterType.State:
                    destinationItems = _branchStateService.GetAll().Where(b => b.BranchId == branchId).Include(v => v.State)
                       .Select(v => new SelectListItem { Text = v.State.Name, Value = v.StateId.ToString() }).ToList();
                    sourceItems = _stateService.GetAll().Select(v => new SelectListItem { Text = v.Name, Value = v.Id.ToString() }).ToList()
                        .Where(v => !destinationItems.Select(b => b.Value).Contains(v.Value)).ToList();
                    break;
                default:
                    break;
            }
            return Json(new { Source = sourceItems, Destination = destinationItems });
        }
    }
}
