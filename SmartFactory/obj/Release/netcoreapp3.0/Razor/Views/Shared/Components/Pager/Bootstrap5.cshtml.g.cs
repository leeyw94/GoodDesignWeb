#pragma checksum "E:\00. 프로젝트 홈작업\00. GoodDesign SmarFactory Web\GoodDesignWeb4 (2) (2)\SmartFactory\Views\Shared\Components\Pager\Bootstrap5.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "003abc5c10251e44c5ea2c01d2e6642b88b123fd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Pager_Bootstrap5), @"mvc.1.0.view", @"/Views/Shared/Components/Pager/Bootstrap5.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"003abc5c10251e44c5ea2c01d2e6642b88b123fd", @"/Views/Shared/Components/Pager/Bootstrap5.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43cafef1091a06e312061635e1c5144488eda768", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Pager_Bootstrap5 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ReflectionIT.Mvc.Paging.IPagingList>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "E:\00. 프로젝트 홈작업\00. GoodDesign SmarFactory Web\GoodDesignWeb4 (2) (2)\SmartFactory\Views\Shared\Components\Pager\Bootstrap5.cshtml"
  
    var start = this.Model.StartPageIndex;
    var stop = this.Model.StopPageIndex;

    string urlcheck = Context.Request.Path;
    string url_query = Context.Request.QueryString.ToString();
    string page_directory = urlcheck.Split('/')[1];
    string page_site = "xx";


    if (string.IsNullOrEmpty(url_query))
    {
        try
        {
           url_query = "?cate="+ViewBag.카테고리;

        }
        catch
        {
            url_query = "?cate=1";

        }
        
    }

    try
    {
        page_site = urlcheck.Split('/')[2] + url_query;
    }
    catch
    {
        page_site = "index";
    }





#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 44 "E:\00. 프로젝트 홈작업\00. GoodDesign SmarFactory Web\GoodDesignWeb4 (2) (2)\SmartFactory\Views\Shared\Components\Pager\Bootstrap5.cshtml"
 if (this.Model.PageCount > 1)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <ul class=\"pagination pagination-sm justify-content-end\">\r\n\r\n");
#nullable restore
#line 48 "E:\00. 프로젝트 홈작업\00. GoodDesign SmarFactory Web\GoodDesignWeb4 (2) (2)\SmartFactory\Views\Shared\Components\Pager\Bootstrap5.cshtml"
         if (start > 1)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"page-item\">\r\n");
#nullable restore
#line 51 "E:\00. 프로젝트 홈작업\00. GoodDesign SmarFactory Web\GoodDesignWeb4 (2) (2)\SmartFactory\Views\Shared\Components\Pager\Bootstrap5.cshtml"
                 if (page_site.Contains("page"))
                {
                    page_site = page_site.Replace("page=", "");

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <a");
            BeginWriteAttribute("href", " href=\"", 1074, "\"", 1098, 2);
#nullable restore
#line 54 "E:\00. 프로젝트 홈작업\00. GoodDesign SmarFactory Web\GoodDesignWeb4 (2) (2)\SmartFactory\Views\Shared\Components\Pager\Bootstrap5.cshtml"
WriteAttributeValue("", 1081, page_site, 1081, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1091, "&page=1", 1091, 7, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"page-link\" aria-label=\"First\">1</a>\r\n");
#nullable restore
#line 55 "E:\00. 프로젝트 홈작업\00. GoodDesign SmarFactory Web\GoodDesignWeb4 (2) (2)\SmartFactory\Views\Shared\Components\Pager\Bootstrap5.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <a");
            BeginWriteAttribute("href", " href=\"", 1226, "\"", 1250, 2);
#nullable restore
#line 58 "E:\00. 프로젝트 홈작업\00. GoodDesign SmarFactory Web\GoodDesignWeb4 (2) (2)\SmartFactory\Views\Shared\Components\Pager\Bootstrap5.cshtml"
WriteAttributeValue("", 1233, page_site, 1233, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1243, "&page=1", 1243, 7, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"page-link\" aria-label=\"First\">1</a>\r\n");
#nullable restore
#line 59 "E:\00. 프로젝트 홈작업\00. GoodDesign SmarFactory Web\GoodDesignWeb4 (2) (2)\SmartFactory\Views\Shared\Components\Pager\Bootstrap5.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </li>\r\n");
#nullable restore
#line 62 "E:\00. 프로젝트 홈작업\00. GoodDesign SmarFactory Web\GoodDesignWeb4 (2) (2)\SmartFactory\Views\Shared\Components\Pager\Bootstrap5.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 64 "E:\00. 프로젝트 홈작업\00. GoodDesign SmarFactory Web\GoodDesignWeb4 (2) (2)\SmartFactory\Views\Shared\Components\Pager\Bootstrap5.cshtml"
         if (this.Model.PageIndex > 1)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"page-item\">\r\n\r\n");
