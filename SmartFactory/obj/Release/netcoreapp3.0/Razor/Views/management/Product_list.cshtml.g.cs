#pragma checksum "D:\03. 프로젝트 _ 김지혜\4. GoodDesign SmarFactory Web\GoodDesignWeb\SmartFactory\Views\management\Product_list.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4580e7688ce84da3984f9862ab605e016e86c4ce"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_management_Product_list), @"mvc.1.0.view", @"/Views/management/Product_list.cshtml")]
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
#line 1 "D:\03. 프로젝트 _ 김지혜\4. GoodDesign SmarFactory Web\GoodDesignWeb\SmartFactory\Views\_ViewImports.cshtml"
using SmartFactory;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\03. 프로젝트 _ 김지혜\4. GoodDesign SmarFactory Web\GoodDesignWeb\SmartFactory\Views\_ViewImports.cshtml"
using SmartFactory.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4580e7688ce84da3984f9862ab605e016e86c4ce", @"/Views/management/Product_list.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43cafef1091a06e312061635e1c5144488eda768", @"/Views/_ViewImports.cshtml")]
    public class Views_management_Product_list : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SmartFactory.Models.Product>>
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
#line 3 "D:\03. 프로젝트 _ 김지혜\4. GoodDesign SmarFactory Web\GoodDesignWeb\SmartFactory\Views\management\Product_list.cshtml"
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
#line 22 "D:\03. 프로젝트 _ 김지혜\4. GoodDesign SmarFactory Web\GoodDesignWeb\SmartFactory\Views\management\Product_list.cshtml"
   Write(SmartFactory.Util.get_word.language_code(language, "setting"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <hr />\r\n\r\n\r\n    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n                <th>\r\n                    ");
#nullable restore
#line 31 "D:\03. 프로젝트 _ 김지혜\4. GoodDesign SmarFactory Web\GoodDesignWeb\SmartFactory\Views\management\Product_list.cshtml"
               Write(Html.DisplayNameFor(model => model.pName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 34 "D:\03. 프로젝트 _ 김지혜\4. GoodDesign SmarFactory Web\GoodDesignWeb\SmartFactory\Views\management\Product_list.cshtml"
               Write(Html.DisplayNameFor(model => model.product_idx));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 37 "D:\03. 프로젝트 _ 김지혜\4. GoodDesign SmarFactory Web\GoodDesignWeb\SmartFactory\Views\management\Product_list.cshtml"
               Write(Html.DisplayNameFor(model => model.writeDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 43 "D:\03. 프로젝트 _ 김지혜\4. GoodDesign SmarFactory Web\GoodDesignWeb\SmartFactory\Views\management\Product_list.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 47 "D:\03. 프로젝트 _ 김지혜\4. GoodDesign SmarFactory Web\GoodDesignWeb\SmartFactory\Views\management\Product_list.cshtml"
                   Write(Html.DisplayFor(modelItem => item.pName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 50 "D:\03. 프로젝트 _ 김지혜\4. GoodDesign SmarFactory Web\GoodDesignWeb\SmartFactory\Views\management\Product_list.cshtml"
                   Write(Html.DisplayFor(modelItem => item.product_idx));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 53 "D:\03. 프로젝트 _ 김지혜\4. GoodDesign SmarFactory Web\GoodDesignWeb\SmartFactory\Views\management\Product_list.cshtml"
                   Write(Html.DisplayFor(modelItem => item.writeDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n\r\n\r\n                        <span type=\"button\" rel=\"tooltip\" title=\"Edit Task\" class=\"btn btn-info btn-simple btn-xs\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4580e7688ce84da3984f9862ab605e016e86c4ce7703", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "onclick", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1541, "go(\'/management/Product_set?idx=", 1541, 32, true);
#nullable restore
#line 59 "D:\03. 프로젝트 _ 김지혜\4. GoodDesign SmarFactory Web\GoodDesignWeb\SmartFactory\Views\management\Product_list.cshtml"
AddHtmlAttributeValue("", 1573, item.idx, 1573, 9, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 1582, "\')", 1582, 2, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </span>\r\n                        <span type=\"button\" rel=\"tooltip\" title=\"Remove\" class=\"btn btn-danger btn-simple btn-xs\">\r\n\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4580e7688ce84da3984f9862ab605e016e86c4ce9584", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "onclick", 4, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1820, "del_it(\'/management/Product_action?idx=", 1820, 39, true);
#nullable restore
#line 63 "D:\03. 프로젝트 _ 김지혜\4. GoodDesign SmarFactory Web\GoodDesignWeb\SmartFactory\Views\management\Product_list.cshtml"
AddHtmlAttributeValue("", 1859, item.idx, 1859, 9, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 1868, "\')", 1868, 2, true);
            AddHtmlAttributeValue(" ", 1870, "", 1871, 1, true);
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
#line 69 "D:\03. 프로젝트 _ 김지혜\4. GoodDesign SmarFactory Web\GoodDesignWeb\SmartFactory\Views\management\Product_list.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n\r\n    <div class=\"col-md-12\" style=\"display: table; margin: 20px; text-align: center;\">\r\n        <div class=\"btn btn-default btn-fill btn-wd   btn-info\" onclick=\"go(\'Product_set\') \">\r\n\r\n            ");
#nullable restore
#line 76 "D:\03. 프로젝트 _ 김지혜\4. GoodDesign SmarFactory Web\GoodDesignWeb\SmartFactory\Views\management\Product_list.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SmartFactory.Models.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591