#pragma checksum "E:\00. 프로젝트 홈작업\00. GoodDesign SmarFactory Web\GoodDesignWeb\SmartFactory\Views\sys\department_set_list.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "546a5b573c0a0abb328532eb383b0b43786d7c2a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_sys_department_set_list), @"mvc.1.0.view", @"/Views/sys/department_set_list.cshtml")]
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
#line 1 "E:\00. 프로젝트 홈작업\00. GoodDesign SmarFactory Web\GoodDesignWeb\SmartFactory\Views\_ViewImports.cshtml"
using SmartFactory;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "E:\00. 프로젝트 홈작업\00. GoodDesign SmarFactory Web\GoodDesignWeb\SmartFactory\Views\sys\department_set_list.cshtml"
using SmartFactory.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"546a5b573c0a0abb328532eb383b0b43786d7c2a", @"/Views/sys/department_set_list.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43cafef1091a06e312061635e1c5144488eda768", @"/Views/_ViewImports.cshtml")]
    public class Views_sys_department_set_list : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SmartFactory.Models.department>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "setting_menu", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/common/s_edit_icon.gif"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/common/s_icon_del.gif"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "E:\00. 프로젝트 홈작업\00. GoodDesign SmarFactory Web\GoodDesignWeb\SmartFactory\Views\sys\department_set_list.cshtml"
  string language =  "korea";

    try
    {
        language = Context.Request.Cookies["language"] ?? "korea";

    }
    catch
    {


    }


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "546a5b573c0a0abb328532eb383b0b43786d7c2a4843", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</div>\r\n\r\n\r\n<div class=\"container  sub_page\">\r\n\r\n    <div class=\"sub_title_black\">\r\n        ");
#nullable restore
#line 31 "E:\00. 프로젝트 홈작업\00. GoodDesign SmarFactory Web\GoodDesignWeb\SmartFactory\Views\sys\department_set_list.cshtml"
   Write(SmartFactory.Util.get_word.language_code(language, "department"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 31 "E:\00. 프로젝트 홈작업\00. GoodDesign SmarFactory Web\GoodDesignWeb\SmartFactory\Views\sys\department_set_list.cshtml"
                                                                     Write(SmartFactory.Util.get_word.language_code(language, "setting"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <hr />\r\n    <div class=\"content check_auth\">\r\n\r\n        <div class=\"col-md-2\" style=\"float: right; padding-bottom: 15px;\">\r\n            ");
#nullable restore
#line 37 "E:\00. 프로젝트 홈작업\00. GoodDesign SmarFactory Web\GoodDesignWeb\SmartFactory\Views\sys\department_set_list.cshtml"
       Write(Html.DropDownList("companyidx", (SelectList)ViewBag.회사, "회사선택", new { @class = "form-control", @data_style = "btn-info btn-fill btn-block", @onchange = "search()" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

        </div>
    </div>
    <table class=""table table-hover table-striped"">
        <thead>
            <tr>
                <th>
                    Company name
                </th>
                <th>
                    Department name
                </th>

                <th>
                    Date
                </th>
                <th>
                    Use
                </th>
                <th>
                    Company name
                </th>
                <th class=""check_auth"">Edit</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 64 "E:\00. 프로젝트 홈작업\00. GoodDesign SmarFactory Web\GoodDesignWeb\SmartFactory\Views\sys\department_set_list.cshtml"
             foreach (department item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1581, "\"", 1622, 2);
            WriteAttributeValue("", 1588, "/sys/department_set/?idx=", 1588, 25, true);
#nullable restore
#line 68 "E:\00. 프로젝트 홈작업\00. GoodDesign SmarFactory Web\GoodDesignWeb\SmartFactory\Views\sys\department_set_list.cshtml"
WriteAttributeValue("", 1613, item.idx, 1613, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"font-weight: bold\">");
#nullable restore
#line 68 "E:\00. 프로젝트 홈작업\00. GoodDesign SmarFactory Web\GoodDesignWeb\SmartFactory\Views\sys\department_set_list.cshtml"
                                                                                          Write(Html.DisplayFor(modelItem => item.company_idxNavigation.company_name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                    </td>\r\n                    <td>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1805, "\"", 1846, 2);
            WriteAttributeValue("", 1812, "/sys/department_set/?idx=", 1812, 25, true);
#nullable restore
#line 71 "E:\00. 프로젝트 홈작업\00. GoodDesign SmarFactory Web\GoodDesignWeb\SmartFactory\Views\sys\department_set_list.cshtml"
WriteAttributeValue("", 1837, item.idx, 1837, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"font-weight: bold\">");
#nullable restore
#line 71 "E:\00. 프로젝트 홈작업\00. GoodDesign SmarFactory Web\GoodDesignWeb\SmartFactory\Views\sys\department_set_list.cshtml"
                                                                                          Write(Html.DisplayFor(modelItem => item.department_name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                    </td>\r\n\r\n                    <td>\r\n                        ");
#nullable restore
#line 75 "E:\00. 프로젝트 홈작업\00. GoodDesign SmarFactory Web\GoodDesignWeb\SmartFactory\Views\sys\department_set_list.cshtml"
                   Write(Html.DisplayFor(modelItem => item.write_date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 78 "E:\00. 프로젝트 홈작업\00. GoodDesign SmarFactory Web\GoodDesignWeb\SmartFactory\Views\sys\department_set_list.cshtml"
                   Write(Html.DisplayFor(modelItem => item.use_yn));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </td>
                    <td>
                    </td>
                    <td class=""check_auth"">


                        <span type=""button"" rel=""tooltip"" title=""Edit Task"" class=""btn btn-info btn-simple btn-xs"">
                            <a");
            BeginWriteAttribute("href", " href=\"", 2455, "\"", 2495, 2);
            WriteAttributeValue("", 2462, "/sys/department_set?idx=", 2462, 24, true);
#nullable restore
#line 86 "E:\00. 프로젝트 홈작업\00. GoodDesign SmarFactory Web\GoodDesignWeb\SmartFactory\Views\sys\department_set_list.cshtml"
WriteAttributeValue("", 2486, item.idx, 2486, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "546a5b573c0a0abb328532eb383b0b43786d7c2a11698", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</a>\r\n                        </span>\r\n                        <span type=\"button\" rel=\"tooltip\" title=\"Edit Task\" class=\"btn btn-info btn-simple btn-xs\">\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 2729, "\"", 2767, 2);
            WriteAttributeValue("", 2736, "/sys/company_set/?idx=", 2736, 22, true);
#nullable restore
#line 89 "E:\00. 프로젝트 홈작업\00. GoodDesign SmarFactory Web\GoodDesignWeb\SmartFactory\Views\sys\department_set_list.cshtml"
WriteAttributeValue("", 2758, item.idx, 2758, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></a>\r\n                        </span>\r\n\r\n\r\n\r\n\r\n                        <span type=\"button\" rel=\"tooltip\" title=\"Remove\" class=\"btn btn-danger btn-simple btn-xs\">\r\n\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "546a5b573c0a0abb328532eb383b0b43786d7c2a13619", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "onclick", 4, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3013, "del_it(\'/sys/department_set_action?idx=", 3013, 39, true);
#nullable restore
#line 97 "E:\00. 프로젝트 홈작업\00. GoodDesign SmarFactory Web\GoodDesignWeb\SmartFactory\Views\sys\department_set_list.cshtml"
AddHtmlAttributeValue("", 3052, item.idx, 3052, 9, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 3061, "\')", 3061, 2, true);
            AddHtmlAttributeValue(" ", 3063, "", 3064, 1, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                        </span>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 102 "E:\00. 프로젝트 홈작업\00. GoodDesign SmarFactory Web\GoodDesignWeb\SmartFactory\Views\sys\department_set_list.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </tbody>
    </table>

    <fieldset>
        <div class=""form-group check_auth"">
            <div class=""col-md-12"" style=""display: table; margin: 20px; text-align: center;"">
                <div class=""btn btn-default btn-fill btn-wd   btn-info"" onclick=""go('department_set') "">

                    ");
#nullable restore
#line 111 "E:\00. 프로젝트 홈작업\00. GoodDesign SmarFactory Web\GoodDesignWeb\SmartFactory\Views\sys\department_set_list.cshtml"
               Write(SmartFactory.Util.get_word.language_code(language, "create"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </div>
            </div>
        </div>
    </fieldset>
</div>


<script type=""text/javascript"">

    $().ready(function () {

        //  $('#company_id option[value=' + company_id + ']').attr('selected', 'selected');


    });

    function search() {

        var company_id = $(""#companyidx"").find(""option:selected"").val();



        location.href = ""/sys/department_set_list?companyidx="" + company_id;
    }

</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SmartFactory.Models.department>> Html { get; private set; }
    }
}
#pragma warning restore 1591