#nullable restore
#line 68 "E:\00. 프로젝트 홈작업\00. GoodDesign SmarFactory Web\GoodDesignWeb4 (2) (2)\SmartFactory\Views\Shared\Components\Pager\Bootstrap5.cshtml"
                 if (page_site.Contains("page"))
                {
                    page_site = page_site.Replace("page=", "");

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <a");
            BeginWriteAttribute("href", " href=\"", 1594, "\"", 1644, 3);
#nullable restore
#line 71 "E:\00. 프로젝트 홈작업\00. GoodDesign SmarFactory Web\GoodDesignWeb4 (2) (2)\SmartFactory\Views\Shared\Components\Pager\Bootstrap5.cshtml"
WriteAttributeValue("", 1601, page_site, 1601, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1611, "&page=", 1611, 6, true);
#nullable restore
#line 71 "E:\00. 프로젝트 홈작업\00. GoodDesign SmarFactory Web\GoodDesignWeb4 (2) (2)\SmartFactory\Views\Shared\Components\Pager\Bootstrap5.cshtml"
WriteAttributeValue("", 1617, this.Model.PageIndex - 1, 1617, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"page-link\" aria-label=\"Previous\">  <span aria-hidden=\"true\">&laquo;</span></a>\r\n");
#nullable restore
#line 72 "E:\00. 프로젝트 홈작업\00. GoodDesign SmarFactory Web\GoodDesignWeb4 (2) (2)\SmartFactory\Views\Shared\Components\Pager\Bootstrap5.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <a");
            BeginWriteAttribute("href", " href=\"", 1815, "\"", 1865, 3);
#nullable restore
#line 75 "E:\00. 프로젝트 홈작업\00. GoodDesign SmarFactory Web\GoodDesignWeb4 (2) (2)\SmartFactory\Views\Shared\Components\Pager\Bootstrap5.cshtml"
WriteAttributeValue("", 1822, page_site, 1822, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1832, "&page=", 1832, 6, true);
#nullable restore
#line 75 "E:\00. 프로젝트 홈작업\00. GoodDesign SmarFactory Web\GoodDesignWeb4 (2) (2)\SmartFactory\Views\Shared\Components\Pager\Bootstrap5.cshtml"
WriteAttributeValue("", 1838, this.Model.PageIndex - 1, 1838, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"page-link\" aria-label=\"Previous\">  <span aria-hidden=\"true\">&laquo;</span></a>\r\n");
#nullable restore
#line 76 "E:\00. 프로젝트 홈작업\00. GoodDesign SmarFactory Web\GoodDesignWeb4 (2) (2)\SmartFactory\Views\Shared\Components\Pager\Bootstrap5.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n            </li>\r\n");
#nullable restore
#line 82 "E:\00. 프로젝트 홈작업\00. GoodDesign SmarFactory Web\GoodDesignWeb4 (2) (2)\SmartFactory\Views\Shared\Components\Pager\Bootstrap5.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 84 "E:\00. 프로젝트 홈작업\00. GoodDesign SmarFactory Web\GoodDesignWeb4 (2) (2)\SmartFactory\Views\Shared\Components\Pager\Bootstrap5.cshtml"
         for (int i = start; i <= stop; i++)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li");
            BeginWriteAttribute("class", " class=\"", 2085, "\"", 2146, 2);
            WriteAttributeValue("", 2093, "page-item", 2093, 9, true);
#nullable restore
#line 86 "E:\00. 프로젝트 홈작업\00. GoodDesign SmarFactory Web\GoodDesignWeb4 (2) (2)\SmartFactory\Views\Shared\Components\Pager\Bootstrap5.cshtml"
WriteAttributeValue(" ", 2102, (Model.PageIndex == i) ? "active" : null, 2103, 43, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n");
#nullable restore
#line 88 "E:\00. 프로젝트 홈작업\00. GoodDesign SmarFactory Web\GoodDesignWeb4 (2) (2)\SmartFactory\Views\Shared\Components\Pager\Bootstrap5.cshtml"
                 if (page_site.Contains("page"))
                {
                    page_site = page_site.Replace("page=", "");

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <a");
            BeginWriteAttribute("href", " href=\"", 2308, "\"", 2333, 3);
#nullable restore
#line 91 "E:\00. 프로젝트 홈작업\00. GoodDesign SmarFactory Web\GoodDesignWeb4 (2) (2)\SmartFactory\Views\Shared\Components\Pager\Bootstrap5.cshtml"
WriteAttributeValue("", 2315, page_site, 2315, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2325, "&page=", 2325, 6, true);
#nullable restore
#line 91 "E:\00. 프로젝트 홈작업\00. GoodDesign SmarFactory Web\GoodDesignWeb4 (2) (2)\SmartFactory\Views\Shared\Components\Pager\Bootstrap5.cshtml"
WriteAttributeValue("", 2331, i, 2331, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"page-link\">");
#nullable restore
#line 91 "E:\00. 프로젝트 홈작업\00. GoodDesign SmarFactory Web\GoodDesignWeb4 (2) (2)\SmartFactory\Views\Shared\Components\Pager\Bootstrap5.cshtml"
                                                              Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 92 "E:\00. 프로젝트 홈작업\00. GoodDesign SmarFactory Web\GoodDesignWeb4 (2) (2)\SmartFactory\Views\Shared\Components\Pager\Bootstrap5.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <a");
            BeginWriteAttribute("href", " href=\"", 2443, "\"", 2468, 3);
#nullable restore
#line 95 "E:\00. 프로젝트 홈작업\00. GoodDesign SmarFactory Web\GoodDesignWeb4 (2) (2)\SmartFactory\Views\Shared\Components\Pager\Bootstrap5.cshtml"
WriteAttributeValue("", 2450, page_site, 2450, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2460, "&page=", 2460, 6, true);
#nullable restore
#line 95 "E:\00. 프로젝트 홈작업\00. GoodDesign SmarFactory Web\GoodDesignWeb4 (2) (2)\SmartFactory\Views\Shared\Components\Pager\Bootstrap5.cshtml"
WriteAttributeValue("", 2466, i, 2466, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"page-link\">");
#nullable restore
#line 95 "E:\00. 프로젝트 홈작업\00. GoodDesign SmarFactory Web\GoodDesignWeb4 (2) (2)\SmartFactory\Views\Shared\Components\Pager\Bootstrap5.cshtml"
                                                              Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 96 "E:\00. 프로젝트 홈작업\00. GoodDesign SmarFactory Web\GoodDesignWeb4 (2) (2)\SmartFactory\Views\Shared\Components\Pager\Bootstrap5.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </li>\r\n");
#nullable restore
#line 100 "E:\00. 프로젝트 홈작업\00. GoodDesign SmarFactory Web\GoodDesignWeb4 (2) (2)\SmartFactory\Views\Shared\Components\Pager\Bootstrap5.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 102 "E:\00. 프로젝트 홈작업\00. GoodDesign SmarFactory Web\GoodDesignWeb4 (2) (2)\SmartFactory\Views\Shared\Components\Pager\Bootstrap5.cshtml"
         if (this.Model.PageIndex < this.Model.PageCount)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"page-item\">\r\n\r\n\r\n");
