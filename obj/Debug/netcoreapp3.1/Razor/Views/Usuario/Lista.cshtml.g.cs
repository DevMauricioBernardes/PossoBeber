#pragma checksum "C:\HTML-CSS\Senac\ProjetoIntegrador\PossoBeber - Copia\Views\Usuario\Lista.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9f7f63d8bc0e76a771f5fa062405b2427cdb5fda"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_Lista), @"mvc.1.0.view", @"/Views/Usuario/Lista.cshtml")]
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
#line 1 "C:\HTML-CSS\Senac\ProjetoIntegrador\PossoBeber - Copia\Views\_ViewImports.cshtml"
using PossoBeber;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\HTML-CSS\Senac\ProjetoIntegrador\PossoBeber - Copia\Views\_ViewImports.cshtml"
using PossoBeber.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f7f63d8bc0e76a771f5fa062405b2427cdb5fda", @"/Views/Usuario/Lista.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3632d328f67d785177563e23c5eca986f67129fb", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuario_Lista : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Usuario>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\HTML-CSS\Senac\ProjetoIntegrador\PossoBeber - Copia\Views\Usuario\Lista.cshtml"
  
    ViewData["Title"] = "Lista";
    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <table class=""table"">
        <thead>
            <tr>
                <th>Id</th>
                <th>Nome</th>
                <th>Email</th>
                <th>Login</th>
                <th>Senha</th>                
                <th>Operações</th>
            </tr>
        </thead>
");
#nullable restore
#line 17 "C:\HTML-CSS\Senac\ProjetoIntegrador\PossoBeber - Copia\Views\Usuario\Lista.cshtml"
             foreach (Usuario u in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 20 "C:\HTML-CSS\Senac\ProjetoIntegrador\PossoBeber - Copia\Views\Usuario\Lista.cshtml"
                   Write(u.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 21 "C:\HTML-CSS\Senac\ProjetoIntegrador\PossoBeber - Copia\Views\Usuario\Lista.cshtml"
                   Write(u.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 22 "C:\HTML-CSS\Senac\ProjetoIntegrador\PossoBeber - Copia\Views\Usuario\Lista.cshtml"
                   Write(u.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 23 "C:\HTML-CSS\Senac\ProjetoIntegrador\PossoBeber - Copia\Views\Usuario\Lista.cshtml"
                   Write(u.Login);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 24 "C:\HTML-CSS\Senac\ProjetoIntegrador\PossoBeber - Copia\Views\Usuario\Lista.cshtml"
                   Write(u.Senha);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>                    \r\n                    <td>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 719, "\"", 751, 2);
            WriteAttributeValue("", 726, "/Usuario/Alterar?Id=", 726, 20, true);
#nullable restore
#line 26 "C:\HTML-CSS\Senac\ProjetoIntegrador\PossoBeber - Copia\Views\Usuario\Lista.cshtml"
WriteAttributeValue("", 746, u.Id, 746, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Alterar</a> |\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 794, "\"", 826, 2);
            WriteAttributeValue("", 801, "/Usuario/Excluir?Id=", 801, 20, true);
#nullable restore
#line 27 "C:\HTML-CSS\Senac\ProjetoIntegrador\PossoBeber - Copia\Views\Usuario\Lista.cshtml"
WriteAttributeValue("", 821, u.Id, 821, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Excluir</a>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 30 "C:\HTML-CSS\Senac\ProjetoIntegrador\PossoBeber - Copia\Views\Usuario\Lista.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tbody>\r\n\r\n        </tbody>    \r\n    </table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Usuario>> Html { get; private set; }
    }
}
#pragma warning restore 1591
