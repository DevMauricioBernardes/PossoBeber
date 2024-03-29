#pragma checksum "C:\HTML-CSS\Senac\ProjetoIntegradorII\PossoBeber\Views\Remedios\Lista.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1cb332df725c60f40252fd84b3c5e46270491a35"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Remedios_Lista), @"mvc.1.0.view", @"/Views/Remedios/Lista.cshtml")]
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
#line 1 "C:\HTML-CSS\Senac\ProjetoIntegradorII\PossoBeber\Views\Remedios\Lista.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1cb332df725c60f40252fd84b3c5e46270491a35", @"/Views/Remedios/Lista.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3632d328f67d785177563e23c5eca986f67129fb", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Remedios_Lista : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Remedios>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\HTML-CSS\Senac\ProjetoIntegradorII\PossoBeber\Views\Remedios\Lista.cshtml"
  
    ViewData["Title"] = "Lista";
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n");
#nullable restore
#line 10 "C:\HTML-CSS\Senac\ProjetoIntegradorII\PossoBeber\Views\Remedios\Lista.cshtml"
                  if (Context.Session.GetInt32("IdUsuario")==null)
                {  //usuario deslogado ve isso                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <th>Nome</th>\r\n                    <th>Posso beber?</th>\r\n                    <th>Descrição</th>                    \r\n");
#nullable restore
#line 15 "C:\HTML-CSS\Senac\ProjetoIntegradorII\PossoBeber\Views\Remedios\Lista.cshtml"
                }  else{ //usuario logado ve isso

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <th>Id</th>\r\n                    <th>Nome</th>\r\n                    <th>Posso beber?</th>\r\n                    <th>Descrição</th>                    \r\n                    <th>Usuário</th>\r\n                    <th>Editar</th>\r\n");
#nullable restore
#line 22 "C:\HTML-CSS\Senac\ProjetoIntegradorII\PossoBeber\Views\Remedios\Lista.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tr>\r\n        </thead>\r\n            \r\n        <tbody>\r\n");
#nullable restore
#line 27 "C:\HTML-CSS\Senac\ProjetoIntegradorII\PossoBeber\Views\Remedios\Lista.cshtml"
             foreach (Remedios u in Model)
            {                

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n");
#nullable restore
#line 30 "C:\HTML-CSS\Senac\ProjetoIntegradorII\PossoBeber\Views\Remedios\Lista.cshtml"
                     if (Context.Session.GetInt32("IdUsuario")==null)
                    {  //usuario deslogado ve isso                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>");
#nullable restore
#line 32 "C:\HTML-CSS\Senac\ProjetoIntegradorII\PossoBeber\Views\Remedios\Lista.cshtml"
                       Write(u.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 33 "C:\HTML-CSS\Senac\ProjetoIntegradorII\PossoBeber\Views\Remedios\Lista.cshtml"
                       Write(u.Posso);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 33 "C:\HTML-CSS\Senac\ProjetoIntegradorII\PossoBeber\Views\Remedios\Lista.cshtml"
                                      if (@u.Posso=="Sim")
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <img src=\"/img/ok.png\" alt=\"ok\" width=\"20\">\r\n");
#nullable restore
#line 36 "C:\HTML-CSS\Senac\ProjetoIntegradorII\PossoBeber\Views\Remedios\Lista.cshtml"
                        }else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <img src=\"/img/not.png\" alt=\"ok\" width=\"20\">\r\n");
#nullable restore
#line 39 "C:\HTML-CSS\Senac\ProjetoIntegradorII\PossoBeber\Views\Remedios\Lista.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </td>\r\n                        <td>");
#nullable restore
#line 41 "C:\HTML-CSS\Senac\ProjetoIntegradorII\PossoBeber\Views\Remedios\Lista.cshtml"
                       Write(u.Descricao);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>                                        \r\n");
#nullable restore
#line 42 "C:\HTML-CSS\Senac\ProjetoIntegradorII\PossoBeber\Views\Remedios\Lista.cshtml"
                    }  else{ //usuario logado ve isso

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>");
#nullable restore
#line 43 "C:\HTML-CSS\Senac\ProjetoIntegradorII\PossoBeber\Views\Remedios\Lista.cshtml"
                       Write(u.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 44 "C:\HTML-CSS\Senac\ProjetoIntegradorII\PossoBeber\Views\Remedios\Lista.cshtml"
                       Write(u.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 45 "C:\HTML-CSS\Senac\ProjetoIntegradorII\PossoBeber\Views\Remedios\Lista.cshtml"
                       Write(u.Posso);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 45 "C:\HTML-CSS\Senac\ProjetoIntegradorII\PossoBeber\Views\Remedios\Lista.cshtml"
                                      if (@u.Posso=="Sim")
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <img src=\"/img/ok.png\" alt=\"ok\" width=\"20\">\r\n");
#nullable restore
#line 48 "C:\HTML-CSS\Senac\ProjetoIntegradorII\PossoBeber\Views\Remedios\Lista.cshtml"
                        }else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <img src=\"/img/not.png\" alt=\"ok\" width=\"20\">\r\n");
