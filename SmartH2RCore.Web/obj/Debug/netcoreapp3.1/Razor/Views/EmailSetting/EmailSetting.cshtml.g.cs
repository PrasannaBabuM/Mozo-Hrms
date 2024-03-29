#pragma checksum "F:\HRMS_netcore\SmartH2R\src\SmartH2RCore.Web\Views\EmailSetting\EmailSetting.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "28d8378d43522936f91d9c7423a4f682f7b9fd653cbfda36e4bb2e38b07b73c1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_EmailSetting_EmailSetting), @"mvc.1.0.view", @"/Views/EmailSetting/EmailSetting.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"28d8378d43522936f91d9c7423a4f682f7b9fd653cbfda36e4bb2e38b07b73c1", @"/Views/EmailSetting/EmailSetting.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"40e21cc8aa428901517b537ec0aa48eab916f283bf3d7731bc7b9bafe3204a71", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_EmailSetting_EmailSetting : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SmartH2RCore.Models.DTO.Settings.EmailSettingDTO>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-select2-id", new global::Microsoft.AspNetCore.Html.HtmlString("5"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "F:\HRMS_netcore\SmartH2R\src\SmartH2RCore.Web\Views\EmailSetting\EmailSetting.cshtml"
  
    ViewData["Title"] = "Email Setting";
    Layout = "~/Views/Shared/_LayoutSettings.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"content container-fluid\" data-select2-id=\"8\">\r\n    <div class=\"row\" data-select2-id=\"7\">\r\n        <div class=\"col-md-8 offset-md-2\" data-select2-id=\"6\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "28d8378d43522936f91d9c7423a4f682f7b9fd653cbfda36e4bb2e38b07b73c14957", async() => {
                WriteLiteral("\r\n                ");
#nullable restore
#line 10 "F:\HRMS_netcore\SmartH2R\src\SmartH2RCore.Web\Views\EmailSetting\EmailSetting.cshtml"
           Write(Html.HiddenFor(v=>v.Id));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                <h4 class=""page-title m-t-30"">SMTP Email Settings</h4>
                <div class=""row"">
                    <div class=""col-sm-6"">
                        <div class=""form-group"">
                            <label>SMTP HOST</label>
                            ");
#nullable restore
#line 16 "F:\HRMS_netcore\SmartH2R\src\SmartH2RCore.Web\Views\EmailSetting\EmailSetting.cshtml"
                       Write(Html.TextBoxFor(model => model.SmtpHost, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            ");
#nullable restore
#line 17 "F:\HRMS_netcore\SmartH2R\src\SmartH2RCore.Web\Views\EmailSetting\EmailSetting.cshtml"
                       Write(Html.ValidationMessageFor(model => model.SmtpHost, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"col-sm-6\">\r\n                        <div class=\"form-group\">\r\n                            <label>SMTP USER</label>\r\n                            ");
#nullable restore
#line 23 "F:\HRMS_netcore\SmartH2R\src\SmartH2RCore.Web\Views\EmailSetting\EmailSetting.cshtml"
                       Write(Html.TextBoxFor(model => model.SmtpUser, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            ");
#nullable restore
#line 24 "F:\HRMS_netcore\SmartH2R\src\SmartH2RCore.Web\Views\EmailSetting\EmailSetting.cshtml"
                       Write(Html.ValidationMessageFor(model => model.SmtpUser, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"col-sm-6\">\r\n                        <div class=\"form-group\">\r\n                            <label>SMTP PASSWORD</label>\r\n                            ");
#nullable restore
#line 30 "F:\HRMS_netcore\SmartH2R\src\SmartH2RCore.Web\Views\EmailSetting\EmailSetting.cshtml"
                       Write(Html.TextBoxFor(model => model.SmtpPassword, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            ");
#nullable restore
#line 31 "F:\HRMS_netcore\SmartH2R\src\SmartH2RCore.Web\Views\EmailSetting\EmailSetting.cshtml"
                       Write(Html.ValidationMessageFor(model => model.SmtpPassword, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"col-sm-6\">\r\n                        <div class=\"form-group\">\r\n                            <label>SMTP PORT</label>\r\n                            ");
#nullable restore
#line 37 "F:\HRMS_netcore\SmartH2R\src\SmartH2RCore.Web\Views\EmailSetting\EmailSetting.cshtml"
                       Write(Html.TextBoxFor(model => model.SmtpPort, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            ");
#nullable restore
#line 38 "F:\HRMS_netcore\SmartH2R\src\SmartH2RCore.Web\Views\EmailSetting\EmailSetting.cshtml"
                       Write(Html.ValidationMessageFor(model => model.SmtpPort, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"col-sm-6\">\r\n                        <div class=\"form-group\">\r\n                            <label>SMTP Security</label>\r\n                            ");
#nullable restore
#line 44 "F:\HRMS_netcore\SmartH2R\src\SmartH2RCore.Web\Views\EmailSetting\EmailSetting.cshtml"
                       Write(Html.DropDownListFor(v => v.SmtpSecurity, new List<SelectListItem>() {
                                new SelectListItem { Text = "None", Value = "0" },
                                new SelectListItem { Text = "SSL", Value = "1" },
                                new SelectListItem { Text = "TLS", Value = "2" }
                       }, new { @class = "select" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            ");
#nullable restore
#line 49 "F:\HRMS_netcore\SmartH2R\src\SmartH2RCore.Web\Views\EmailSetting\EmailSetting.cshtml"
                       Write(Html.ValidationMessageFor(model => model.SmtpSecurity, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"col-sm-6\">\r\n                        <div class=\"form-group\">\r\n                            <label>SMTP Authentication Domain</label>\r\n                            ");
#nullable restore
#line 55 "F:\HRMS_netcore\SmartH2R\src\SmartH2RCore.Web\Views\EmailSetting\EmailSetting.cshtml"
                       Write(Html.TextBoxFor(model => model.SmtpAuthenticationDomain, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            ");
#nullable restore
#line 56 "F:\HRMS_netcore\SmartH2R\src\SmartH2RCore.Web\Views\EmailSetting\EmailSetting.cshtml"
                       Write(Html.ValidationMessageFor(model => model.SmtpAuthenticationDomain, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                        </div>
                    </div>
                </div>
                <div class=""submit-section"">
                    <button class=""btn btn-primary submit-btn"">Save &amp; Update</button>
                </div>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SmartH2RCore.Models.DTO.Settings.EmailSettingDTO> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
