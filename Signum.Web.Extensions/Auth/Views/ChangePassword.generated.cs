﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
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
    using Signum.Entities.Authorization;
    using Signum.Utilities;
    using Signum.Web;
    using Signum.Web.Auth;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Auth/Views/ChangePassword.cshtml")]
    public partial class _Auth_Views_ChangePassword_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Auth_Views_ChangePassword_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 1 "..\..\Auth\Views\ChangePassword.cshtml"
    
    ViewBag.Title = AuthMessage.ChangePassword.NiceToString();

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<div");

WriteLiteral(" class=\"col-sm-offset-4\"");

WriteLiteral(">\r\n    <h2>Login</h2>\r\n    <p>\r\n");

WriteLiteral("        ");

            
            #line 8 "..\..\Auth\Views\ChangePassword.cshtml"
   Write(AuthMessage.ChangePasswordAspx_ChangePassword.NiceToString());

            
            #line default
            #line hidden
WriteLiteral("\r\n    </p>\r\n");

WriteLiteral("    ");

            
            #line 10 "..\..\Auth\Views\ChangePassword.cshtml"
Write(Html.ValudationSummaryStatic());

            
            #line default
            #line hidden
WriteLiteral("\r\n</div>\r\n\r\n");

            
            #line 13 "..\..\Auth\Views\ChangePassword.cshtml"
 using (Html.BeginForm())
{

            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteLiteral(" class=\"form-horizontal\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n            <label");

WriteLiteral(" for=\"username\"");

WriteLiteral(" class=\"col-sm-offset-2 col-sm-2 control-label\"");

WriteLiteral(">");

            
            #line 17 "..\..\Auth\Views\ChangePassword.cshtml"
                                                                            Write(AuthMessage.ChangePasswordAspx_ActualPassword.NiceToString());

            
            #line default
            #line hidden
WriteLiteral("</label>\r\n            <div");

WriteLiteral(" class=\"col-sm-4\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 19 "..\..\Auth\Views\ChangePassword.cshtml"
           Write(Html.Password(UserMapping.OldPasswordKey, null, new { @class = "form-control", placeholder = AuthMessage.ChangePasswordAspx_ActualPassword.NiceToString() }));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n            <label");

WriteLiteral(" for=\"username\"");

WriteLiteral(" class=\"col-sm-offset-2 col-sm-2 control-label\"");

WriteLiteral(">");

            
            #line 23 "..\..\Auth\Views\ChangePassword.cshtml"
                                                                            Write(AuthMessage.ChangePasswordAspx_NewPassword.NiceToString());

            
            #line default
            #line hidden
WriteLiteral("</label>\r\n            <div");

WriteLiteral(" class=\"col-sm-4\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 25 "..\..\Auth\Views\ChangePassword.cshtml"
           Write(Html.Password(UserMapping.NewPasswordKey, null, new { @class = "form-control", placeholder = AuthMessage.ChangePasswordAspx_NewPassword.NiceToString() }));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n            <label");

WriteLiteral(" for=\"username\"");

WriteLiteral(" class=\"col-sm-offset-2 col-sm-2 control-label\"");

WriteLiteral(">");

            
            #line 29 "..\..\Auth\Views\ChangePassword.cshtml"
                                                                            Write(AuthMessage.ChangePasswordAspx_ConfirmNewPassword.NiceToString());

            
            #line default
            #line hidden
WriteLiteral("</label>\r\n            <div");

WriteLiteral(" class=\"col-sm-4\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 31 "..\..\Auth\Views\ChangePassword.cshtml"
           Write(Html.Password(UserMapping.NewPasswordBisKey, null, new { @class = "form-control", placeholder = AuthMessage.ChangePasswordAspx_ConfirmNewPassword.NiceToString() }));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n");

WriteLiteral("    <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"col-sm-offset-4 col-sm-6\"");

WriteLiteral(">\r\n            <button");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" class=\"btn btn-default\"");

WriteLiteral(" id=\"login\"");

WriteLiteral(">");

            
            #line 37 "..\..\Auth\Views\ChangePassword.cshtml"
                                                                Write(AuthMessage.ChangePassword.NiceToString());

            
            #line default
            #line hidden
WriteLiteral("</button>\r\n        </div>\r\n    </div>   \r\n");

            
            #line 40 "..\..\Auth\Views\ChangePassword.cshtml"
}
            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