#nullable restore
#line 107 "E:\00. 프로젝트 홈작업\00. GoodDesign SmarFactory Web\GoodDesignWeb4 (2) (2)\SmartFactory\Views\Shared\Components\Pager\Bootstrap5.cshtml"
                 if (page_site.Contains("page"))
                {
                    page_site = page_site.Replace("page=", "");

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <a");
            BeginWriteAttribute("href", " href=\"", 2817, "\"", 2867, 3);
#nullable restore
#line 110 "E:\00. 프로젝트 홈작업\00. GoodDesign SmarFactory Web\GoodDesignWeb4 (2) (2)\SmartFactory\Views\Shared\Components\Pager\Bootstrap5.cshtml"
WriteAttributeValue("", 2824, page_site, 2824, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2834, "&page=", 2834, 6, true);
#nullable restore
#line 110 "E:\00. 프로젝트 홈작업\00. GoodDesign SmarFactory Web\GoodDesignWeb4 (2) (2)\SmartFactory\Views\Shared\Components\Pager\Bootstrap5.cshtml"
WriteAttributeValue("", 2840, this.Model.PageIndex + 1, 2840, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-label=\"Next\" class=\"page-link\"> <span aria-hidden=\"true\">&raquo;</span></a>\r\n");
#nullable restore
#line 111 "E:\00. 프로젝트 홈작업\00. GoodDesign SmarFactory Web\GoodDesignWeb4 (2) (2)\SmartFactory\Views\Shared\Components\Pager\Bootstrap5.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <a");
            BeginWriteAttribute("href", " href=\"", 3033, "\"", 3083, 3);
#nullable restore
#line 114 "E:\00. 프로젝트 홈작업\00. GoodDesign SmarFactory Web\GoodDesignWeb4 (2) (2)\SmartFactory\Views\Shared\Components\Pager\Bootstrap5.cshtml"
WriteAttributeValue("", 3040, page_site, 3040, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3050, "&page=", 3050, 6, true);
#nullable restore
#line 114 "E:\00. 프로젝트 홈작업\00. GoodDesign SmarFactory Web\GoodDesignWeb4 (2) (2)\SmartFactory\Views\Shared\Components\Pager\Bootstrap5.cshtml"
WriteAttributeValue("", 3056, this.Model.PageIndex + 1, 3056, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-label=\"Next\" class=\"page-link\"> <span aria-hidden=\"true\">&raquo;</span></a>\r\n");
#nullable restore
#line 115 "E:\00. 프로젝트 홈작업\00. GoodDesign SmarFactory Web\GoodDesignWeb4 (2) (2)\SmartFactory\Views\Shared\Components\Pager\Bootstrap5.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n            </li>\r\n");
#nullable restore
#line 122 "E:\00. 프로젝트 홈작업\00. GoodDesign SmarFactory Web\GoodDesignWeb4 (2) (2)\SmartFactory\Views\Shared\Components\Pager\Bootstrap5.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 124 "E:\00. 프로젝트 홈작업\00. GoodDesign SmarFactory Web\GoodDesignWeb4 (2) (2)\SmartFactory\Views\Shared\Components\Pager\Bootstrap5.cshtml"
         if (stop < this.Model.PageCount)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"page-item\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 3336, "\"", 3418, 1);