#nullable restore
#line 51 "C:\HTML-CSS\Senac\ProjetoIntegradorII\PossoBeber\Views\Remedios\Lista.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </td>\r\n                        <td>");
#nullable restore
#line 53 "C:\HTML-CSS\Senac\ProjetoIntegradorII\PossoBeber\Views\Remedios\Lista.cshtml"
                       Write(u.Descricao);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>                    \r\n                        <td>");
#nullable restore
#line 54 "C:\HTML-CSS\Senac\ProjetoIntegradorII\PossoBeber\Views\Remedios\Lista.cshtml"
                       Write(u.Usuario);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>\r\n                            <a class=\"btn btn-warning\"");
            BeginWriteAttribute("href", " href=\"", 2227, "\"", 2260, 2);
            WriteAttributeValue("", 2234, "/Remedios/Alterar?Id=", 2234, 21, true);
#nullable restore
#line 56 "C:\HTML-CSS\Senac\ProjetoIntegradorII\PossoBeber\Views\Remedios\Lista.cshtml"
WriteAttributeValue("", 2255, u.Id, 2255, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Alterar</a> |\r\n                            <a  class=\"btn btn-danger\"");
            BeginWriteAttribute("href", " href=\"", 2331, "\"", 2364, 2);
            WriteAttributeValue("", 2338, "/Remedios/Excluir?Id=", 2338, 21, true);
#nullable restore
#line 57 "C:\HTML-CSS\Senac\ProjetoIntegradorII\PossoBeber\Views\Remedios\Lista.cshtml"
WriteAttributeValue("", 2359, u.Id, 2359, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Excluir</a>\r\n                        </td>                    \r\n");
#nullable restore
#line 59 "C:\HTML-CSS\Senac\ProjetoIntegradorII\PossoBeber\Views\Remedios\Lista.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tr>\r\n");
#nullable restore
#line 61 "C:\HTML-CSS\Senac\ProjetoIntegradorII\PossoBeber\Views\Remedios\Lista.cshtml"
            }            

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>    \r\n    </table>\r\n\r\n");
#nullable restore
#line 65 "C:\HTML-CSS\Senac\ProjetoIntegradorII\PossoBeber\Views\Remedios\Lista.cshtml"
 if (Context.Session.GetInt32("IdUsuario")==null){  
    //usuario deslogado ve isso

}  else{
    //usuario logado ve isso

#line default
#line hidden
#nullable disable
            WriteLiteral("    <a class=\"btn btn-success\" href=\"/Remedios/Inserir\">Adicionar Medicamento</a>\r\n");
#nullable restore
#line 71 "C:\HTML-CSS\Senac\ProjetoIntegradorII\PossoBeber\Views\Remedios\Lista.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Remedios>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
