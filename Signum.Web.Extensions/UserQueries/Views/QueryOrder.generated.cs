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
    
    #line 1 "..\..\UserQueries\Views\QueryOrder.cshtml"
    using Signum.Engine;
    
    #line default
    #line hidden
    using Signum.Entities;
    
    #line 4 "..\..\UserQueries\Views\QueryOrder.cshtml"
    using Signum.Entities.DynamicQuery;
    
    #line default
    #line hidden
    
    #line 2 "..\..\UserQueries\Views\QueryOrder.cshtml"
    using Signum.Entities.UserQueries;
    
    #line default
    #line hidden
    using Signum.Utilities;
    using Signum.Web;
    
    #line 3 "..\..\UserQueries\Views\QueryOrder.cshtml"
    using Signum.Web.UserAssets;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/UserQueries/Views/QueryOrder.cshtml")]
    public partial class _UserQueries_Views_QueryOrder_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _UserQueries_Views_QueryOrder_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 6 "..\..\UserQueries\Views\QueryOrder.cshtml"
 using (var e = Html.TypeContext<QueryOrderEntity>())
{
    e.FormGroupStyle = FormGroupStyle.None;
    
            
            #line default
            #line hidden
            
            #line 9 "..\..\UserQueries\Views\QueryOrder.cshtml"
Write(Html.QueryTokenDNBuilder(e.SubContext(a => a.Token), SearchControlHelper.GetQueryTokenBuilderSettings(
                (QueryDescription)ViewData[ViewDataKeys.QueryDescription], SubTokensOptions.CanElement)));

            
            #line default
            #line hidden
            
            #line 10 "..\..\UserQueries\Views\QueryOrder.cshtml"
                                                                                                        
    
    
            
            #line default
            #line hidden
            
            #line 12 "..\..\UserQueries\Views\QueryOrder.cshtml"
Write(Html.ValueLine(e, f => f.OrderType));

            
            #line default
            #line hidden
            
            #line 12 "..\..\UserQueries\Views\QueryOrder.cshtml"
                                        
}

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
