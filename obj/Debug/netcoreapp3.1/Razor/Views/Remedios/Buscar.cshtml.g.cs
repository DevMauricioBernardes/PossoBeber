#pragma checksum "C:\HTML-CSS\Senac\ProjetoIntegradorII\PossoBeber\Views\Remedios\Buscar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "11615d4d7bf981a20aea47ad235affa48d07506d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Remedios_Buscar), @"mvc.1.0.view", @"/Views/Remedios/Buscar.cshtml")]
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
#line 1 "C:\HTML-CSS\Senac\ProjetoIntegradorII\PossoBeber\Views\_ViewImports.cshtml"
using PossoBeber;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\HTML-CSS\Senac\ProjetoIntegradorII\PossoBeber\Views\_ViewImports.cshtml"
using PossoBeber.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\HTML-CSS\Senac\ProjetoIntegradorII\PossoBeber\Views\Remedios\Buscar.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"11615d4d7bf981a20aea47ad235affa48d07506d", @"/Views/Remedios/Buscar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3632d328f67d785177563e23c5eca986f67129fb", @"/Views/_ViewImports.cshtml")]
    public class Views_Remedios_Buscar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Remedios>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\HTML-CSS\Senac\ProjetoIntegradorII\PossoBeber\Views\Remedios\Buscar.cshtml"
  

    ViewData["Title"] = "Buscar";

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\HTML-CSS\Senac\ProjetoIntegradorII\PossoBeber\Views\Remedios\Buscar.cshtml"
Write(ViewData["Nome"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n\n");
#nullable restore
#line 10 "C:\HTML-CSS\Senac\ProjetoIntegradorII\PossoBeber\Views\Remedios\Buscar.cshtml"
     foreach (Remedios u in Model)

    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"resultado\">\n\n");
#nullable restore
#line 15 "C:\HTML-CSS\Senac\ProjetoIntegradorII\PossoBeber\Views\Remedios\Buscar.cshtml"
             if (Context.Session.GetInt32("IdUsuario") == null)

            { //usuario deslogado ve isso

#line default
#line hidden
#nullable disable
            WriteLiteral("                <h1>");
#nullable restore
#line 18 "C:\HTML-CSS\Senac\ProjetoIntegradorII\PossoBeber\Views\Remedios\Buscar.cshtml"
               Write(u.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n                <p>\n");
#nullable restore
#line 20 "C:\HTML-CSS\Senac\ProjetoIntegradorII\PossoBeber\Views\Remedios\Buscar.cshtml"
                     if (@u.Posso == "Sim")

                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <img src=\"/img/ok.png\" alt=\"ok\" width=\"100\">\n");
#nullable restore
#line 24 "C:\HTML-CSS\Senac\ProjetoIntegradorII\PossoBeber\Views\Remedios\Buscar.cshtml"

                    }
                    else

                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <img src=\"/img/not.png\" alt=\"ok\" width=\"100\">\n");
#nullable restore
#line 30 "C:\HTML-CSS\Senac\ProjetoIntegradorII\PossoBeber\Views\Remedios\Buscar.cshtml"

                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </p>\n                <p>");
#nullable restore
#line 33 "C:\HTML-CSS\Senac\ProjetoIntegradorII\PossoBeber\Views\Remedios\Buscar.cshtml"
              Write(u.Descricao);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n");
#nullable restore
#line 34 "C:\HTML-CSS\Senac\ProjetoIntegradorII\PossoBeber\Views\Remedios\Buscar.cshtml"
            }
            else

            { //usuario logado ve isso

#line default
#line hidden
#nullable disable
            WriteLiteral("                <h1>");
#nullable restore
#line 38 "C:\HTML-CSS\Senac\ProjetoIntegradorII\PossoBeber\Views\Remedios\Buscar.cshtml"
               Write(u.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n                <p>\n");
#nullable restore
#line 40 "C:\HTML-CSS\Senac\ProjetoIntegradorII\PossoBeber\Views\Remedios\Buscar.cshtml"
                     if (@u.Posso == "Sim")

                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <img src=\"/img/ok.png\" alt=\"ok\" width=\"100\">\n");
#nullable restore
#line 44 "C:\HTML-CSS\Senac\ProjetoIntegradorII\PossoBeber\Views\Remedios\Buscar.cshtml"

                    }
                    else

                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <img src=\"/img/not.png\" alt=\"ok\" width=\"100\">\n");
#nullable restore
#line 50 "C:\HTML-CSS\Senac\ProjetoIntegradorII\PossoBeber\Views\Remedios\Buscar.cshtml"

                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </p>\n                <p>");
#nullable restore
#line 53 "C:\HTML-CSS\Senac\ProjetoIntegradorII\PossoBeber\Views\Remedios\Buscar.cshtml"
              Write(u.Descricao);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                <p>ID: ");
#nullable restore
#line 54 "C:\HTML-CSS\Senac\ProjetoIntegradorII\PossoBeber\Views\Remedios\Buscar.cshtml"
                  Write(u.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                <p>Usuário: ");
#nullable restore
#line 55 "C:\HTML-CSS\Senac\ProjetoIntegradorII\PossoBeber\Views\Remedios\Buscar.cshtml"
                       Write(u.Usuario);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                <p>\n                    <a class=\"btn btn-warning\"");
            BeginWriteAttribute("href", " href=\"", 1331, "\"", 1364, 2);
            WriteAttributeValue("", 1338, "/Remedios/Alterar?Id=", 1338, 21, true);
#nullable restore
#line 57 "C:\HTML-CSS\Senac\ProjetoIntegradorII\PossoBeber\Views\Remedios\Buscar.cshtml"
WriteAttributeValue("", 1359, u.Id, 1359, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Alterar</a>\n                    <a class=\"btn btn-danger\"");
            BeginWriteAttribute("href", " href=\"", 1423, "\"", 1456, 2);
            WriteAttributeValue("", 1430, "/Remedios/Excluir?Id=", 1430, 21, true);
#nullable restore
#line 58 "C:\HTML-CSS\Senac\ProjetoIntegradorII\PossoBeber\Views\Remedios\Buscar.cshtml"
WriteAttributeValue("", 1451, u.Id, 1451, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Excluir</a>\n                </p>\n");
#nullable restore
#line 60 "C:\HTML-CSS\Senac\ProjetoIntegradorII\PossoBeber\Views\Remedios\Buscar.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </div>\n");
#nullable restore
#line 64 "C:\HTML-CSS\Senac\ProjetoIntegradorII\PossoBeber\Views\Remedios\Buscar.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n");
#nullable restore
#line 67 "C:\HTML-CSS\Senac\ProjetoIntegradorII\PossoBeber\Views\Remedios\Buscar.cshtml"
     if (Context.Session.GetInt32("IdUsuario") == null)
    {

        //usuario deslogado ve isso



    }
    else
    {

        //usuario logado ve isso

#line default
#line hidden
#nullable disable
            WriteLiteral("        <a class=\"btn btn-success\" href=\"/Remedios/Inserir\">Adicionar Medicamento</a>\n");
#nullable restore
#line 80 "C:\HTML-CSS\Senac\ProjetoIntegradorII\PossoBeber\Views\Remedios\Buscar.cshtml"

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Remedios>> Html { get; private set; }
    }
}
#pragma warning restore 1591
