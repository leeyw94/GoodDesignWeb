#pragma checksum "D:\OneDrive - (주)블루아이\02. 개발(대표)\15. 굿디자인 스마트 팩토리\GoodDesignWeb\SmartFactory\Views\Board\board_set_list.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3e2127a8d8764a91448ee8309377dc7ac9b83d37"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Board_board_set_list), @"mvc.1.0.view", @"/Views/Board/board_set_list.cshtml")]
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
#line 1 "D:\OneDrive - (주)블루아이\02. 개발(대표)\15. 굿디자인 스마트 팩토리\GoodDesignWeb\SmartFactory\Views\_ViewImports.cshtml"
using SmartFactory;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\OneDrive - (주)블루아이\02. 개발(대표)\15. 굿디자인 스마트 팩토리\GoodDesignWeb\SmartFactory\Views\Board\board_set_list.cshtml"
using SmartFactory.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e2127a8d8764a91448ee8309377dc7ac9b83d37", @"/Views/Board/board_set_list.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43cafef1091a06e312061635e1c5144488eda768", @"/Views/_ViewImports.cshtml")]
    public class Views_Board_board_set_list : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SmartFactory.Models.BoardMenu>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "~/Views/sys/setting_menu.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 3 "D:\OneDrive - (주)블루아이\02. 개발(대표)\15. 굿디자인 스마트 팩토리\GoodDesignWeb\SmartFactory\Views\Board\board_set_list.cshtml"
  string language = Context.Request.Cookies["language"] ?? "korea";

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
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3e2127a8d8764a91448ee8309377dc7ac9b83d374836", async() => {
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
            WriteLiteral("\r\n\r\n<div class=\"container  sub_page\">\r\n\r\n\r\n\r\n    <div class=\"sub_title_black\">\r\n        ");
