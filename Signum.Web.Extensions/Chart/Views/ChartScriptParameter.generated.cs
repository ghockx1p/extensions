﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
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
    using Signum.Entities;
    
    #line 1 "..\..\Chart\Views\ChartScriptParameter.cshtml"
    using Signum.Entities.Chart;
    
    #line default
    #line hidden
    using Signum.Utilities;
    using Signum.Web;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Chart/Views/ChartScriptParameter.cshtml")]
    public partial class ChartScriptParameter : System.Web.Mvc.WebViewPage<dynamic>
    {
        public ChartScriptParameter()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Chart\Views\ChartScriptParameter.cshtml"
 using (var cc = Html.TypeContext<ChartScriptParameterDN>())
{
    cc.FormGroupStyle = FormGroupStyle.Basic;


            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteLiteral(" class=\"form-vertical\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"col-sm-2\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 8 "..\..\Chart\Views\ChartScriptParameter.cshtml"
       Write(Html.ValueLine(cc, c => c.Name));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n\r\n        <div");

WriteLiteral(" class=\"col-sm-2\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 12 "..\..\Chart\Views\ChartScriptParameter.cshtml"
       Write(Html.ValueLine(cc, c => c.Type));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n\r\n        <div");

WriteLiteral(" class=\"col-sm-8\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 16 "..\..\Chart\Views\ChartScriptParameter.cshtml"
       Write(Html.ValueLine(cc, c => c.ValueDefinition));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n    </div>\r\n");

            
            #line 19 "..\..\Chart\Views\ChartScriptParameter.cshtml"
}

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
