#pragma checksum "F:\HRMS_netcore\SmartH2R\src\SmartH2RCore.Web\Views\EmployeeSubType\List.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "b5f3905c4dfcc7d91b8acda3965b1ad42143f8165fa1982129a672d80f273fc4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_EmployeeSubType_List), @"mvc.1.0.view", @"/Views/EmployeeSubType/List.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"b5f3905c4dfcc7d91b8acda3965b1ad42143f8165fa1982129a672d80f273fc4", @"/Views/EmployeeSubType/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"40e21cc8aa428901517b537ec0aa48eab916f283bf3d7731bc7b9bafe3204a71", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_EmployeeSubType_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SmartH2RCore.Models.DTO.Master.EmployeeSubTypeDTO>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "MasterDashboard", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Add", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "EmployeeSubType", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn add-btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", "datatable", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", "table table-striped custom-table mb-0 datatable", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("thead-class", "text-center", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("search-row-th-class", "p-0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("search-input-class", "form-control", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("search-input-style", "form-control", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("search-input-placeholder-prefix", "Search", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::JqueryDataTables.ServerSide.AspNetCoreWeb.TagHelpers.JqueryDataTablesTagHelper __JqueryDataTables_ServerSide_AspNetCoreWeb_TagHelpers_JqueryDataTablesTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "F:\HRMS_netcore\SmartH2R\src\SmartH2RCore.Web\Views\EmployeeSubType\List.cshtml"
  
    Layout = "~/Views/Shared/_LayoutMaster.cshtml";
    ViewData["Title"] = "Employee Sub Type Master";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""content container-fluid"">
    <!-- Page Header -->
    <div class=""page-header"">
        <div class=""row align-items-center"">
            <div class=""col"">
                <h3 class=""page-title"">Employee Sub Type</h3>
                <ul class=""breadcrumb"">
                    <li class=""breadcrumb-item"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b5f3905c4dfcc7d91b8acda3965b1ad42143f8165fa1982129a672d80f273fc48251", async() => {
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
            WriteLiteral("</li>\r\n                    <li class=\"breadcrumb-item active\">Employee Sub Type</li>\r\n                </ul>\r\n            </div>\r\n            <div class=\"col-auto float-right ml-auto\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b5f3905c4dfcc7d91b8acda3965b1ad42143f8165fa1982129a672d80f273fc49850", async() => {
                WriteLiteral("<i class=\"fa fa-plus\"></i>Add");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <!-- /Page Header -->\r\n\r\n    <div class=\"row\">\r\n        <div class=\"col-md-12\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("jquery-datatables", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b5f3905c4dfcc7d91b8acda3965b1ad42143f8165fa1982129a672d80f273fc411506", async() => {
                WriteLiteral("\r\n            ");
            }
            );
            __JqueryDataTables_ServerSide_AspNetCoreWeb_TagHelpers_JqueryDataTablesTagHelper = CreateTagHelper<global::JqueryDataTables.ServerSide.AspNetCoreWeb.TagHelpers.JqueryDataTablesTagHelper>();
            __tagHelperExecutionContext.Add(__JqueryDataTables_ServerSide_AspNetCoreWeb_TagHelpers_JqueryDataTablesTagHelper);
            __JqueryDataTables_ServerSide_AspNetCoreWeb_TagHelpers_JqueryDataTablesTagHelper.Id = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __JqueryDataTables_ServerSide_AspNetCoreWeb_TagHelpers_JqueryDataTablesTagHelper.Class = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
#nullable restore
#line 29 "F:\HRMS_netcore\SmartH2R\src\SmartH2RCore.Web\Views\EmployeeSubType\List.cshtml"
__JqueryDataTables_ServerSide_AspNetCoreWeb_TagHelpers_JqueryDataTablesTagHelper.Model = Model;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __JqueryDataTables_ServerSide_AspNetCoreWeb_TagHelpers_JqueryDataTablesTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __JqueryDataTables_ServerSide_AspNetCoreWeb_TagHelpers_JqueryDataTablesTagHelper.TheadClass = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
#nullable restore
#line 31 "F:\HRMS_netcore\SmartH2R\src\SmartH2RCore.Web\Views\EmployeeSubType\List.cshtml"
__JqueryDataTables_ServerSide_AspNetCoreWeb_TagHelpers_JqueryDataTablesTagHelper.EnableSearching = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("enable-searching", __JqueryDataTables_ServerSide_AspNetCoreWeb_TagHelpers_JqueryDataTablesTagHelper.EnableSearching, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __JqueryDataTables_ServerSide_AspNetCoreWeb_TagHelpers_JqueryDataTablesTagHelper.SearchRowThClass = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __JqueryDataTables_ServerSide_AspNetCoreWeb_TagHelpers_JqueryDataTablesTagHelper.SearchInputClass = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            __JqueryDataTables_ServerSide_AspNetCoreWeb_TagHelpers_JqueryDataTablesTagHelper.SearchInputStyle = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            __JqueryDataTables_ServerSide_AspNetCoreWeb_TagHelpers_JqueryDataTablesTagHelper.SearchInputPlaceholderPrefix = (string)__tagHelperAttribute_11.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
#nullable restore
#line 36 "F:\HRMS_netcore\SmartH2R\src\SmartH2RCore.Web\Views\EmployeeSubType\List.cshtml"
__JqueryDataTables_ServerSide_AspNetCoreWeb_TagHelpers_JqueryDataTablesTagHelper.UsePropertyTypeAsInputType = false;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("use-property-type-as-input-type", __JqueryDataTables_ServerSide_AspNetCoreWeb_TagHelpers_JqueryDataTablesTagHelper.UsePropertyTypeAsInputType, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
     $(document).ready(function () {
         var table = $('#datatable').DataTable({
            language: {
                processing: ""Loading Data..."",
                zeroRecords: ""No matching records found""
            },
            processing: true,
            serverSide: true,
            orderCellsTop: true,
            search: false,
            autoWidth: true,
            deferRender: true,
            lengthMenu: [[5, 10, 15, 20, -1], [5, 10, 15, 20, ""All""]],
             dom: '<""row""<""col-sm-12 col-md-6""B><""col-sm-12 col-md-6 text-right""l>><""row""<""col-sm-12""tr>><""row""<""col-sm-12 col-md-5""i><""col-sm-12 col-md-7""p>>',
             dom: '<""row""<""col-sm-12 col-md-6""B><""col-sm-12 col-md-6 text-right""l>><""row""<""col-sm-12""tr>><""row""<""col-sm-12 col-md-5""i><""col-sm-12 col-md-7""p>>',
             buttons: [
                 {
                     text: ""Excel"",
                     className: 'btn btn-sm btn add-btn float-left',
                     action: function (");
                WriteLiteral("e, dt, node, config) {\r\n                         window.location.href = \"");
#nullable restore
#line 64 "F:\HRMS_netcore\SmartH2R\src\SmartH2RCore.Web\Views\EmployeeSubType\List.cshtml"
                                            Write(Url.Action("GetExcel"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@""";
                     },
                     init: function (api, node, config) {
                         $(node).removeClass('dt-button');
                     }
                 }
             ],
            ajax: {
                type: ""POST"",
                url: '");
#nullable restore
#line 73 "F:\HRMS_netcore\SmartH2R\src\SmartH2RCore.Web\Views\EmployeeSubType\List.cshtml"
                 Write(Url.Action("GetEmployeeSubType"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"',
                contentType: ""application/json; charset=utf-8"",
                async: true,
                data: function (data) {
                    return JSON.stringify(data);
                }
            },
             columns: [
                {
                    data: ""Name"",
                    name: ""co""
                },
                {
                    data: ""EmployeeTypeName"",
                    name: ""co""
                },               
                {
                    title: ""Action"",
                    data: 'Id',
                    searchable: false,
                    orderable: false,
                    render: function (data, type, full, meta) {
                        data = '<div class=""dropdown dropdown-action"">'
                                + '<a href=""#"" class=""action-icon dropdown-toggle"" data-toggle=""dropdown"" aria-expanded=""false""><i class=""material-icons"">more_vert</i></a>'
                                + '<div class=""dropdow");
                WriteLiteral("n-menu dropdown-menu-right\">\'\r\n                                + \'<a class=\"dropdown-item\" href=\"");
#nullable restore
#line 98 "F:\HRMS_netcore\SmartH2R\src\SmartH2RCore.Web\Views\EmployeeSubType\List.cshtml"
                                                             Write(Url.Action("Edit"));

#line default
#line hidden
#nullable disable
                WriteLiteral("/\' + data + \'\"><i class=\"fa fa-pencil m-r-5\"></i> Edit</a>\'\r\n                                + \'<a class=\"dropdown-item deleteRecord\" href=\"");
#nullable restore
#line 99 "F:\HRMS_netcore\SmartH2R\src\SmartH2RCore.Web\Views\EmployeeSubType\List.cshtml"
                                                                          Write(Url.Action("Delete"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"/' + data + '""><i class=""fa fa-trash-o m-r-5""></i> Delete</a>'
                                + '</div> </div>'
                            return data;
                    }
                }
            ]
         })
         table.columns().every(function (index) {
             $('#datatable thead tr:last th:eq(' + index + ') input')
                 .on('keyup',
                     function (e) {
                         if (e.keyCode === 13) {
                             table.column($(this).parent().index() + ':visible').search(this.value).draw();
                         }
                     });
         });
    });
    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SmartH2RCore.Models.DTO.Master.EmployeeSubTypeDTO> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
