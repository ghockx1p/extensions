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

namespace Signum.Web.Extensions.Help.Views
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
    
    #line 1 "..\..\Help\Views\Menu.cshtml"
    using Signum.Web.Help;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Help/Views/Menu.cshtml")]
    public partial class Menu : System.Web.Mvc.WebViewPage<dynamic>
    {
        public Menu()
        {
        }
        public override void Execute()
        {
WriteLiteral("<div");

WriteLiteral(" id=\"syntax-help\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" id=\"syntax-list\"");

WriteLiteral(@">
        Utiliza la siguiente sintaxis:
        <h2>Textos</h2>
        <table>
            <tr><td><b>Texto en negrita</b></td><td>'''Texto en negrita'''</td></tr>
            <tr><td><i>Texto en cursiva</i></td><td>''Texto en cursiva''</td></tr>
            <tr><td><u>Texto subrayado</u></td><td>_Texto subrayado_</td></tr>
            <tr><td><s>Texto tachado</s></td><td>-Texto tachado-</td></tr>
        </table>
        <h2>Listas</h2>
        <table>
            <tr><td><ul><li>Elemento no numerado de lista</li><li>Otro elemento</li></ul></td><td>* Elemento no numerado de lista<br />* Otro elemento</td></tr>
            <tr><td><ol><li>Elemento numerado de lista</li><li>Otro elemento</li></ol></td><td># Elemento numerado de lista <br /># Otro elemento</td></tr>
        </table>
        <h2>Enlaces</h2>
        <table>
            <tr><td><a");

WriteLiteral(" href=\"#\"");

WriteLiteral(">Enlace a entidad</a></td><td>[e:EntidadDN]</td></tr>\r\n            <tr><td><a");

WriteLiteral(" href=\"#\"");

WriteLiteral(">Enlace a propiedad</a></td><td>[p:EntidadDN.Propiedad]</td></tr>\r\n            <t" +
"r><td><a");

WriteLiteral(" href=\"#\"");

WriteLiteral(">Enlace a consulta</a></td><td>[q:EntidadQuery.ObtenerDatos]</td></tr>           " +
"             \r\n            <tr><td><a");

WriteLiteral(" href=\"#\"");

WriteLiteral(">Enlace a operacion</a></td><td>[o:EntidadOperation.Crear]</td></tr>\r\n           " +
" <tr><td><a");

WriteLiteral(" href=\"#\"");

WriteLiteral(">Enlace a espacio de nombres</a></td><td>[n:Negocio.Entities.Bancos]</td></tr>   " +
"         \r\n            <tr><td><a");

WriteLiteral(" href=\"http://www.google.es\"");

WriteLiteral(">http://www.google.es</a></td><td>[h:http://www.google.es]</td></tr>\r\n           " +
" <tr><td><a");

WriteLiteral(" href=\"#\"");

WriteLiteral(">Enlace relativo a wiki</a></td><td>[w:Portada]</td></tr>\r\n        </table>\r\n    " +
"    Los enlaces admiten un parámetro adicional con el texto que se mostrará en e" +
"l enlace. Ejemplo: <a");

WriteLiteral(" href=\"http://www.google.es\"");

WriteLiteral(@">Web de Google</a> con [h:http://www.google.es|Web de Google]
        <h2>Imágenes</h2>
        <table>
        <tr><td>Insertar imagen</td><td>[imageright|Pie de foto|imagen.jpg] o [imageright|imagen.jpg] (Opciones imageright, imageleft, imagecentre, imageauto)</td></tr>                        
        </table>
        <h2>Títulos</h2>
        <table>
            <tr><td><h2>Título nivel 2</h2></td><td>==Título nivel 2==</td></tr>
            <tr><td><h3>Título nivel 3</h3></td><td>===Título nivel 3===</td></tr>
            <tr><td><h4>Título nivel 4</h4></td><td>====Título nivel 4====</td></tr>
            <tr><td><h5>Título nivel 5</h5></td><td>=====Título nivel 5=====</td></tr>
        </table>
        Los enlaces admiten un parámetro adicional con el texto que se mostrará en el enlace. Ejemplo: <a");

WriteLiteral(" href=\"http://www.google.es\"");

WriteLiteral(">Web de Google</a> con [h:http://www.google.es|Web de Google]\r\n    </div>\r\n</div>" +
"\r\n<div");

WriteLiteral(" class=\"clearall\"");

WriteLiteral("></div>\r\n<div");

WriteLiteral(" class=\"help_left\"");

WriteLiteral(" style=\"min-height:1px;\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" id=\"saving-error\"");

WriteLiteral("><img");

WriteAttribute("src", Tuple.Create(" src=\"", 2866), Tuple.Create("\"", 2918)
            
            #line 44 "..\..\Help\Views\Menu.cshtml"
, Tuple.Create(Tuple.Create("", 2872), Tuple.Create<System.Object, System.Int32>(Url.Content("~/help/Images/icon-warning.png")
            
            #line default
            #line hidden
, 2872), false)
);

WriteLiteral(" /><span");

WriteLiteral(" class=\"text\"");

WriteLiteral("></span></div> \r\n</div>\r\n<div");

WriteLiteral(" class=\"help_right\"");

WriteLiteral(">\r\n   <!-- <a");

WriteLiteral(" id=\"refresh\"");

WriteLiteral(" href=\"javascript:location.reload(true);\"");

WriteLiteral(">Refresca la página para wikificar correctamente el texto modificado</a> -->\r\n   " +
" <a");

WriteLiteral(" id=\"edit-action\"");

WriteLiteral(" class=\"action\"");

WriteAttribute("href", Tuple.Create(" href=\"", 3171), Tuple.Create("\"", 3208)
            
            #line 48 "..\..\Help\Views\Menu.cshtml"
, Tuple.Create(Tuple.Create("", 3178), Tuple.Create<System.Object, System.Int32>(HelpClient.Module["edit"]()
            
            #line default
            #line hidden
, 3178), false)
);

WriteLiteral(">Editar</a>\r\n    <a");

WriteLiteral(" id=\"syntax-action\"");

WriteLiteral(" class=\"action\"");

WriteLiteral(" style=\"display: none\"");

WriteLiteral(">Sintaxis</a>    \r\n    <a");

WriteLiteral(" id=\"save-action\"");

WriteLiteral(" class=\"action\"");

WriteAttribute("href", Tuple.Create(" href=\"", 3341), Tuple.Create("\"", 3378)
            
            #line 50 "..\..\Help\Views\Menu.cshtml"
, Tuple.Create(Tuple.Create("", 3348), Tuple.Create<System.Object, System.Int32>(HelpClient.Module["save"]()
            
            #line default
            #line hidden
, 3348), false)
);

WriteLiteral(" style=\"display: none\"");

WriteLiteral(">Guardar</a>    \r\n</div>\r\n<div");

WriteLiteral(" class=\"clearall\"");

WriteLiteral("></div>");

        }
    }
}
#pragma warning restore 1591
