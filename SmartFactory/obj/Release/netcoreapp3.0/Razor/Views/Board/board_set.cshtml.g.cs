#pragma checksum "F:\공유폴더\04. 이용우\00. GoodDesign SmarFactory Web\GoodDesignWeb\SmartFactory\Views\Board\board_set.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a1492ab5c786cef4dd5fad1151d85acc2345e5b4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Board_board_set), @"mvc.1.0.view", @"/Views/Board/board_set.cshtml")]
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
#line 1 "F:\공유폴더\04. 이용우\00. GoodDesign SmarFactory Web\GoodDesignWeb\SmartFactory\Views\_ViewImports.cshtml"
using SmartFactory;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\공유폴더\04. 이용우\00. GoodDesign SmarFactory Web\GoodDesignWeb\SmartFactory\Views\_ViewImports.cshtml"
using SmartFactory.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1492ab5c786cef4dd5fad1151d85acc2345e5b4", @"/Views/Board/board_set.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43cafef1091a06e312061635e1c5144488eda768", @"/Views/_ViewImports.cshtml")]
    public class Views_Board_board_set : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SmartFactory.Models.BoardMenu>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "~/Views/sys/setting_menu.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("~/Board/board_set_action"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("form1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "F:\공유폴더\04. 이용우\00. GoodDesign SmarFactory Web\GoodDesignWeb\SmartFactory\Views\Board\board_set.cshtml"
  

    string Mode = "i";
    string idx = Context.Request.Query["idx"];
    if (string.IsNullOrEmpty(idx))
    {
        Mode = "i";
    }
    else
    {
        Mode = "e";
    }


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 17 "F:\공유폴더\04. 이용우\00. GoodDesign SmarFactory Web\GoodDesignWeb\SmartFactory\Views\Board\board_set.cshtml"
  string language = "korea";

    try
    {
        language = Context.Request.Cookies["language"] ?? "korea";

    }
    catch
    {


    }



 string company_idx = Context.Request.Query["company_idx"];

 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a1492ab5c786cef4dd5fad1151d85acc2345e5b46174", async() => {
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
            WriteLiteral("\r\n<div class=\"container sub_page\">\r\n\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a1492ab5c786cef4dd5fad1151d85acc2345e5b47340", async() => {
                WriteLiteral("\r\n\r\n\r\n        <input type=\"hidden\" name=\"idx\" id=\"idx\"");
                BeginWriteAttribute("value", " value=\"", 712, "\"", 724, 1);
#nullable restore
#line 44 "F:\공유폴더\04. 이용우\00. GoodDesign SmarFactory Web\GoodDesignWeb\SmartFactory\Views\Board\board_set.cshtml"
WriteAttributeValue("", 720, idx, 720, 4, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n\r\n        ");
#nullable restore
#line 46 "F:\공유폴더\04. 이용우\00. GoodDesign SmarFactory Web\GoodDesignWeb\SmartFactory\Views\Board\board_set.cshtml"
   Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        <div class=\"form-horizontal\">\r\n\r\n            <div class=\"sub_title_black\">\r\n                ");
#nullable restore
#line 50 "F:\공유폴더\04. 이용우\00. GoodDesign SmarFactory Web\GoodDesignWeb\SmartFactory\Views\Board\board_set.cshtml"
           Write(SmartFactory.Util.get_word.language_code(language, "boardsetting"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n\r\n            <hr />\r\n\r\n            ");
#nullable restore
#line 55 "F:\공유폴더\04. 이용우\00. GoodDesign SmarFactory Web\GoodDesignWeb\SmartFactory\Views\Board\board_set.cshtml"
       Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n\r\n\r\n            <div class=\"form-group\">\r\n                <label class=\"col-sm-2 control-label\"> ");
#nullable restore
#line 60 "F:\공유폴더\04. 이용우\00. GoodDesign SmarFactory Web\GoodDesignWeb\SmartFactory\Views\Board\board_set.cshtml"
                                                  Write(SmartFactory.Util.get_word.language_code(language, "company"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                <div class=\"col-md-4\">\r\n                    ");
#nullable restore
#line 62 "F:\공유폴더\04. 이용우\00. GoodDesign SmarFactory Web\GoodDesignWeb\SmartFactory\Views\Board\board_set.cshtml"
               Write(Html.DropDownList("company_idx", (SelectList)ViewBag.회사, new { @class = "selectpicker", @onchange = "search_it()" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                </div>\r\n            </div>\r\n\r\n");
#nullable restore
#line 67 "F:\공유폴더\04. 이용우\00. GoodDesign SmarFactory Web\GoodDesignWeb\SmartFactory\Views\Board\board_set.cshtml"
             if (!string.IsNullOrEmpty(company_idx) && company_idx != "0")
            {


#line default
#line hidden
#nullable disable
                WriteLiteral("                <div class=\"form-group\">\r\n                    <label class=\"col-sm-2 control-label\"> ");
#nullable restore
#line 71 "F:\공유폴더\04. 이용우\00. GoodDesign SmarFactory Web\GoodDesignWeb\SmartFactory\Views\Board\board_set.cshtml"
                                                      Write(SmartFactory.Util.get_word.language_code(language, "department"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                    <div class=\"col-md-4\">\r\n                        ");
#nullable restore
#line 73 "F:\공유폴더\04. 이용우\00. GoodDesign SmarFactory Web\GoodDesignWeb\SmartFactory\Views\Board\board_set.cshtml"
                   Write(Html.DropDownList("department_idx", (SelectList)ViewBag.부서, new { @class = "selectpicker" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 77 "F:\공유폴더\04. 이용우\00. GoodDesign SmarFactory Web\GoodDesignWeb\SmartFactory\Views\Board\board_set.cshtml"

            }
            else
            {


#line default
#line hidden
#nullable disable
                WriteLiteral("                <input type=\"hidden\" name=\"department_idx\" value=\"0\" />\r\n");
#nullable restore
#line 83 "F:\공유폴더\04. 이용우\00. GoodDesign SmarFactory Web\GoodDesignWeb\SmartFactory\Views\Board\board_set.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            <div class=\"form-group\">\r\n                <label class=\"col-sm-2 control-label\"> ");
#nullable restore
#line 86 "F:\공유폴더\04. 이용우\00. GoodDesign SmarFactory Web\GoodDesignWeb\SmartFactory\Views\Board\board_set.cshtml"
                                                  Write(SmartFactory.Util.get_word.language_code(language, "title"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                <div class=\"col-md-4\">\r\n                    ");
#nullable restore
#line 88 "F:\공유폴더\04. 이용우\00. GoodDesign SmarFactory Web\GoodDesignWeb\SmartFactory\Views\Board\board_set.cshtml"
               Write(Html.EditorFor(model => model.title, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"form-group\">\r\n                <label class=\"col-sm-2 control-label\"> ");
#nullable restore
#line 94 "F:\공유폴더\04. 이용우\00. GoodDesign SmarFactory Web\GoodDesignWeb\SmartFactory\Views\Board\board_set.cshtml"
                                                  Write(SmartFactory.Util.get_word.language_code(language, "Type"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                <div class=\"col-md-4\">\r\n                    ");
#nullable restore
#line 96 "F:\공유폴더\04. 이용우\00. GoodDesign SmarFactory Web\GoodDesignWeb\SmartFactory\Views\Board\board_set.cshtml"
               Write(Html.DropDownList("BoardType_idx", (SelectList)ViewBag.게시판코드, new { @class = "selectpicker" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                </div>\r\n            </div>\r\n\r\n\r\n\r\n\r\n            <hr />\r\n            <div class=\"form-group\">\r\n                <label class=\"col-sm-2 control-label\"> ");
#nullable restore
#line 106 "F:\공유폴더\04. 이용우\00. GoodDesign SmarFactory Web\GoodDesignWeb\SmartFactory\Views\Board\board_set.cshtml"
                                                  Write(SmartFactory.Util.get_word.language_code(language, "open"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</label>
                <div class=""col-md-2"" style=""padding-top: 7px"">
                    <input type=""checkbox"" id=""open_yn"" name=""open_yn"" data-toggle=""switch"" />
                </div>



            </div>
            <hr />





            <fieldset>
                <div class=""form-group"">
                    <div class=""col-md-12"" style=""display: table; margin: 20px; text-align: center;"">
                        <div class=""btn btn-default btn-fill btn-wd   btn-info"" onclick="" save_it() "">
                            ");
#nullable restore
#line 124 "F:\공유폴더\04. 이용우\00. GoodDesign SmarFactory Web\GoodDesignWeb\SmartFactory\Views\Board\board_set.cshtml"
                       Write(SmartFactory.Util.get_word.language_code(language, "save"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </div>\r\n\r\n\r\n                        <div class=\"btn btn-default btn-fill btn-wd   btn-default\" onclick=\"go(\'board_set_list\') \">\r\n\r\n                            ");
#nullable restore
#line 130 "F:\공유폴더\04. 이용우\00. GoodDesign SmarFactory Web\GoodDesignWeb\SmartFactory\Views\Board\board_set.cshtml"
                       Write(SmartFactory.Util.get_word.language_code(language, "backtolist"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </fieldset>\r\n        </div>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n</div>\r\n    <script type=\"text/javascript\">\r\n\r\n    $(document).ready(function() {\r\n\r\n        //공개 여부 시작\r\n\r\n        var _mode = \"");
#nullable restore
#line 149 "F:\공유폴더\04. 이용우\00. GoodDesign SmarFactory Web\GoodDesignWeb\SmartFactory\Views\Board\board_set.cshtml"
                Write(Mode);

#line default
#line hidden
#nullable disable
            WriteLiteral("\";\r\n        var yn = \"");
#nullable restore
#line 150 "F:\공유폴더\04. 이용우\00. GoodDesign SmarFactory Web\GoodDesignWeb\SmartFactory\Views\Board\board_set.cshtml"
             Write(Model.open_yn);

#line default
#line hidden
#nullable disable
            WriteLiteral("\";\r\n        var BM_type = \"");
#nullable restore
#line 151 "F:\공유폴더\04. 이용우\00. GoodDesign SmarFactory Web\GoodDesignWeb\SmartFactory\Views\Board\board_set.cshtml"
                  Write(Model.BoardType_idx);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""";
        use_yn(""open_yn"", yn);


        if (_mode == ""e"") {

            $(""input[name=BM_type][value='"" + BM_type + ""']"").prop(""checked"", true);
        }
        else {
            $(""#open_yn"").attr(""checked"", true);
        }


        //공개 여부 끝
    });

    function use_yn(_id, yn) {

        var _mode = """);
#nullable restore
#line 169 "F:\공유폴더\04. 이용우\00. GoodDesign SmarFactory Web\GoodDesignWeb\SmartFactory\Views\Board\board_set.cshtml"
                Write(Mode);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""";

        var use_yn = $(""#"" + _id).val();

        if (_mode == ""e"") {

            if (yn == ""Y"") {
                $(""#"" + _id).attr(""checked"", true);
            } else {
                $(""#"" + _id).attr(""checked"", false);
            }

        }

    }

    function save_it() {
        check(""BM_title"", ""form1"");

    }

    function search_it() {
        var company_idx = $(""#company_idx"").val();

        location.href = ""/board/board_set?company_idx="" + company_idx;

    }
    </script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SmartFactory.Models.BoardMenu> Html { get; private set; }
    }
}
#pragma warning restore 1591
