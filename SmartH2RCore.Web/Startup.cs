using AutoMapper;

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using Serilog;
using Serilog.Events;

using SmartH2RCore.Core.EFContext;
using SmartH2RCore.Models.Common;
using SmartH2RCore.Models.Configuration;
using SmartH2RCore.Models.Identity;
using SmartH2RCore.Web.Extensions;

using System;

namespace SmartH2RCore.Web
{
    public class Startup
    {
        private IConfiguration Configuration { get; }
        private IWebHostEnvironment Environment { get; }

        public Startup(IWebHostEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", false, false)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", true)
                .AddEnvironmentVariables();

            Configuration = builder.Build();
            Environment = env;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<ConnectionSettings>(Configuration.GetSection("ConnectionStrings"));
            services.AddDbContexts(Configuration, Environment);
            services.AddControllersWithViews().AddRazorRuntimeCompilation();
            services.AddInjections();
            services.AddIdentity<User, Role>().AddEntityFrameworkStores<DatabaseContext>().AddDefaultTokenProviders();
            services.AddControllersWithViews()
            .AddNewtonsoftJson(options =>
            {
                options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
                options.UseMemberCasing();
            });

            services.AddSession();
            services.AddAutoMapper(typeof(Startup));
            services.AddRouting(options => options.LowercaseUrls = true);


            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingProfile());
            });

            IMapper mapper = mapperConfig.CreateMapper();

            services.AddSingleton(mapper);

            services.ConfigureApplicationCookie(options =>
            {
                options.Cookie.HttpOnly = true;
                options.ExpireTimeSpan = TimeSpan.FromMinutes(5);
                options.LoginPath = "/Account/Login";
                options.AccessDeniedPath = "/Account/Login";
                options.SlidingExpiration = true;
            });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseSession();
            app.UseSerilogRequestLogging(options =>
            {
                options.MessageTemplate = "Handled {RequestPath}";
                options.GetLevel = (httpContext, elapsed, ex) => LogEventLevel.Debug;
                options.EnrichDiagnosticContext = (diagnosticContext, httpContext) =>
                {
                    diagnosticContext.Set("RequestHost", httpContext.Request.Host.Value);
                    diagnosticContext.Set("RequestScheme", httpContext.Request.Scheme);
                };
            });
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();
            RegisterExtensions.Initialize(app.ApplicationServices, Environment);
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapDefaultControllerRoute();
                endpoints.MapControllerRoute("default", "{controller=Account}/{action=Login}/{id?}");
            });
        }
    }
}
