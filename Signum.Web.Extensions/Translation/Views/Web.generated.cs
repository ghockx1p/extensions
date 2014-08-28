﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Signum.Web.Extensions.Translation.Views
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
    using Signum.Utilities;
    using Signum.Web;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Translation/Views/Web.config")]
    public partial class Web : System.Web.Mvc.WebViewPage<dynamic>
    {
        public Web()
        {
        }
        public override void Execute()
        {
WriteLiteral("<?xml version=\"1.0\"?>\r\n\r\n<configuration>\r\n  <configSections>\r\n    <sectionGroup");

WriteLiteral(" name=\"system.web.webPages.razor\"");

WriteLiteral(" type=\"System.Web.WebPages.Razor.Configuration.RazorWebSectionGroup, System.Web.W" +
"ebPages.Razor, Version=2.0.0.0, Culture=neutral, PublicKeyToken=31BF3856AD364E35" +
"\"");

WriteLiteral(">\r\n      <section");

WriteLiteral(" name=\"host\"");

WriteLiteral(" type=\"System.Web.WebPages.Razor.Configuration.HostSection, System.Web.WebPages.R" +
"azor, Version=2.0.0.0, Culture=neutral, PublicKeyToken=31BF3856AD364E35\"");

WriteLiteral(" requirePermission=\"false\"");

WriteLiteral(" />\r\n      <section");

WriteLiteral(" name=\"pages\"");

WriteLiteral(" type=\"System.Web.WebPages.Razor.Configuration.RazorPagesSection, System.Web.WebP" +
"ages.Razor, Version=2.0.0.0, Culture=neutral, PublicKeyToken=31BF3856AD364E35\"");

WriteLiteral(" requirePermission=\"false\"");

WriteLiteral(" />\r\n    </sectionGroup>\r\n  </configSections>\r\n\r\n  <system.web.webPages.razor>\r\n " +
"   <host");

WriteLiteral(" factoryType=\"System.Web.Mvc.MvcWebRazorHostFactory, System.Web.Mvc, Version=4.0." +
"0.0, Culture=neutral, PublicKeyToken=31BF3856AD364E35\"");

WriteLiteral(" />\r\n    <pages");

WriteLiteral(" pageBaseType=\"System.Web.Mvc.WebViewPage\"");

WriteLiteral(">\r\n      <namespaces>\r\n        <add");

WriteLiteral(" namespace=\"System.Web.Mvc\"");

WriteLiteral(" />\r\n        <add");

WriteLiteral(" namespace=\"System.Web.Mvc.Ajax\"");

WriteLiteral(" />\r\n        <add");

WriteLiteral(" namespace=\"System.Web.Mvc.Html\"");

WriteLiteral(" />\r\n        <add");

WriteLiteral(" namespace=\"System.Web.Routing\"");

WriteLiteral(" />\r\n\t\t<add");

WriteLiteral(" namespace=\"Signum.Utilities\"");

WriteLiteral(" />\r\n        <add");

WriteLiteral(" namespace=\"Signum.Entities\"");

WriteLiteral(" />\r\n        <add");

WriteLiteral(" namespace=\"Signum.Web\"");

WriteLiteral(" />\r\n      </namespaces>\r\n    </pages>\r\n  </system.web.webPages.razor>\r\n\r\n  <appS" +
"ettings>\r\n    <add");

WriteLiteral(" key=\"webpages:Enabled\"");

WriteLiteral(" value=\"false\"");

WriteLiteral(" />\r\n  </appSettings>\r\n\r\n  <system.web>\r\n    <httpHandlers>\r\n      <add");

WriteLiteral(" path=\"*\"");

WriteLiteral(" verb=\"*\"");

WriteLiteral(" type=\"System.Web.HttpNotFoundHandler\"");

WriteLiteral(@"/>
    </httpHandlers>

    <!--
        Enabling request validation in view pages would cause validation to occur
        after the input has already been processed by the controller. By default
        MVC performs request validation before a controller processes the input.
        To change this behavior apply the ValidateInputAttribute to a
        controller or action.
    -->
    <pages
        validateRequest=""false""
        pageParserFilterType=""System.Web.Mvc.ViewTypeParserFilter, System.Web.Mvc, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31BF3856AD364E35""
        pageBaseType=""System.Web.Mvc.ViewPage, System.Web.Mvc, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31BF3856AD364E35""
        userControlBaseType=""System.Web.Mvc.ViewUserControl, System.Web.Mvc, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31BF3856AD364E35"">
      <controls>
        <add");

WriteLiteral(" assembly=\"System.Web.Mvc, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31BF3" +
"856AD364E35\"");

WriteLiteral(" namespace=\"System.Web.Mvc\"");

WriteLiteral(" tagPrefix=\"mvc\"");

WriteLiteral(" />\r\n      </controls>\r\n    </pages>\r\n  </system.web>\r\n\r\n  <system.webServer>\r\n  " +
"  <validation");

WriteLiteral(" validateIntegratedModeConfiguration=\"false\"");

WriteLiteral(" />\r\n\r\n    <handlers>\r\n      <remove");

WriteLiteral(" name=\"BlockViewHandler\"");

WriteLiteral("/>\r\n      <add");

WriteLiteral(" name=\"BlockViewHandler\"");

WriteLiteral(" path=\"*\"");

WriteLiteral(" verb=\"*\"");

WriteLiteral(" preCondition=\"integratedMode\"");

WriteLiteral(" type=\"System.Web.HttpNotFoundHandler\"");

WriteLiteral(" />\r\n    </handlers>\r\n  </system.webServer>\r\n</configuration>\r\n");

        }
    }
}
#pragma warning restore 1591
