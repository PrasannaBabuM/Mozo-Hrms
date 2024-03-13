using AutoMapper;

using SmartH2RCore.Models.Common;
using SmartH2RCore.Models.DTO;
using SmartH2RCore.Models.DTO.Employee;
using SmartH2RCore.Models.DTO.EmployeeDTO;
using SmartH2RCore.Models.DTO.Master;
using SmartH2RCore.Models.DTO.Settings;
using SmartH2RCore.Models.Employee;
using SmartH2RCore.Models.Identity;

namespace SmartH2RCore.Web.Extensions
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Currency, CurrencyDTO>().ReverseMap();
            CreateMap<AccountType, AccountTypeDTO>().ReverseMap();
            CreateMap<State, StateDTO>().ReverseMap();
            CreateMap<Country, CountryDTO>().ReverseMap();
            CreateMap<City, CityDTO>().ReverseMap();
            CreateMap<Grade, GradeDTO>().ReverseMap();
            CreateMap<Bank, BankDTO>().ReverseMap();
            CreateMap<Role, RoleDTO>().ReverseMap();
            CreateMap<EmployeeStatus, EmployeeStatusDTO>().ReverseMap();
            CreateMap<EmployeeType, EmployeeTypeDTO>().ReverseMap();
            CreateMap<EmployeeSubType, EmployeeSubTypeDTO>().ReverseMap();
            CreateMap<Designation, DesignationDTO>().ReverseMap();
            CreateMap<DepartmentType, DepartmentTypeDTO>().ReverseMap();
            CreateMap<Department, DepartmentDTO>().ReverseMap();
            CreateMap<Company, CompanyDTO>().ReverseMap();
            CreateMap<Branch, BranchDTO>().ForMember(destination => destination.CompanyName, opts => opts.MapFrom(source => source.Company.CompanyName));
            CreateMap<BranchDTO, Branch>();
            CreateMap<EmailSettingDTO, EmailSetting>().ReverseMap();
            CreateMap<ModuleMaster, ModuleMasterDTO>().ReverseMap();
            CreateMap<ScreenMaster, ScreenMasterDTO>().ReverseMap();
            CreateMap<JobDetails,JobDetailsDTO>().ReverseMap();
            CreateMap<SignupModel, RegistorDTO>().ReverseMap();
        }
    }
}
