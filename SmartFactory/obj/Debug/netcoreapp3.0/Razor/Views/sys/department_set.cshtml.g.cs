#pragma checksum "E:\00. 프로젝트 홈작업\00. GoodDesign SmarFactory Web\GoodDesignWeb4 (2) (2)\SmartFactory\Views\sys\department_set.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "11e3ebb2b6cfb9ab4ffa57378c48b09244c1a71a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_sys_department_set), @"mvc.1.0.view", @"/Views/sys/department_set.cshtml")]
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
#line 1 "E:\00. 프로젝트 홈작업\00. GoodDesign SmarFactory Web\GoodDesignWeb4 (2) (2)\SmartFactory\Views\_ViewImports.cshtml"
using SmartFactory;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\00. 프로젝트 홈작업\00. GoodDesign SmarFactory Web\GoodDesignWeb4 (2) (2)\SmartFactory\Views\_ViewImports.cshtml"
using SmartFactory.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"11e3ebb2b6cfb9ab4ffa57378c48b09244c1a71a", @"/Views/sys/department_set.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43cafef1091a06e312061635e1c5144488eda768", @"/Views/_ViewImports.cshtml")]
    public class Views_sys_department_set : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SmartFactory.Models.department>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "~/Views/sys/setting_menu.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\00. 프로젝트 홈작업\00. GoodDesign SmarFactory Web\GoodDesignWeb4 (2) (2)\SmartFactory\Views\sys\department_set.cshtml"
  string language = Context.Request.Cookies["language"] ?? "korea"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "11e3ebb2b6cfb9ab4ffa57378c48b09244c1a71a3815", async() => {
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
            WriteLiteral("\r\n\r\n</div>\r\n\r\n<div class=\"container sub_page\">\r\n  \r\n\r\n                <div class=\"content\">\r\n");
#nullable restore
#line 13 "E:\00. 프로젝트 홈작업\00. GoodDesign SmarFactory Web\GoodDesignWeb4 (2) (2)\SmartFactory\Views\sys\department_set.cshtml"
                     using (Html.BeginForm("department_set_action", "sys", FormMethod.Post, new { enctype = "multipart/form-data", id = "form1", name = "form1" }))
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "E:\00. 프로젝트 홈작업\00. GoodDesign SmarFactory Web\GoodDesignWeb4 (2) (2)\SmartFactory\Views\sys\department_set.cshtml"
                   Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <input type=\"hidden\" name=\"idx\" id=\"idx\"");
            BeginWriteAttribute("value", " value=\"", 570, "\"", 607, 1);
