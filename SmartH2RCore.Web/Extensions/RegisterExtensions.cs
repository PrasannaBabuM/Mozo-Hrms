using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using Newtonsoft.Json;

using SmartH2RCore.Core.EFContext;
using SmartH2RCore.Core.Factory;
using SmartH2RCore.Core.Repositories.Base;
using SmartH2RCore.Core.Repositories.Interfaces;
using SmartH2RCore.Core.Uow;
using SmartH2RCore.Models.Common;
using SmartH2RCore.Models.DTO.Master;
using SmartH2RCore.Models.Identity;
using SmartH2RCore.Services.Base;
using SmartH2RCore.Services.Interface;
using SmartH2RCore.Services.Interface.Employee;
using SmartH2RCore.Services.Service;
using SmartH2RCore.Services.Service.Employee;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace SmartH2RCore.Web.Extensions
{
    internal static class RegisterExtensions
    {
        internal static void AddDbContexts(this IServiceCollection services, IConfiguration configuration, IWebHostEnvironment environment)
        {
            var contextConnectionString = configuration.GetConnectionString("DefaultConnection");
            services.AddDbContextPool<DatabaseContext>(x => x.UseSqlServer(contextConnectionString, o =>
                {
                    o.EnableRetryOnFailure(3);
                })
                .EnableSensitiveDataLogging(environment.IsDevelopment())
                .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking));
        }

        internal static void AddInjections(this IServiceCollection services)
        {
            services.AddScoped<IDatabaseContext, DatabaseContext>();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddTransient<IContextFactory, ContextFactory>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddTransient(typeof(IBaseService<object>), typeof(BaseService<object>));

            services.AddTransient(typeof(IAccountTypeService), typeof(AccountTypeService));
            services.AddTransient(typeof(ICityService), typeof(CityService));
            services.AddTransient(typeof(IBranchCityServices), typeof(BranchCityServices));
            services.AddTransient(typeof(IBranchCountryService), typeof(BranchCountryService));
            services.AddTransient(typeof(ICurrencyService), typeof(CurrencyService));
            services.AddTransient(typeof(ICountryService), typeof(CountryService));
            services.AddTransient(typeof(IStateService), typeof(StateService));
            services.AddTransient(typeof(IBranchCurrencyCodeServices), typeof(BranchCurrencyCodeServices));
            services.AddTransient(typeof(IBranchDepartmentServices), typeof(BranchDepartmentServices));
            services.AddTransient(typeof(IBranchEmployeeStatusServices), typeof(BranchEmployeeStatusServices));
            services.AddTransient(typeof(IBranchyEmployeeSubTypeServices), typeof(BranchEmployeeSubTypeServices));
            services.AddTransient(typeof(IBranchEmployeeTypeServices), typeof(BranchEmployeeTypeServices));
            services.AddTransient(typeof(IBranchStateService), typeof(BranchStateService));
            services.AddTransient(typeof(IBranchGradeService), typeof(BranchGradeService));
            services.AddTransient(typeof(IBranchDesignationService), typeof(BranchDesignationService));
            services.AddTransient(typeof(IBranchDepartmentTypeService), typeof(BranchDepartmentTypeService));
            services.AddTransient(typeof(IBranchBankService), typeof(BranchBankService));
            services.AddTransient(typeof(IBranchAccountTypeService), typeof(BranchAccountTypeService));
            services.AddTransient(typeof(ICompanyServices), typeof(CompanyServices));
            services.AddTransient(typeof(IDepartmentServices), typeof(DepartmentServices));
            services.AddTransient(typeof(IEmployeeStatusService), typeof(EmployeeStatusService));
            services.AddTransient(typeof(IEmployeeSubTypeServices), typeof(EmployeeSubTypeServices));
            services.AddTransient(typeof(IEmployeeTypeServices), typeof(EmployeeTypeServices));
            services.AddTransient(typeof(IGradeService), typeof(GradeService));
            services.AddTransient(typeof(IBankService), typeof(BankService));
            services.AddTransient(typeof(IRoleService), typeof(RoleService));
            services.AddTransient(typeof(IDesignationService), typeof(DesignationService));
            services.AddTransient(typeof(IDepartmentTypeServices), typeof(DepartmentTypeServices));
            services.AddTransient(typeof(IBranchService), typeof(BranchService));
            services.AddTransient(typeof(IUserService), typeof(UserService));
            services.AddTransient(typeof(IEmailSettingService), typeof(EmailSettingService));
            services.AddTransient(typeof(IModuleMasterService), typeof(ModuleMasterService));
            services.AddTransient(typeof(IScreenMasterService), typeof(ScreenMasterService));

            // Employee Services
            services.AddTransient(typeof(IApproverInformationService), typeof(ApproverInformationService));
            services.AddTransient(typeof(IChildrenDetailsService), typeof(ChildrenDetailsService));
            services.AddTransient(typeof(IContactListService), typeof(ContactListService));
            services.AddTransient(typeof(IDocumentDetailsService), typeof(DocumentDetailsService));
            services.AddTransient(typeof(IEducationalQualificationService), typeof(EducationalQualificationService));
            services.AddTransient(typeof(IEmergencyContactDetailsService), typeof(EmergencyContactDetailsService));
            services.AddTransient(typeof(IExperienceDetailsService), typeof(ExperienceDetailsService));
            services.AddTransient(typeof(IJobDetailsService), typeof(JobDetailsService));
            services.AddTransient(typeof(IPersonalDetailsService), typeof(PersonalDetailsService));
            services.AddTransient(typeof(IProfessionalQualificationService), typeof(ProfessionalQualificationService));
            services.AddTransient(typeof(ITrainingDetailsService), typeof(TrainingDetailsService));


        }

        internal static void AddIdentity(this IServiceCollection services)
        {
            services.AddIdentity<User, IdentityRole>()
                .AddEntityFrameworkStores<DatabaseContext>()
                .AddDefaultTokenProviders();

            services.Configure<IdentityOptions>(options =>
            {
                options.Password.RequireDigit = false;
                options.Password.RequiredLength = 1;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;
                options.Password.RequireLowercase = false;
                options.Password.RequiredUniqueChars = 1;
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(30);
                options.Lockout.MaxFailedAccessAttempts = 5;
                options.Lockout.AllowedForNewUsers = true;
                options.User.RequireUniqueEmail = false;
            });
        }

        public async static void Initialize(IServiceProvider serviceProvider, IWebHostEnvironment environment)
        {
            using var scope = serviceProvider.CreateScope();

            var context = scope.ServiceProvider.GetRequiredService<DatabaseContext>();
            await context.Database.MigrateAsync();

            #region Seed Default User and Roles
            string[] roles = new string[] { "USER", "SUPER ADMIN", "MANAGING DIRECTOR", "ADMIN LINE", "HR-TALENT ACQUISITION", "LINE MANAGER" };

            foreach (string role in roles)
            {
                RoleManager<Role> _roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<Role>>();

                if (!context.Roles.Any(r => r.Name == role))
                {
                    await _roleManager.CreateAsync(new Role { Name = role, IsActive = true, CreatedDate = DateTime.UtcNow });
                }
            }

            //var user = new User()
            //{
            //    UserCode = "EIN1065",
            //    UserNo = "EIN1065",
            //    Email = "admin@admin.com",
            //    NormalizedEmail = "ADMIN@ADMIN.COM",
            //    UserName = "EIN1065",
            //    NormalizedUserName = "EIN1065",
            //    PhoneNumber = "+111111111111",
            //    EmailConfirmed = true,
            //    PhoneNumberConfirmed = true,
            //    SecurityStamp = Guid.NewGuid().ToString("D")

            //};

            //if (!context.Users.Any(u => u.UserName == u.UserName))
            //{
            //    UserManager<User> _userManager = scope.ServiceProvider.GetRequiredService<UserManager<User>>();
            //    await _userManager.CreateAsync(user, "Admin#123");
            //    await AssignRoles(scope, user, roles);
            //    user.EmailConfirmed = true;
            //    user.LockoutEnabled = false;
            //    await context.SaveChangesAsync();
            //}

            #endregion

            #region Seed Currency 
            if (context.Currency.Count() <= 0)
            {
                JsonSerializer serializer = new JsonSerializer();
                using StreamReader sr = new StreamReader(Path.Combine(environment.ContentRootPath, "wwwroot", "JsonFile/currency.json"));
                List<Currency> currencys = JsonConvert.DeserializeObject<List<Currency>>(sr.ReadToEnd());
                context.Currency.AddRange(currencys);
                await context.SaveChangesAsync();
            }
            #endregion

            #region Seed Country State City 
            if (context.Country.Count() <= 0)
            {
                try
                {
                    JsonSerializer serializer = new JsonSerializer();
                    using StreamReader sr = new StreamReader(Path.Combine(environment.ContentRootPath, "wwwroot", "JsonFile/countries_states_cities.json"));
                    List<CountryDTO> countries = JsonConvert.DeserializeObject<List<CountryDTO>>(sr.ReadToEnd());
                    foreach (var item in countries.Where(v => v.Name == "India"))
                    {
                        var currency = await context.Currency.FirstOrDefaultAsync(v => v.Code == item.CurrencyCode);

                        var country = new Country
                        {
                            Capital = item.Capital,
                            Name = item.Name,
                            IsActive = true,
                            CurrencyId = currency?.Id,
                            ISO31663CCodes = item.ISO31663CCodes,
                            CreatedDate = DateTime.Now
                        };

                        country.States = new List<State>();

                        foreach (var stateItem in item.States)
                        {
                            var stateEntity = new State
                            {
                                Name = stateItem.Name,
                                IsActive = true,
                                CreatedDate = DateTime.Now
                            };

                            stateEntity.Cities = new List<City>();

                            foreach (var cityItem in stateItem.Cities)
                            {
                                stateEntity.Cities.Add(new City
                                {
                                    Name = cityItem.Name,
                                    IsActive = true,
                                    CreatedDate = DateTime.Now
                                });
                            }

                            country.States.Add(stateEntity);
                        }

                        context.Country.Add(country);
                        await context.SaveChangesAsync();
                    }
                }
                catch (Exception)
                {

                }
            }
            #endregion

            #region Seed Grade 
            if (context.Grade.Count() <= 0)
            {
                for (int i = 1; i <= 10; i++)
                {
                    context.Grade.AddRange(new Grade { Name = $"E-{i}", Description = $"E-{i}", IsActive = true, CreatedDate = DateTime.Now });
                }
                await context.SaveChangesAsync();
            }
            #endregion

            #region Seed Employee Type 
            if (context.EmployeeType.Count() <= 0)
            {
                {
                    context.EmployeeType.AddRange(new EmployeeType { Name = "Full Time", Code = $"FT", IsActive = true, CreatedDate = DateTime.Now });
                }

                {
                    context.EmployeeType.AddRange(new EmployeeType { Name = "Contractual", Code = $"CT", IsActive = true, CreatedDate = DateTime.Now });
                }

                await context.SaveChangesAsync();
            }
            #endregion

            #region Seed Employee Status 
            if (context.EmployeeStatus.Count() <= 0)
            {
                {
                    context.EmployeeStatus.AddRange(new EmployeeStatus { Name = "Probation", Description = "Probation", IsActive = true, CreatedDate = DateTime.Now });
                }

                {
                    context.EmployeeStatus.AddRange(new EmployeeStatus { Name = "Resigned", Description = $"Resigned", IsActive = true, CreatedDate = DateTime.Now });
                }

                {
                    context.EmployeeStatus.AddRange(new EmployeeStatus { Name = "Confirmed", Description = $"Confirmed", IsActive = true, CreatedDate = DateTime.Now });
                }

                {
                    context.EmployeeStatus.AddRange(new EmployeeStatus { Name = "Internship", Description = $"Internship", IsActive = true, CreatedDate = DateTime.Now });
                }

                await context.SaveChangesAsync();
            }
            #endregion

            #region Seed Desination 
            if (context.Designation.Count() <= 0)
            {
                List<string> designation = new List<string>()
                {
                    "H.R. manager",
                    "PHP developer",
                    "PHP developer",
                    "Project Manager",
                    "General Manager",
                    "Business Development Manager",
                    "Internet Marketing Head",
                    "Content Writter",
                    "System Administrator",
                    "CEO/MD"
                };

                foreach (var item in designation)
                {
                    {
                        context.Designation.Add(new Designation
                        {
                            IsActive = true,
                            Name = item,
                            Description = item,
                            CreatedDate = DateTime.Now
                        });
                    }
                }
                await context.SaveChangesAsync();
            }
            #endregion

            #region Seed Department Type 
            if (context.Department.Count() <= 0)
            {
                List<Tuple<string, string>> tuples = new List<Tuple<string, string>>()
                {
                    new Tuple<string, string>("Marketing Department","MD"),
                    new Tuple<string, string>("Operations Department","OD"),
                    new Tuple<string, string>("Finance Department","FD"),
                    new Tuple<string, string>("Sales Department","SD"),
                    new Tuple<string, string>("Human Resource Department","HRD")
                };

                foreach (var item in tuples)
                {
                    {
                        context.DepartmentType.Add(new DepartmentType
                        {
                            IsActive = true,
                            Name = item.Item1,
                            Code = item.Item2,
                            Description = item.Item1,
                            CreatedDate = DateTime.Now
                        });
                    }
                }
                await context.SaveChangesAsync();
            }
            #endregion

            #region Seed Module Master Data 
            if (context.ModuleMaster.Count() <= 0)
            {
                List<Tuple<string, string>> tuples = new List<Tuple<string, string>>()
                {
                    new Tuple<string, string>("Masters","Masters"),
                    new Tuple<string, string>("Settings","Settings"),
                    new Tuple<string, string>("Employee","Employee"),
                    new Tuple<string, string>("Leave","Leave"),
                    new Tuple<string, string>("Attendance","Attendance"),
                    new Tuple<string, string>("Payroll","Payroll")
                };

                foreach (var item in tuples)
                {
                    {
                        context.ModuleMaster.Add(new ModuleMaster
                        {
                            IsActive = true,
                            Name = item.Item1,
                            Description = item.Item2,
                            CreatedDate = DateTime.Now
                        });
                    }
                }
                await context.SaveChangesAsync();
            }
            #endregion

        }

        public static async Task<IdentityResult> AssignRoles(IServiceScope services, User user, string[] roles)
        {
            UserManager<User> _userManager = services.ServiceProvider.GetRequiredService<UserManager<User>>();
            var result = await _userManager.AddToRolesAsync(user, roles);
            return result;
        }
    }
}
