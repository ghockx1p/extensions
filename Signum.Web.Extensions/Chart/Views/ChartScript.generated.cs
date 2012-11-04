﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18010
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Signum.Web.Extensions.Chart.Views
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    
    #line 3 "..\..\Chart\Views\ChartScript.cshtml"
    using Signum.Engine;
    
    #line default
    #line hidden
    using Signum.Entities;
    
    #line 1 "..\..\Chart\Views\ChartScript.cshtml"
    using Signum.Entities.Chart;
    
    #line default
    #line hidden
    using Signum.Utilities;
    using Signum.Web;
    
    #line 2 "..\..\Chart\Views\ChartScript.cshtml"
    using Signum.Web.Files;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "1.5.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Chart/Views/ChartScript.cshtml")]
    public class ChartScript : System.Web.Mvc.WebViewPage<dynamic>
    {
        public ChartScript()
        {
        }
        public override void Execute()
        {




            
            #line 4 "..\..\Chart\Views\ChartScript.cshtml"
Write(Html.ScriptCss(
    "~/Chart/Content/SF_Chart.css"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");


            
            #line 6 "..\..\Chart\Views\ChartScript.cshtml"
 using (var cc = Html.TypeContext<ChartScriptDN>())
{

            
            #line default
            #line hidden
WriteLiteral("    <div>\r\n        <div style=\"float: left\">\r\n            ");


            
            #line 10 "..\..\Chart\Views\ChartScript.cshtml"
       Write(Html.ValueLine(cc, c => c.Name));

            
            #line default
            #line hidden
WriteLiteral("\r\n            ");


            
            #line 11 "..\..\Chart\Views\ChartScript.cshtml"
       Write(Html.FileLine(cc, c => c.Icon.TryCC(i => i.Retrieve()), a => { a.LabelVisible = true; a.LabelText = Html.PropertyNiceName(() => cc.Value.Icon); }));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n");


            
            #line 13 "..\..\Chart\Views\ChartScript.cshtml"
         if (cc.Value.Icon != null && !cc.Value.Icon.IsNew)
        {

            
            #line default
            #line hidden
WriteLiteral("            <div style=\"float: left\">\r\n                <img src=\"");


            
            #line 16 "..\..\Chart\Views\ChartScript.cshtml"
                     Write(Url.Action((FileController fc) => fc.Download(new RuntimeInfo(cc.Value.Icon).ToString())));

            
            #line default
            #line hidden
WriteLiteral("\" />\r\n            </div>\r\n");


            
            #line 18 "..\..\Chart\Views\ChartScript.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("        <div class=\"clearall\" />\r\n    </div>\r\n");


            
            #line 21 "..\..\Chart\Views\ChartScript.cshtml"
 
    
            
            #line default
            #line hidden
            
            #line 22 "..\..\Chart\Views\ChartScript.cshtml"
Write(Html.ValueLine(cc, c => c.GroupBy));

            
            #line default
            #line hidden
            
            #line 22 "..\..\Chart\Views\ChartScript.cshtml"
                                       

            
            #line default
            #line hidden
WriteLiteral("    <div class=\"sf-chartscript-columns\">\r\n        ");


            
            #line 24 "..\..\Chart\Views\ChartScript.cshtml"
   Write(Html.EntityRepeater(cc, c => c.Columns));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n");


            
            #line 26 "..\..\Chart\Views\ChartScript.cshtml"
    
    
            
            #line default
            #line hidden
            
            #line 27 "..\..\Chart\Views\ChartScript.cshtml"
Write(Html.Partial(Signum.Web.Chart.ChartClient.ChartScriptCodeView, cc));

            
            #line default
            #line hidden
            
            #line 27 "..\..\Chart\Views\ChartScript.cshtml"
                                                                       
}

            
            #line default
            #line hidden

        }
    }
}
#pragma warning restore 1591