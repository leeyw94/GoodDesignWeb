#pragma checksum "D:\03. 프로젝트 _ 김지혜\4. GoodDesign SmarFactory Web\백업\GoodDesignWeb4\SmartFactory\Views\management\Machine_list.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "14f6176607559d644ddcb32206a69e266dfce2d7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_management_Machine_list), @"mvc.1.0.view", @"/Views/management/Machine_list.cshtml")]
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
#line 1 "D:\03. 프로젝트 _ 김지혜\4. GoodDesign SmarFactory Web\백업\GoodDesignWeb4\SmartFactory\Views\_ViewImports.cshtml"
using SmartFactory;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\03. 프로젝트 _ 김지혜\4. GoodDesign SmarFactory Web\백업\GoodDesignWeb4\SmartFactory\Views\_ViewImports.cshtml"
using SmartFactory.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14f6176607559d644ddcb32206a69e266dfce2d7", @"/Views/management/Machine_list.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43cafef1091a06e312061635e1c5144488eda768", @"/Views/_ViewImports.cshtml")]
    public class Views_management_Machine_list : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SmartFactory.Models.machine>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/common/s_edit_icon.gif"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/common/s_icon_del.gif"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\03. 프로젝트 _ 김지혜\4. GoodDesign SmarFactory Web\백업\GoodDesignWeb4\SmartFactory\Views\management\Machine_list.cshtml"
  string language = "korea";

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
            WriteLiteral("\r\n\r\n<div class=\"container sub_page\">\r\n\r\n\r\n    <div class=\"sub_title_black\">\r\n        ");
#nullable restore
#line 22 "D:\03. 프로젝트 _ 김지혜\4. GoodDesign SmarFactory Web\백업\GoodDesignWeb4\SmartFactory\Views\management\Machine_list.cshtml"
   Write(SmartFactory.Util.get_word.language_code(language, "setting"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <hr />\r\n\r\n\r\n    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n                <th>\r\n                    Num\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 34 "D:\03. 프로젝트 _ 김지혜\4. GoodDesign SmarFactory Web\백업\GoodDesignWeb4\SmartFactory\Views\management\Machine_list.cshtml"
               Write(SmartFactory.Util.get_word.language_code(language, "title"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 37 "D:\03. 프로젝트 _ 김지혜\4. GoodDesign SmarFactory Web\백업\GoodDesignWeb4\SmartFactory\Views\management\Machine_list.cshtml"
               Write(Html.DisplayNameFor(model => model.company_idx));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 40 "D:\03. 프로젝트 _ 김지혜\4. GoodDesign SmarFactory Web\백업\GoodDesignWeb4\SmartFactory\Views\management\Machine_list.cshtml"
               Write(SmartFactory.Util.get_word.language_code(language, "date"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 46 "D:\03. 프로젝트 _ 김지혜\4. GoodDesign SmarFactory Web\백업\GoodDesignWeb4\SmartFactory\Views\management\Machine_list.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td style=\"width:50px\">");
#nullable restore
#line 49 "D:\03. 프로젝트 _ 김지혜\4. GoodDesign SmarFactory Web\백업\GoodDesignWeb4\SmartFactory\Views\management\Machine_list.cshtml"
                                      Write(item.idx);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td style=\"text-align:left\">\r\n                        \r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1206, "\"", 1250, 2);
            WriteAttributeValue("", 1213, "/management/machine_set?idx=", 1213, 28, true);
#nullable restore
#line 52 "D:\03. 프로젝트 _ 김지혜\4. GoodDesign SmarFactory Web\백업\GoodDesignWeb4\SmartFactory\Views\management\Machine_list.cshtml"
WriteAttributeValue("", 1241, item.idx, 1241, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            ");
#nullable restore
#line 53 "D:\03. 프로젝트 _ 김지혜\4. GoodDesign SmarFactory Web\백업\GoodDesignWeb4\SmartFactory\Views\management\Machine_list.cshtml"
                       Write(Html.DisplayFor(modelItem => item.mName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </a>\r\n\r\n\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 59 "D:\03. 프로젝트 _ 김지혜\4. GoodDesign SmarFactory Web\백업\GoodDesignWeb4\SmartFactory\Views\management\Machine_list.cshtml"
                   Write(Html.DisplayFor(modelItem => item.company_idxNavigation.company_name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td style=\"width:120px\">\r\n                      \r\n\r\n                        ");
#nullable restore
#line 64 "D:\03. 프로젝트 _ 김지혜\4. GoodDesign SmarFactory Web\백업\GoodDesignWeb4\SmartFactory\Views\management\Machine_list.cshtml"
                   Write(item.writeDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                    </td>\r\n                    <td>\r\n\r\n\r\n                        <span type=\"button\" rel=\"tooltip\" title=\"Edit Task\" class=\"btn btn-info btn-simple btn-xs\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "14f6176607559d644ddcb32206a69e266dfce2d78885", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "onclick", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1924, "go(\'/management/Machine_set?idx=", 1924, 32, true);
#nullable restore
#line 71 "D:\03. 프로젝트 _ 김지혜\4. GoodDesign SmarFactory Web\백업\GoodDesignWeb4\SmartFactory\Views\management\Machine_list.cshtml"
AddHtmlAttributeValue("", 1956, item.idx, 1956, 9, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 1965, "\')", 1965, 2, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </span>\r\n                        <span type=\"button\" rel=\"tooltip\" title=\"Remove\" class=\"btn btn-danger btn-simple btn-xs\">\r\n\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "14f6176607559d644ddcb32206a69e266dfce2d710770", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "onclick", 4, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2203, "del_it(\'/management/Machine_action?idx=", 2203, 39, true);
#nullable restore
#line 75 "D:\03. 프로젝트 _ 김지혜\4. GoodDesign SmarFactory Web\백업\GoodDesignWeb4\SmartFactory\Views\management\Machine_list.cshtml"
AddHtmlAttributeValue("", 2242, item.idx, 2242, 9, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 2251, "\')", 2251, 2, true);
            AddHtmlAttributeValue(" ", 2253, "", 2254, 1, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </span>\r\n\r\n\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 81 "D:\03. 프로젝트 _ 김지혜\4. GoodDesign SmarFactory Web\백업\GoodDesignWeb4\SmartFactory\Views\management\Machine_list.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n\r\n    <div class=\"col-md-12\" style=\"display: table; margin: 20px; text-align: center;\">\r\n        <div class=\"btn btn-default btn-fill btn-wd   btn-info\" onclick=\"go(\'Machine_set\') \">\r\n\r\n            ");
#nullable restore
#line 88 "D:\03. 프로젝트 _ 김지혜\4. GoodDesign SmarFactory Web\백업\GoodDesignWeb4\SmartFactory\Views\management\Machine_list.cshtml"
       Write(SmartFactory.Util.get_word.language_code(language, "create"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SmartFactory.Models.machine>> Html { get; private set; }
    }
}
#pragma warning restore 1591