#nullable restore
#line 127 "E:\00. 프로젝트 홈작업\00. GoodDesign SmarFactory Web\GoodDesignWeb4 (2) (2)\SmartFactory\Views\Shared\Components\Pager\Bootstrap5.cshtml"
WriteAttributeValue("", 3343, Url.Action(Model.Action, Model.GetRouteValueForPage(this.Model.PageCount)), 3343, 75, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-label=\"Last\" class=\"page-link\">\r\n                    <span aria-hidden=\"true\">");
#nullable restore
#line 128 "E:\00. 프로젝트 홈작업\00. GoodDesign SmarFactory Web\GoodDesignWeb4 (2) (2)\SmartFactory\Views\Shared\Components\Pager\Bootstrap5.cshtml"
                                        Write(this.Model.PageCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                </a>\r\n\r\n\r\n");
#nullable restore
#line 132 "E:\00. 프로젝트 홈작업\00. GoodDesign SmarFactory Web\GoodDesignWeb4 (2) (2)\SmartFactory\Views\Shared\Components\Pager\Bootstrap5.cshtml"
                 if (page_site.Contains("page"))
                {
                    page_site = page_site.Replace("page=", "");

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <a");
            BeginWriteAttribute("href", " href=\"", 3715, "\"", 3761, 3);
#nullable restore
#line 135 "E:\00. 프로젝트 홈작업\00. GoodDesign SmarFactory Web\GoodDesignWeb4 (2) (2)\SmartFactory\Views\Shared\Components\Pager\Bootstrap5.cshtml"
WriteAttributeValue("", 3722, page_site, 3722, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3732, "&page=", 3732, 6, true);
#nullable restore
#line 135 "E:\00. 프로젝트 홈작업\00. GoodDesign SmarFactory Web\GoodDesignWeb4 (2) (2)\SmartFactory\Views\Shared\Components\Pager\Bootstrap5.cshtml"
WriteAttributeValue("", 3738, this.Model.PageCount, 3738, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-label=\"Last\" class=\"page-link\">  <span aria-hidden=\"true\">");
#nullable restore
#line 135 "E:\00. 프로젝트 홈작업\00. GoodDesign SmarFactory Web\GoodDesignWeb4 (2) (2)\SmartFactory\Views\Shared\Components\Pager\Bootstrap5.cshtml"
                                                                                                                                Write(this.Model.PageCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></a>\r\n");
#nullable restore
#line 136 "E:\00. 프로젝트 홈작업\00. GoodDesign SmarFactory Web\GoodDesignWeb4 (2) (2)\SmartFactory\Views\Shared\Components\Pager\Bootstrap5.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <a");
            BeginWriteAttribute("href", " href=\"", 3942, "\"", 3988, 3);
#nullable restore
#line 139 "E:\00. 프로젝트 홈작업\00. GoodDesign SmarFactory Web\GoodDesignWeb4 (2) (2)\SmartFactory\Views\Shared\Components\Pager\Bootstrap5.cshtml"
WriteAttributeValue("", 3949, page_site, 3949, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3959, "&page=", 3959, 6, true);
#nullable restore
#line 139 "E:\00. 프로젝트 홈작업\00. GoodDesign SmarFactory Web\GoodDesignWeb4 (2) (2)\SmartFactory\Views\Shared\Components\Pager\Bootstrap5.cshtml"
WriteAttributeValue("", 3965, this.Model.PageCount, 3965, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-label=\"Last\" class=\"page-link\"> <span aria-hidden=\"true\">");
#nullable restore
#line 139 "E:\00. 프로젝트 홈작업\00. GoodDesign SmarFactory Web\GoodDesignWeb4 (2) (2)\SmartFactory\Views\Shared\Components\Pager\Bootstrap5.cshtml"
                                                                                                                               Write(this.Model.PageCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></a>\r\n");
#nullable restore
#line 140 "E:\00. 프로젝트 홈작업\00. GoodDesign SmarFactory Web\GoodDesignWeb4 (2) (2)\SmartFactory\Views\Shared\Components\Pager\Bootstrap5.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            </li>\r\n");
#nullable restore
#line 145 "E:\00. 프로젝트 홈작업\00. GoodDesign SmarFactory Web\GoodDesignWeb4 (2) (2)\SmartFactory\Views\Shared\Components\Pager\Bootstrap5.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </ul>\r\n");
#nullable restore
#line 148 "E:\00. 프로젝트 홈작업\00. GoodDesign SmarFactory Web\GoodDesignWeb4 (2) (2)\SmartFactory\Views\Shared\Components\Pager\Bootstrap5.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ReflectionIT.Mvc.Paging.IPagingList> Html { get; private set; }
    }
}
#pragma warning restore 1591
