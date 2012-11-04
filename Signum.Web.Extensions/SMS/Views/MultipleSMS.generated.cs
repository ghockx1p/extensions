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

namespace Signum.Web.Extensions.SMS.Views
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
    
    #line 1 "..\..\SMS\Views\MultipleSMS.cshtml"
    using Signum.Engine;
    
    #line default
    #line hidden
    
    #line 2 "..\..\SMS\Views\MultipleSMS.cshtml"
    using Signum.Entities.SMS;
    
    #line default
    #line hidden
    
    #line 3 "..\..\SMS\Views\MultipleSMS.cshtml"
    using Signum.Web;
    
    #line default
    #line hidden
    
    #line 5 "..\..\SMS\Views\MultipleSMS.cshtml"
    using Signum.Web.Extensions.SMS.Models;
    
    #line default
    #line hidden
    
    #line 4 "..\..\SMS\Views\MultipleSMS.cshtml"
    using Signum.Web.SMS;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "1.5.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/SMS/Views/MultipleSMS.cshtml")]
    public class MultipleSMS : System.Web.Mvc.WebViewPage<dynamic>
    {
        public MultipleSMS()
        {
        }
        public override void Execute()
        {






            
            #line 6 "..\..\SMS\Views\MultipleSMS.cshtml"
Write(Html.ScriptCss("~/SMS/Content/SMS.css"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");


            
            #line 7 "..\..\SMS\Views\MultipleSMS.cshtml"
 using (var e = Html.TypeContext<MultipleSMSModel>())
{
    
            
            #line default
            #line hidden
            
            #line 9 "..\..\SMS\Views\MultipleSMS.cshtml"
Write(Html.ValueLine(e, s => s.Message, vl =>
   {
       vl.ValueLineType = ValueLineType.TextArea;
       vl.ValueHtmlProps["cols"] = "30";
       vl.ValueHtmlProps["rows"] = "6";
   }));

            
            #line default
            #line hidden
            
            #line 14 "..\..\SMS\Views\MultipleSMS.cshtml"
     

            
            #line default
            #line hidden
WriteLiteral("    <div id=\"sfCharactersLeft\" data-url=\"");


            
            #line 15 "..\..\SMS\Views\MultipleSMS.cshtml"
                                     Write(Url.Action<SMSController>(s => s.GetDictionaries()));

            
            #line default
            #line hidden
WriteLiteral("\">\r\n        <p>\r\n            Remaining characters: <span id=\"sfCharsLeft\"></span>" +
"\r\n        </p>\r\n    </div>\r\n");



WriteLiteral("    <div>\r\n        <input type=\"button\" class=\"sf-button\" id=\"sfRemoveNoSMSChars\"" +
" value=\"Remove non valid characters\" data-url=\"");


            
            #line 21 "..\..\SMS\Views\MultipleSMS.cshtml"
                                                                                                                 Write(Url.Action<SMSController>(s => s.RemoveNoSMSCharacters("")));

            
            #line default
            #line hidden
WriteLiteral("\"/>\r\n    </div>\r\n");



WriteLiteral("    <br />\r\n");


            
            #line 24 "..\..\SMS\Views\MultipleSMS.cshtml"
    
            
            #line default
            #line hidden
            
            #line 24 "..\..\SMS\Views\MultipleSMS.cshtml"
Write(Html.ValueLine(e, s => s.From));

            
            #line default
            #line hidden
            
            #line 24 "..\..\SMS\Views\MultipleSMS.cshtml"
                                   
    
            
            #line default
            #line hidden
            
            #line 25 "..\..\SMS\Views\MultipleSMS.cshtml"
Write(Html.Hidden(e.Compose("ProvidersIds"), e.Value.ProvidersIds));

            
            #line default
            #line hidden
            
            #line 25 "..\..\SMS\Views\MultipleSMS.cshtml"
                                                                 ;
    
            
            #line default
            #line hidden
            
            #line 26 "..\..\SMS\Views\MultipleSMS.cshtml"
Write(Html.Hidden(e.Compose("WebTypeName"), e.Value.WebTypeName));

            
            #line default
            #line hidden
            
            #line 26 "..\..\SMS\Views\MultipleSMS.cshtml"
                                                               ;
}

            
            #line default
            #line hidden

            
            #line 28 "..\..\SMS\Views\MultipleSMS.cshtml"
Write(Html.ScriptsJs("~/SMS/Scripts/SF_SMS.js"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");


        }
    }
}
#pragma warning restore 1591