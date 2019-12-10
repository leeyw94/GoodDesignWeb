using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmartFactory.Helpers
{
    public class GetExcel
    {
        public void ExportToExcel(ref string html, string fileName)
        {
            html = html.Replace("&gt;", ">");
            html = html.Replace("&lt;", "<");
            HttpContext.Current.Response.ClearContent();
            HttpContext.Current.Response.AddHeader("content-disposition", "attachment;filename=" + fileName + "_" + DateTime.Now.ToString("yyyy-MM-dd") + ".xls");
            HttpContext.Current.Response.ContentType = "application/vnd.xls";
            HttpContext.Current.Response.ContentEncoding = System.Text.Encoding.Default;

            HttpContext.Current.Response.Write(html);
            HttpContext.Current.Response.End();

        }
    }
}