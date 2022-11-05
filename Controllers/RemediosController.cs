using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using PossoBeber.Models;

namespace PossoBeber.Controllers
{
    public class RemediosController : Controller
    {
       public IActionResult Lista(){

            RemediosRepository ur = new RemediosRepository();
            List<Remedios> lista = ur.Listar();
            return View(lista);
            
        }
        [HttpPost]
        public IActionResult Buscar(string Nome){

            RemediosRepository ur = new RemediosRepository();
            List<Remedios> lista = ur.Buscar(Nome);
            ViewData["Nome"] = Nome;           
            return View(lista);
            
        }          

        public IActionResult Excluir(int Id){

            //Validando se o usuario esta logado
            if(HttpContext.Session.GetInt32("IdUsuario")==null){
                return RedirectToAction("Login","Usuario");
            } 
            
            RemediosRepository pt = new RemediosRepository();
            Remedios remedioEncontrado = pt.BuscarPorId(Id);

            
            if (remedioEncontrado.Id>0){
                pt.remover(remedioEncontrado);
            } else
            {
                ViewData["mensagem"] = "Medicamento não localizado";
            }

            return RedirectToAction("Lista");

        }

        public IActionResult Inserir(){

            if(HttpContext.Session.GetInt32("IdUsuario")==null){
                return RedirectToAction("Login","Usuario");
            } 
            
            return View();

        }

        [HttpPost]
        public IActionResult Inserir(Remedios novoRemedio){
            
            RemediosRepository pt = new RemediosRepository();
            pt.inserir(novoRemedio);
            
            ViewData["mensagem"] = "Medicamento cadastrado com sucesso";
            return View();

        }

        public IActionResult Alterar(int Id){

            //Validando se o usuario esta logado
            if(HttpContext.Session.GetInt32("IdUsuario")==null){
                return RedirectToAction("Login","Usuario");
            } 

            RemediosRepository pt = new RemediosRepository();
            Remedios remedioEncontrado = pt.BuscarPorId(Id);

            return View(remedioEncontrado);

        }

        [HttpPost]
        public IActionResult Alterar(Remedios remedio){

            RemediosRepository pt = new RemediosRepository();
            pt.atualizar(remedio);

            return RedirectToAction("Lista");

        }   

    }
}