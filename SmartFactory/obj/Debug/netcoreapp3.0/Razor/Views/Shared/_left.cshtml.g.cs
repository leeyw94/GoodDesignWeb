#pragma checksum "E:\00. 프로젝트 홈작업\00. GoodDesign SmarFactory Web\GoodDesignWeb\SmartFactory\Views\Shared\_left.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6ad264d2815f686ea336333bce51681a222cbddc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__left), @"mvc.1.0.view", @"/Views/Shared/_left.cshtml")]
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
#line 1 "E:\00. 프로젝트 홈작업\00. GoodDesign SmarFactory Web\GoodDesignWeb\SmartFactory\Views\Shared\_left.cshtml"
using SmartFactory.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ad264d2815f686ea336333bce51681a222cbddc", @"/Views/Shared/_left.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43cafef1091a06e312061635e1c5144488eda768", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__left : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\00. 프로젝트 홈작업\00. GoodDesign SmarFactory Web\GoodDesignWeb\SmartFactory\Views\Shared\_left.cshtml"
  


    // 선택된 메뉴 스타일 ========================================================



    string mode_type = Context.Request.Query["mode"];






#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"sidebar\" data-color=\"");
#nullable restore
#line 17 "E:\00. 프로젝트 홈작업\00. GoodDesign SmarFactory Web\GoodDesignWeb\SmartFactory\Views\Shared\_left.cshtml"
                                   bg_get(User.Identity.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""" data-image=""/images/sample.jpg"">
    <div class=""logo"" style=""height:59px;"">
        <a href=""/home/index"">

            <div class=""simple-text"" style=""padding:0"">GoodDesign</div>
            <div style=""font-size:11px;color:#dbdbdb;text-align:center "">SMARTFACTORY </div>
        </a>
    </div>
    <div class=""logo logo-mini"">
        <a href=""/"">
            <div class=""simple-text"" style=""font-size: 0.9em"">MENU</div>
        </a>
    </div>
    <div class=""sidebar-wrapper"">
");
#nullable restore
#line 31 "E:\00. 프로젝트 홈작업\00. GoodDesign SmarFactory Web\GoodDesignWeb\SmartFactory\Views\Shared\_left.cshtml"
          get_class();

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n\r\n</div>\r\n\r\n<script type=\"text/javascript\">\r\n\r\n\r\n    function logout() {\r\n\r\n        $(\"#form_login\").submit();\r\n    }\r\n\r\n\r\n</script>\r\n\r\n");
            WriteLiteral("\r\n\r\n");
        }
        #pragma warning restore 1998
#nullable restore
#line 48 "E:\00. 프로젝트 홈작업\00. GoodDesign SmarFactory Web\GoodDesignWeb\SmartFactory\Views\Shared\_left.cshtml"
            
 

    public void bg_get(string user_id)
    {
        string bg_style = "azure";
         var db = new db_e();
        
        bg_style = (from a in db.user where a.user_id == user_id select a.main_bg_color).FirstOrDefault();


        

#line default
#line hidden
#nullable disable
#nullable restore
#line 59 "E:\00. 프로젝트 홈작업\00. GoodDesign SmarFactory Web\GoodDesignWeb\SmartFactory\Views\Shared\_left.cshtml"
         Write(bg_style);

#line default
#line hidden
#nullable disable
#nullable restore
#line 59 "E:\00. 프로젝트 홈작업\00. GoodDesign SmarFactory Web\GoodDesignWeb\SmartFactory\Views\Shared\_left.cshtml"
                              

    }

    public void get_class()
    {
        string urlcheck = Context.Request.Path;
        string page_name = "";

        try
        {
            page_name = urlcheck.Split('/')[2];
        }
        catch
        {
            page_name = "";
        }

        var db = new db_e();
        string web_user_id = User.Identity.Name ?? "";




        string user_auth = (from a in db.user where a.user_id == web_user_id select a.department_idxNavigation.department_auth).FirstOrDefault() ?? "";


        List<CategoryMenus>
        data = (from a in db.CategoryMenus
                where user_auth.Contains(a.step_auth)
                select a).OrderBy(o => o.step_orderby).ToList();

        string nav_class = "";



#line default
#line hidden
#nullable disable
        WriteLiteral("        <ul class=\"nav\">\r\n\r\n");
#nullable restore
#line 96 "E:\00. 프로젝트 홈작업\00. GoodDesign SmarFactory Web\GoodDesignWeb\SmartFactory\Views\Shared\_left.cshtml"
             foreach (CategoryMenus item in data)
            {
                if (item.step_url2 == page_name)
                {
                    nav_class = "active";
                }
                else
                {
                    nav_class = "";
                }


                if (item.step_dept == 1)
                {

#line default
#line hidden
#nullable disable
        WriteLiteral("                    <li");
        BeginWriteAttribute("class", " class=\"", 2387, "\"", 2413, 2);
#nullable restore
#line 110 "E:\00. 프로젝트 홈작업\00. GoodDesign SmarFactory Web\GoodDesignWeb\SmartFactory\Views\Shared\_left.cshtml"
WriteAttributeValue("", 2395, nav_class, 2395, 10, false);

#line default
#line hidden
#nullable disable
        WriteAttributeValue(" ", 2405, "loading", 2406, 8, true);
        EndWriteAttribute();
        WriteLiteral(">\r\n                        <a");
        BeginWriteAttribute("href", " href=\"", 2443, "\"", 2482, 4);
        WriteAttributeValue("", 2450, "/", 2450, 1, true);
#nullable restore
#line 111 "E:\00. 프로젝트 홈작업\00. GoodDesign SmarFactory Web\GoodDesignWeb\SmartFactory\Views\Shared\_left.cshtml"
WriteAttributeValue("", 2451, item.step_url1, 2451, 15, false);

#line default
#line hidden
#nullable disable
        WriteAttributeValue("", 2466, "/", 2466, 1, true);
#nullable restore
#line 111 "E:\00. 프로젝트 홈작업\00. GoodDesign SmarFactory Web\GoodDesignWeb\SmartFactory\Views\Shared\_left.cshtml"
WriteAttributeValue("", 2467, item.step_url2, 2467, 15, false);

#line default
#line hidden
#nullable disable
        EndWriteAttribute();
        WriteLiteral(">\r\n                            <i");
        BeginWriteAttribute("class", " class=\"", 2516, "\"", 2539, 1);
#nullable restore
#line 112 "E:\00. 프로젝트 홈작업\00. GoodDesign SmarFactory Web\GoodDesignWeb\SmartFactory\Views\Shared\_left.cshtml"
WriteAttributeValue("", 2524, item.step_icon, 2524, 15, false);

#line default
#line hidden
#nullable disable
        EndWriteAttribute();
        WriteLiteral("></i>\r\n                            <p>");
#nullable restore
#line 113 "E:\00. 프로젝트 홈작업\00. GoodDesign SmarFactory Web\GoodDesignWeb\SmartFactory\Views\Shared\_left.cshtml"
                          Write(item.step_name);

#line default
#line hidden
#nullable disable
        WriteLiteral("   </p>\r\n\r\n                        </a>\r\n                    </li>\r\n");
#nullable restore
#line 117 "E:\00. 프로젝트 홈작업\00. GoodDesign SmarFactory Web\GoodDesignWeb\SmartFactory\Views\Shared\_left.cshtml"
                }
                if (item.step_dept == 2)
                {
                    string h_id = item.step_url1 + item.step_url2;

#line default
#line hidden
#nullable disable
        WriteLiteral("                    <li>\r\n\r\n                        <a data-toggle=\"collapse\"");
        BeginWriteAttribute("href", " href=\"", 2886, "\"", 2924, 3);
        WriteAttributeValue("", 2893, "#", 2893, 1, true);
#nullable restore
#line 123 "E:\00. 프로젝트 홈작업\00. GoodDesign SmarFactory Web\GoodDesignWeb\SmartFactory\Views\Shared\_left.cshtml"
WriteAttributeValue("", 2894, item.step_url1, 2894, 15, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 123 "E:\00. 프로젝트 홈작업\00. GoodDesign SmarFactory Web\GoodDesignWeb\SmartFactory\Views\Shared\_left.cshtml"
WriteAttributeValue("", 2909, item.step_url2, 2909, 15, false);

#line default
#line hidden
#nullable disable
        EndWriteAttribute();
        WriteLiteral(">\r\n\r\n                            <i");
        BeginWriteAttribute("class", " class=\"", 2960, "\"", 2983, 1);
#nullable restore
#line 125 "E:\00. 프로젝트 홈작업\00. GoodDesign SmarFactory Web\GoodDesignWeb\SmartFactory\Views\Shared\_left.cshtml"
WriteAttributeValue("", 2968, item.step_icon, 2968, 15, false);

#line default
#line hidden
#nullable disable
        EndWriteAttribute();
        WriteLiteral("></i>\r\n                            <p>\r\n                                ");
#nullable restore
#line 127 "E:\00. 프로젝트 홈작업\00. GoodDesign SmarFactory Web\GoodDesignWeb\SmartFactory\Views\Shared\_left.cshtml"
                           Write(item.step_name);

#line default
#line hidden
#nullable disable
        WriteLiteral("\r\n                                <b class=\"caret\"></b>\r\n                            </p>\r\n                        </a>\r\n");
#nullable restore
#line 131 "E:\00. 프로젝트 홈작업\00. GoodDesign SmarFactory Web\GoodDesignWeb\SmartFactory\Views\Shared\_left.cshtml"
                          sub_page(item.step_index, h_id);

#line default
#line hidden
#nullable disable
        WriteLiteral("\r\n                    </li>\r\n");
#nullable restore
#line 134 "E:\00. 프로젝트 홈작업\00. GoodDesign SmarFactory Web\GoodDesignWeb\SmartFactory\Views\Shared\_left.cshtml"
                }
            }

#line default
#line hidden
#nullable disable
        WriteLiteral("\r\n\r\n\r\n        </ul>\r\n");
#nullable restore
#line 140 "E:\00. 프로젝트 홈작업\00. GoodDesign SmarFactory Web\GoodDesignWeb\SmartFactory\Views\Shared\_left.cshtml"
    }



    public void sub_page(string step_index, string h_id)
    {
        var db = new db_e();


        List<CategoryMenus>
            list = (from a in db.CategoryMenus where a.step_index == step_index && a.step_dept == 3 select a).OrderBy(o => o.step_orderby).ToList();


#line default
#line hidden
#nullable disable
        WriteLiteral("        <div class=\"collapse\"");
        BeginWriteAttribute("id", " id=\"", 3659, "\"", 3669, 1);
#nullable restore
#line 152 "E:\00. 프로젝트 홈작업\00. GoodDesign SmarFactory Web\GoodDesignWeb\SmartFactory\Views\Shared\_left.cshtml"
WriteAttributeValue("", 3664, h_id, 3664, 5, false);

#line default
#line hidden
#nullable disable
        EndWriteAttribute();
        WriteLiteral(">\r\n            <ul class=\"nav\">\r\n\r\n");
#nullable restore
#line 155 "E:\00. 프로젝트 홈작업\00. GoodDesign SmarFactory Web\GoodDesignWeb\SmartFactory\Views\Shared\_left.cshtml"
                 foreach (CategoryMenus item in list)
                {

#line default
#line hidden
#nullable disable
        WriteLiteral("                    <li>\r\n                        <a");
        BeginWriteAttribute("href", " href=\"", 3831, "\"", 3870, 4);
        WriteAttributeValue("", 3838, "/", 3838, 1, true);
#nullable restore
#line 158 "E:\00. 프로젝트 홈작업\00. GoodDesign SmarFactory Web\GoodDesignWeb\SmartFactory\Views\Shared\_left.cshtml"
WriteAttributeValue("", 3839, item.step_url1, 3839, 15, false);

#line default
#line hidden
#nullable disable
        WriteAttributeValue("", 3854, "/", 3854, 1, true);
#nullable restore
#line 158 "E:\00. 프로젝트 홈작업\00. GoodDesign SmarFactory Web\GoodDesignWeb\SmartFactory\Views\Shared\_left.cshtml"
WriteAttributeValue("", 3855, item.step_url2, 3855, 15, false);

#line default
#line hidden
#nullable disable
        EndWriteAttribute();
        WriteLiteral(" class=\"loading\">\r\n                            <i");
        BeginWriteAttribute("class", " class=\"", 3920, "\"", 3943, 1);
#nullable restore
#line 159 "E:\00. 프로젝트 홈작업\00. GoodDesign SmarFactory Web\GoodDesignWeb\SmartFactory\Views\Shared\_left.cshtml"
WriteAttributeValue("", 3928, item.step_icon, 3928, 15, false);

#line default
#line hidden
#nullable disable
        EndWriteAttribute();
        WriteLiteral("></i>\r\n                            <p>");
#nullable restore
#line 160 "E:\00. 프로젝트 홈작업\00. GoodDesign SmarFactory Web\GoodDesignWeb\SmartFactory\Views\Shared\_left.cshtml"
                          Write(item.step_name);

#line default
#line hidden
#nullable disable
        WriteLiteral("</p>\r\n                        </a>\r\n                    </li>\r\n");
#nullable restore
#line 163 "E:\00. 프로젝트 홈작업\00. GoodDesign SmarFactory Web\GoodDesignWeb\SmartFactory\Views\Shared\_left.cshtml"
                }

#line default
#line hidden
#nullable disable
        WriteLiteral("\r\n            </ul>\r\n        </div>\r\n");
#nullable restore
#line 167 "E:\00. 프로젝트 홈작업\00. GoodDesign SmarFactory Web\GoodDesignWeb\SmartFactory\Views\Shared\_left.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
