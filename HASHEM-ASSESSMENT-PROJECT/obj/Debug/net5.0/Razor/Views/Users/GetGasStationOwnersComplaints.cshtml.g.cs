#pragma checksum "C:\ProjectBackup\TESTPRO\HASHEM-ASSESSMENT-PROJECT\Views\Users\GetGasStationOwnersComplaints.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d912cb4268d311f69a4787efc32ea786d99c7af0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_GetGasStationOwnersComplaints), @"mvc.1.0.view", @"/Views/Users/GetGasStationOwnersComplaints.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\ProjectBackup\TESTPRO\HASHEM-ASSESSMENT-PROJECT\Views\_ViewImports.cshtml"
using HASHEM_ASSESSMENT_PROJECT;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\ProjectBackup\TESTPRO\HASHEM-ASSESSMENT-PROJECT\Views\_ViewImports.cshtml"
using HASHEM_ASSESSMENT_PROJECT.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d912cb4268d311f69a4787efc32ea786d99c7af0", @"/Views/Users/GetGasStationOwnersComplaints.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"98c619f9ab6464f72c196f74d2b99ffe4fb8ab78", @"/Views/_ViewImports.cshtml")]
    public class Views_Users_GetGasStationOwnersComplaints : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<HASHEM_ASSESSMENT_PROJECT.DATA.Models.GasStationComplaints>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success text-white"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ViewGasStationOwnersComplaintsDocument", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\ProjectBackup\TESTPRO\HASHEM-ASSESSMENT-PROJECT\Views\Users\GetGasStationOwnersComplaints.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<link rel=""stylesheet"" type=""text/css"" href=""https://cdn.datatables.net/1.11.4/css/jquery.dataTables.min.css"">
<link rel=""preconnect"" href=""https://fonts.googleapis.com"">
<link rel=""preconnect"" href=""https://fonts.gstatic.com"" crossorigin>
<link href=""https://fonts.googleapis.com/css2?family=Roboto:wght@300&display=swap"" rel=""stylesheet"">
<script src=""https://code.jquery.com/jquery-3.5.1.js""></script>
<script type=""text/javascript"" charset=""utf8"" src=""https://cdn.datatables.net/1.11.4/js/jquery.dataTables.min.js""></script>
<script>
    $(document).ready(function () {
        $.noConflict();
        $('#stations').DataTable();
    });</script>
<div class=""container-fluid"" style=""font-family: 'Roboto', sans-serif;"">
    <div class=""row"">
        <div class=""col-sm-12 text-center"">
            <h3 style=""color:#006600"">Station Owners Complaints Master List</h3>
        </div>
    </div>
    <div class=""row"">
        <div class=""col-sm-12"">
            <table class=""table table-striped display""");
            WriteLiteral(" id=\"stations\">\r\n                <thead>\r\n                    <tr>\r\n                        <th>\r\n                            ");
#nullable restore
#line 29 "C:\ProjectBackup\TESTPRO\HASHEM-ASSESSMENT-PROJECT\Views\Users\GetGasStationOwnersComplaints.cshtml"
                       Write(Html.DisplayNameFor(model => model.BusinessName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 32 "C:\ProjectBackup\TESTPRO\HASHEM-ASSESSMENT-PROJECT\Views\Users\GetGasStationOwnersComplaints.cshtml"
                       Write(Html.DisplayNameFor(model => model.SupplyDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 35 "C:\ProjectBackup\TESTPRO\HASHEM-ASSESSMENT-PROJECT\Views\Users\GetGasStationOwnersComplaints.cshtml"
                       Write(Html.DisplayNameFor(model => model.SupplyLocation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 38 "C:\ProjectBackup\TESTPRO\HASHEM-ASSESSMENT-PROJECT\Views\Users\GetGasStationOwnersComplaints.cshtml"
                       Write(Html.DisplayNameFor(model => model.TotalQuantityRecieved));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th>Documents</th>\r\n                    </tr>\r\n                </thead>\r\n                <tbody>\r\n");
#nullable restore
#line 44 "C:\ProjectBackup\TESTPRO\HASHEM-ASSESSMENT-PROJECT\Views\Users\GetGasStationOwnersComplaints.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
#nullable restore
#line 48 "C:\ProjectBackup\TESTPRO\HASHEM-ASSESSMENT-PROJECT\Views\Users\GetGasStationOwnersComplaints.cshtml"
                           Write(Html.DisplayFor(modelItem => item.BusinessName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 51 "C:\ProjectBackup\TESTPRO\HASHEM-ASSESSMENT-PROJECT\Views\Users\GetGasStationOwnersComplaints.cshtml"
                           Write(Html.DisplayFor(modelItem => item.SupplyDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 54 "C:\ProjectBackup\TESTPRO\HASHEM-ASSESSMENT-PROJECT\Views\Users\GetGasStationOwnersComplaints.cshtml"
                           Write(Html.DisplayFor(modelItem => item.SupplyLocation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 57 "C:\ProjectBackup\TESTPRO\HASHEM-ASSESSMENT-PROJECT\Views\Users\GetGasStationOwnersComplaints.cshtml"
                           Write(Html.DisplayFor(modelItem => item.TotalQuantityRecieved));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td class=\"text-center\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d912cb4268d311f69a4787efc32ea786d99c7af09114", async() => {
                WriteLiteral("View");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 60 "C:\ProjectBackup\TESTPRO\HASHEM-ASSESSMENT-PROJECT\Views\Users\GetGasStationOwnersComplaints.cshtml"
                                                                                                                            WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 63 "C:\ProjectBackup\TESTPRO\HASHEM-ASSESSMENT-PROJECT\Views\Users\GetGasStationOwnersComplaints.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<HASHEM_ASSESSMENT_PROJECT.DATA.Models.GasStationComplaints>> Html { get; private set; }
    }
}
#pragma warning restore 1591
