#pragma checksum "F:\HRMS_netcore\SmartH2R\src\SmartH2RCore.Web\Views\EmployeeStatus\Add.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "25be060796ded16875d69c8be55028e74341f92d040bd22cec3a498491cf6497"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_EmployeeStatus_Add), @"mvc.1.0.view", @"/Views/EmployeeStatus/Add.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "F:\HRMS_netcore\SmartH2R\src\SmartH2RCore.Web\Views\_ViewImports.cshtml"
using SmartH2RCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\HRMS_netcore\SmartH2R\src\SmartH2RCore.Web\Views\_ViewImports.cshtml"
using SmartH2RCore.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\HRMS_netcore\SmartH2R\src\SmartH2RCore.Web\Views\_ViewImports.cshtml"
using SmartH2RCore.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\HRMS_netcore\SmartH2R\src\SmartH2RCore.Web\Views\_ViewImports.cshtml"
using SmartH2RCore.Models.DTO;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"25be060796ded16875d69c8be55028e74341f92d040bd22cec3a498491cf6497", @"/Views/EmployeeStatus/Add.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"40e21cc8aa428901517b537ec0aa48eab916f283bf3d7731bc7b9bafe3204a71", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_EmployeeStatus_Add : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SmartH2RCore.Models.DTO.Master.EmployeeStatusDTO>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "MasterDashboard", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "EmployeeStatus", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "F:\HRMS_netcore\SmartH2R\src\SmartH2RCore.Web\Views\EmployeeStatus\Add.cshtml"
  
    Layout = "~/Views/Shared/_LayoutMaster.cshtml";
    ViewData["Title"] = "Employee Status Master";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""content container-fluid"">
    <!-- Page Header -->
    <div class=""page-header"">
        <div class=""row align-items-center"">
            <div class=""col"">
                <h3 class=""page-title"">Employee Status</h3>
                <ul class=""breadcrumb"">
                    <li class=""breadcrumb-item"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "25be060796ded16875d69c8be55028e74341f92d040bd22cec3a498491cf64975197", async() => {
                WriteLiteral("Dashboard");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n                    <li class=\"breadcrumb-item\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "25be060796ded16875d69c8be55028e74341f92d040bd22cec3a498491cf64976640", async() => {
                WriteLiteral("Employee Status");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n                    <li class=\"breadcrumb-item active\">");
#nullable restore
#line 16 "F:\HRMS_netcore\SmartH2R\src\SmartH2RCore.Web\Views\EmployeeStatus\Add.cshtml"
                                                   Write(Model==null || Model.Id<=0? "Add":"Edit");

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                </ul>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 21 "F:\HRMS_netcore\SmartH2R\src\SmartH2RCore.Web\Views\EmployeeStatus\Add.cshtml"
     using (Html.BeginForm())
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "F:\HRMS_netcore\SmartH2R\src\SmartH2RCore.Web\Views\EmployeeStatus\Add.cshtml"
   Write(Html.ValidationSummary(true));

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "F:\HRMS_netcore\SmartH2R\src\SmartH2RCore.Web\Views\EmployeeStatus\Add.cshtml"
                                     ;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""row"">
            <div class=""col-md-12"">
                <div class=""card leave-box"" id=""leave_annual"">
                    <div class=""card-body"">
                        <div class=""h3 card-title with-switch"">
                            ");
#nullable restore
#line 29 "F:\HRMS_netcore\SmartH2R\src\SmartH2RCore.Web\Views\EmployeeStatus\Add.cshtml"
                        Write(Model==null || Model.Id<=0? "Create":"Edit");

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </div>
                        <div class=""leave-item"">
                            <div class=""form-group"">
                                <label for=""Name"">Name<span class=""text-danger"">*</span></label>
                                ");
#nullable restore
#line 34 "F:\HRMS_netcore\SmartH2R\src\SmartH2RCore.Web\Views\EmployeeStatus\Add.cshtml"
                           Write(Html.TextBoxFor(model => model.Name, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                ");
#nullable restore
#line 35 "F:\HRMS_netcore\SmartH2R\src\SmartH2RCore.Web\Views\EmployeeStatus\Add.cshtml"
                           Write(Html.ValidationMessageFor(model => model.Name, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                            </div><br>\r\n                            <div class=\"form-group\">\r\n                                <label for=\"Description\">Description<span class=\"text-danger\"></span></label>\r\n                                ");
#nullable restore
#line 40 "F:\HRMS_netcore\SmartH2R\src\SmartH2RCore.Web\Views\EmployeeStatus\Add.cshtml"
                           Write(Html.TextBoxFor(model => model.Description, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                ");
#nullable restore
#line 41 "F:\HRMS_netcore\SmartH2R\src\SmartH2RCore.Web\Views\EmployeeStatus\Add.cshtml"
                           Write(Html.ValidationMessageFor(model => model.Description, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div><br>                           \r\n                            <div class=\"form-check\">\r\n                                ");
#nullable restore
#line 44 "F:\HRMS_netcore\SmartH2R\src\SmartH2RCore.Web\Views\EmployeeStatus\Add.cshtml"
                           Write(Html.CheckBoxFor(model => model.IsActive, new { @class = "form-check-input" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                <label for=\"IsActive\">Is Active<span class=\"text-danger\"></span></label>\r\n                                ");
#nullable restore
#line 46 "F:\HRMS_netcore\SmartH2R\src\SmartH2RCore.Web\Views\EmployeeStatus\Add.cshtml"
                           Write(Html.ValidationMessageFor(model => model.IsActive, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </div><br>
                        </div>
                    </div>

                </div>
                <div class=""submit-section "">
                    <button type=""submit"" class=""btn btn-primary submit-btn""><i class=""fa fa-save""></i>&nbsp;");
#nullable restore
#line 53 "F:\HRMS_netcore\SmartH2R\src\SmartH2RCore.Web\Views\EmployeeStatus\Add.cshtml"
                                                                                                         Write(Model==null || Model.Id<=0? "Add":"Update");

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n                    <button type=\"reset\" class=\"btn btn-primary submit-btn\"><i class=\"fa fa-recycle\"></i>&nbsp;Reset</button>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 58 "F:\HRMS_netcore\SmartH2R\src\SmartH2RCore.Web\Views\EmployeeStatus\Add.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SmartH2RCore.Models.DTO.Master.EmployeeStatusDTO> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