#nullable restore
#line 27 "D:\OneDrive - (주)블루아이\02. 개발(대표)\15. 굿디자인 스마트 팩토리\GoodDesignWeb\SmartFactory\Views\Board\board_set_list.cshtml"
   Write(SmartFactory.Util.get_word.language_code(language, "boardSettings"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <hr />\r\n    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n                <th>\r\n                    ");
#nullable restore
#line 34 "D:\OneDrive - (주)블루아이\02. 개발(대표)\15. 굿디자인 스마트 팩토리\GoodDesignWeb\SmartFactory\Views\Board\board_set_list.cshtml"
               Write(SmartFactory.Util.get_word.language_code(language, "title"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 37 "D:\OneDrive - (주)블루아이\02. 개발(대표)\15. 굿디자인 스마트 팩토리\GoodDesignWeb\SmartFactory\Views\Board\board_set_list.cshtml"
               Write(SmartFactory.Util.get_word.language_code(language, "Type"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 40 "D:\OneDrive - (주)블루아이\02. 개발(대표)\15. 굿디자인 스마트 팩토리\GoodDesignWeb\SmartFactory\Views\Board\board_set_list.cshtml"
               Write(SmartFactory.Util.get_word.language_code(language, "open"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 43 "D:\OneDrive - (주)블루아이\02. 개발(대표)\15. 굿디자인 스마트 팩토리\GoodDesignWeb\SmartFactory\Views\Board\board_set_list.cshtml"
               Write(SmartFactory.Util.get_word.language_code(language, "company"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 46 "D:\OneDrive - (주)블루아이\02. 개발(대표)\15. 굿디자인 스마트 팩토리\GoodDesignWeb\SmartFactory\Views\Board\board_set_list.cshtml"
               Write(SmartFactory.Util.get_word.language_code(language, "department"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    Type\r\n                </th>\r\n                <th class=\"check_auth\">");
#nullable restore
#line 51 "D:\OneDrive - (주)블루아이\02. 개발(대표)\15. 굿디자인 스마트 팩토리\GoodDesignWeb\SmartFactory\Views\Board\board_set_list.cshtml"
                                  Write(SmartFactory.Util.get_word.language_code(language, "edit"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 55 "D:\OneDrive - (주)블루아이\02. 개발(대표)\15. 굿디자인 스마트 팩토리\GoodDesignWeb\SmartFactory\Views\Board\board_set_list.cshtml"
             foreach (BoardMenu item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1584, "\"", 1620, 3);
            WriteAttributeValue("", 1591, "/sys/board_set?idx=", 1591, 19, true);
#nullable restore
#line 59 "D:\OneDrive - (주)블루아이\02. 개발(대표)\15. 굿디자인 스마트 팩토리\GoodDesignWeb\SmartFactory\Views\Board\board_set_list.cshtml"
WriteAttributeValue("", 1610, item.idx, 1610, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 1619, "", 1620, 1, true);
            EndWriteAttribute();
            WriteLiteral(">      ");
#nullable restore
#line 59 "D:\OneDrive - (주)블루아이\02. 개발(대표)\15. 굿디자인 스마트 팩토리\GoodDesignWeb\SmartFactory\Views\Board\board_set_list.cshtml"
                                                                 Write(Html.DisplayFor(modelItem => item.title));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                    </td>\r\n                    <td>\r\n");
#nullable restore
#line 62 "D:\OneDrive - (주)블루아이\02. 개발(대표)\15. 굿디자인 스마트 팩토리\GoodDesignWeb\SmartFactory\Views\Board\board_set_list.cshtml"
                           get_type(item.BoardType_idx); 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                    </td>\r\n\r\n                    <td>\r\n                        ");
#nullable restore
#line 68 "D:\OneDrive - (주)블루아이\02. 개발(대표)\15. 굿디자인 스마트 팩토리\GoodDesignWeb\SmartFactory\Views\Board\board_set_list.cshtml"
                   Write(Html.DisplayFor(modelItem => item.open_yn));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n\r\n                    <td>\r\n\r\n\r\n");
#nullable restore
#line 74 "D:\OneDrive - (주)블루아이\02. 개발(대표)\15. 굿디자인 스마트 팩토리\GoodDesignWeb\SmartFactory\Views\Board\board_set_list.cshtml"
                           get_comany(item.company_idx); 

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n\r\n                    <td>\r\n");
#nullable restore
#line 78 "D:\OneDrive - (주)블루아이\02. 개발(대표)\15. 굿디자인 스마트 팩토리\GoodDesignWeb\SmartFactory\Views\Board\board_set_list.cshtml"
                           get_department(item.department_idx); 

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n\r\n\r\n                    <td>\r\n                        ");
#nullable restore
#line 83 "D:\OneDrive - (주)블루아이\02. 개발(대표)\15. 굿디자인 스마트 팩토리\GoodDesignWeb\SmartFactory\Views\Board\board_set_list.cshtml"
                   Write(Html.DisplayFor(modelItem => item.BoardType_idxNavigation.code_name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        <span type=\"button\" rel=\"tooltip\" title=\"Edit Task\" class=\"btn btn-info btn-simple btn-xs\">\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 2509, "\"", 2547, 3);
            WriteAttributeValue("", 2516, "/board/board_set?idx=", 2516, 21, true);
#nullable restore
#line 87 "D:\OneDrive - (주)블루아이\02. 개발(대표)\15. 굿디자인 스마트 팩토리\GoodDesignWeb\SmartFactory\Views\Board\board_set_list.cshtml"
WriteAttributeValue("", 2537, item.idx, 2537, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 2546, "", 2547, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3e2127a8d8764a91448ee8309377dc7ac9b83d3712772", async() => {
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
            WriteLiteral("\r\n                            </a>\r\n                        </span>\r\n                        <span type=\"button\" rel=\"tooltip\" title=\"Remove\" class=\"btn btn-danger btn-simple btn-xs\">\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 2847, "\"", 2903, 3);
            WriteAttributeValue("", 2854, "/board/board_set_action?idx=", 2854, 28, true);
#nullable restore
#line 94 "D:\OneDrive - (주)블루아이\02. 개발(대표)\15. 굿디자인 스마트 팩토리\GoodDesignWeb\SmartFactory\Views\Board\board_set_list.cshtml"
WriteAttributeValue("", 2882, item.idx, 2882, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2891, "&mode_type=D", 2891, 12, true);
            EndWriteAttribute();
            WriteLiteral(">  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3e2127a8d8764a91448ee8309377dc7ac9b83d3714591", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</a>\r\n                        </span>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 98 "D:\OneDrive - (주)블루아이\02. 개발(대표)\15. 굿디자인 스마트 팩토리\GoodDesignWeb\SmartFactory\Views\Board\board_set_list.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </tbody>
    </table>
    <fieldset>
        <div class=""form-group check_auth"">
            <div class=""col-md-12"" style=""display: table; margin: 20px; text-align: center;"">
                <div class=""btn btn-default btn-fill btn-wd   btn-info"" onclick=""go('board_set') "">

                    ");
#nullable restore
#line 106 "D:\OneDrive - (주)블루아이\02. 개발(대표)\15. 굿디자인 스마트 팩토리\GoodDesignWeb\SmartFactory\Views\Board\board_set_list.cshtml"
               Write(SmartFactory.Util.get_word.language_code(language, "create"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </fieldset>\r\n</div>\r\n\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
#nullable restore
#line 115 "D:\OneDrive - (주)블루아이\02. 개발(대표)\15. 굿디자인 스마트 팩토리\GoodDesignWeb\SmartFactory\Views\Board\board_set_list.cshtml"
           

    db_e db = new db_e();

    public void get_comany(int _code)
    {


        var _name = (from a in db.company where a.idx == _code select a.company_name).FirstOrDefault() ?? "";

#line default
#line hidden
#nullable disable
        WriteLiteral("        <span>");
#nullable restore
#line 124 "D:\OneDrive - (주)블루아이\02. 개발(대표)\15. 굿디자인 스마트 팩토리\GoodDesignWeb\SmartFactory\Views\Board\board_set_list.cshtml"
         Write(_name);

#line default
#line hidden
#nullable disable
        WriteLiteral("</span>\r\n");
#nullable restore
#line 125 "D:\OneDrive - (주)블루아이\02. 개발(대표)\15. 굿디자인 스마트 팩토리\GoodDesignWeb\SmartFactory\Views\Board\board_set_list.cshtml"
    }

    public void get_department(int _code)
    {



        var _name = (from a in db.department where a.idx == _code select a.department_name).FirstOrDefault() ?? "";

#line default
#line hidden
#nullable disable
        WriteLiteral("        <span>");
#nullable restore
#line 133 "D:\OneDrive - (주)블루아이\02. 개발(대표)\15. 굿디자인 스마트 팩토리\GoodDesignWeb\SmartFactory\Views\Board\board_set_list.cshtml"
         Write(_name);

#line default
#line hidden
#nullable disable
        WriteLiteral("</span>\r\n");
#nullable restore
#line 134 "D:\OneDrive - (주)블루아이\02. 개발(대표)\15. 굿디자인 스마트 팩토리\GoodDesignWeb\SmartFactory\Views\Board\board_set_list.cshtml"
    }

    public void get_type(int _code)
    {



        var _name = (from a in db.BoardCode where a.code_id == _code select a.code_name).FirstOrDefault() ?? "";

#line default
#line hidden
#nullable disable
        WriteLiteral("        <span>");
#nullable restore
#line 142 "D:\OneDrive - (주)블루아이\02. 개발(대표)\15. 굿디자인 스마트 팩토리\GoodDesignWeb\SmartFactory\Views\Board\board_set_list.cshtml"
         Write(_name);

#line default
#line hidden
#nullable disable
        WriteLiteral("</span>\r\n");
#nullable restore
#line 143 "D:\OneDrive - (주)블루아이\02. 개발(대표)\15. 굿디자인 스마트 팩토리\GoodDesignWeb\SmartFactory\Views\Board\board_set_list.cshtml"
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SmartFactory.Models.BoardMenu>> Html { get; private set; }
    }
}
#pragma warning restore 1591