#nullable restore
#line 17 "E:\00. 프로젝트 홈작업\00. GoodDesign SmarFactory Web\GoodDesignWeb4 (2) (2)\SmartFactory\Views\sys\department_set.cshtml"
WriteAttributeValue("", 578, Context.Request.Query["idx"], 578, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
            WriteLiteral("                        <div class=\"form-horizontal\">\r\n                            <div class=\"sub_title_black\">\r\n                                ");
#nullable restore
#line 21 "E:\00. 프로젝트 홈작업\00. GoodDesign SmarFactory Web\GoodDesignWeb4 (2) (2)\SmartFactory\Views\sys\department_set.cshtml"
                           Write(SmartFactory.Util.get_word.language_code(language, "department"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 21 "E:\00. 프로젝트 홈작업\00. GoodDesign SmarFactory Web\GoodDesignWeb4 (2) (2)\SmartFactory\Views\sys\department_set.cshtml"
                                                                                             Write(SmartFactory.Util.get_word.language_code(language, "setting"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                            <hr />\r\n\r\n                            <fieldset>\r\n                                <div class=\"form-group\">\r\n                                    <label class=\"col-sm-2 control-label\"> ");
#nullable restore
#line 27 "E:\00. 프로젝트 홈작업\00. GoodDesign SmarFactory Web\GoodDesignWeb4 (2) (2)\SmartFactory\Views\sys\department_set.cshtml"
                                                                      Write(SmartFactory.Util.get_word.language_code(language, "company"));

#line default
#line hidden
#nullable disable
            WriteLiteral("   ");
#nullable restore
#line 27 "E:\00. 프로젝트 홈작업\00. GoodDesign SmarFactory Web\GoodDesignWeb4 (2) (2)\SmartFactory\Views\sys\department_set.cshtml"
                                                                                                                                       Write(SmartFactory.Util.get_word.language_code(language, "select"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                                    <div class=\"col-md-4\">\r\n\r\n                                        ");
#nullable restore
#line 30 "E:\00. 프로젝트 홈작업\00. GoodDesign SmarFactory Web\GoodDesignWeb4 (2) (2)\SmartFactory\Views\sys\department_set.cshtml"
                                   Write(Html.DropDownList("company_idx", (SelectList)ViewBag.회사, new { @class = "selectpicker", @onchange = "show_list()" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                                    </div>


                                </div>

                            </fieldset>




                            <div class=""form-group"">
                                <label class=""col-sm-2 control-label""> ");
#nullable restore
#line 43 "E:\00. 프로젝트 홈작업\00. GoodDesign SmarFactory Web\GoodDesignWeb4 (2) (2)\SmartFactory\Views\sys\department_set.cshtml"
                                                                  Write(SmartFactory.Util.get_word.language_code(language, "department"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 43 "E:\00. 프로젝트 홈작업\00. GoodDesign SmarFactory Web\GoodDesignWeb4 (2) (2)\SmartFactory\Views\sys\department_set.cshtml"
                                                                                                                                    Write(SmartFactory.Util.get_word.language_code(language, "name"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                                <div class=\"col-md-6\">\r\n                                    ");
#nullable restore
#line 45 "E:\00. 프로젝트 홈작업\00. GoodDesign SmarFactory Web\GoodDesignWeb4 (2) (2)\SmartFactory\Views\sys\department_set.cshtml"
                               Write(Html.EditorFor(model => model.department_name, new { htmlAttributes = new { @class = "form-control", @required = "required" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                                </div>\r\n                            </div>\r\n\r\n");
            WriteLiteral(@"                            <div class=""form-group"" id=""auth_department"">
                                <label class=""col-sm-2 control-label"">Department Auth</label>
                                <div class=""col-md-6"" style=""margin-top: 8px; padding: 0px"">


");
#nullable restore
#line 67 "E:\00. 프로젝트 홈작업\00. GoodDesign SmarFactory Web\GoodDesignWeb4 (2) (2)\SmartFactory\Views\sys\department_set.cshtml"
                                      
                                        if (User.Identity.Name == "insstek")
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <table class=\"table table-hover table-striped\" style=\"display: table\">\r\n\r\n");
#nullable restore
#line 72 "E:\00. 프로젝트 홈작업\00. GoodDesign SmarFactory Web\GoodDesignWeb4 (2) (2)\SmartFactory\Views\sys\department_set.cshtml"
                                                 foreach (SelectListItem item in (SelectList)ViewBag.권한)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <tr>\r\n                                                        <td style=\"width: 20px;\"><input type=\'checkbox\' name=\'department_auth\'");
            BeginWriteAttribute("value", " value=\'", 3544, "\'", 3563, 1);
#nullable restore
#line 75 "E:\00. 프로젝트 홈작업\00. GoodDesign SmarFactory Web\GoodDesignWeb4 (2) (2)\SmartFactory\Views\sys\department_set.cshtml"
WriteAttributeValue("", 3552, item.Value, 3552, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"cursor: pointer\" onclick=\" checkit() \" /></td>\r\n                                                        <td>\r\n\r\n                                                            ");
#nullable restore
#line 78 "E:\00. 프로젝트 홈작업\00. GoodDesign SmarFactory Web\GoodDesignWeb4 (2) (2)\SmartFactory\Views\sys\department_set.cshtml"
                                                       Write(item.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                        </td>\r\n                                                    </tr>\r\n");
#nullable restore
#line 81 "E:\00. 프로젝트 홈작업\00. GoodDesign SmarFactory Web\GoodDesignWeb4 (2) (2)\SmartFactory\Views\sys\department_set.cshtml"
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </table>\r\n");
#nullable restore
#line 84 "E:\00. 프로젝트 홈작업\00. GoodDesign SmarFactory Web\GoodDesignWeb4 (2) (2)\SmartFactory\Views\sys\department_set.cshtml"
                                        }

                                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <input type=\"hidden\" name=\"department_auth_temp\" id=\"department_auth_temp\"");
            BeginWriteAttribute("value", " value=\"", 4179, "\"", 4209, 1);
#nullable restore
#line 87 "E:\00. 프로젝트 홈작업\00. GoodDesign SmarFactory Web\GoodDesignWeb4 (2) (2)\SmartFactory\Views\sys\department_set.cshtml"
WriteAttributeValue("", 4187, Model.department_auth, 4187, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                </div>\r\n\r\n\r\n\r\n                            </div>\r\n\r\n                            <hr />\r\n                            <div class=\"form-group\">\r\n                                <label class=\"col-sm-2 control-label\"> ");
#nullable restore
#line 96 "E:\00. 프로젝트 홈작업\00. GoodDesign SmarFactory Web\GoodDesignWeb4 (2) (2)\SmartFactory\Views\sys\department_set.cshtml"
                                                                  Write(SmartFactory.Util.get_word.language_code(language, "open"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </label>
                                <div class=""col-md-2"" style=""padding-top: 7px"" rel=""tooltip"" title=""전체 부서 공유"">
                                    <input type=""checkbox"" id=""use_yn"" name=""use_yn"" checked data-toggle=""switch"" />
                                </div>



                            </div>
                        </div>
                        <hr />
                        <fieldset>
                            <div class=""form-group check_auth"">
                                <div class=""col-md-10"" style=""display: table; margin: 20px; text-align: center;"">
                                    <div class=""btn btn-default btn-fill btn-wd   btn-info"" onclick=""save_it() "">
                                        ");
#nullable restore
#line 110 "E:\00. 프로젝트 홈작업\00. GoodDesign SmarFactory Web\GoodDesignWeb4 (2) (2)\SmartFactory\Views\sys\department_set.cshtml"
                                   Write(SmartFactory.Util.get_word.language_code(language, "save"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </div>\r\n\r\n\r\n\r\n                                    <div class=\"btn btn-default btn-fill btn-wd   btn-default\" onclick=\"go(\'/sys/department_set_list\') \">\r\n\r\n                                        ");
#nullable restore
#line 117 "E:\00. 프로젝트 홈작업\00. GoodDesign SmarFactory Web\GoodDesignWeb4 (2) (2)\SmartFactory\Views\sys\department_set.cshtml"
                                   Write(SmartFactory.Util.get_word.language_code(language, "backtolist"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                        </fieldset>\r\n");
#nullable restore
#line 123 "E:\00. 프로젝트 홈작업\00. GoodDesign SmarFactory Web\GoodDesignWeb4 (2) (2)\SmartFactory\Views\sys\department_set.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


                </div>
            
</div>


<script>

    function checkit() {

        //분류

        var n = """";
        $(""input[name=department_auth]"").each(function(i) {
            if (this.checked) {
                n += $(this).val() + "","";
            }
        });

        $(""#department_auth_temp"").attr(""value"", n);

    }

    function save_it() {

        check(""department_name"", ""form1"");


    }


    function change_it() {
        var it = $(""#company_id"").val();

        if (it != ""insstek"") {
            $(""#auth_department"").css(""display"", ""none"");
        } else {
            $(""#auth_department"").css(""display"", ""block"");
        }
    }

    $(document).ready(function() {
        //   demo.showNotification();
        // var auth_department = $(""#auth_department"").css(""display"",""none"");
        $(""#auth_department"").css(""display"", ""none"");
    });

    function show_list() {

        $(""#auth_department"").css(""display"", ""none"");
      ");
            WriteLiteral(@"  // 지역
        var auth_name = $(""#company_id"").val();


        if (auth_name == ""insstek"") {
            $(""#auth_department"").css(""display"", ""block"");
            $('input:checkbox[name=""department_auth""]').each(function() {

                var gubun_code = '");
#nullable restore
#line 184 "E:\00. 프로젝트 홈작업\00. GoodDesign SmarFactory Web\GoodDesignWeb4 (2) (2)\SmartFactory\Views\sys\department_set.cshtml"
                             Write(Model.department_auth);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"';

                var splitCode = gubun_code.split(',');


                for (var idx in splitCode) {
                    try {
                        $(""input[name=department_auth][value="" + splitCode[idx] + ""]"").attr(""checked"", true);

                    } catch(e) {
                        return;
                    }
                }
            });
        } else {
            $(""#auth_department"").css(""display"", ""none"");
        }

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SmartFactory.Models.department> Html { get; private set; }
    }
}
#pragma warning restore 1591
