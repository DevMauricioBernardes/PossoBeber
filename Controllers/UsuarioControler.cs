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
    public class UsuarioController : Controller
    {
        public IActionResult Login(){
            return View();
        }
        [HttpPost]
        public IActionResult Login(Usuario usuario){
            
            UsuarioRepository ur = new UsuarioRepository();
            Usuario usuarioSessao = ur.ValidarLogin(usuario);
            
            if (usuarioSessao==null){
                
                ViewBag.mensagem = "Login e senha errados";
                return View();
            } else{
                //login localizado

                // mensagem
                ViewBag.mensagem = "Você está logado";

                //registra na sessao os dados do usuario
                HttpContext.Session.SetInt32("IdUsuario",usuarioSessao.Id);
                HttpContext.Session.SetString("NomeUsuario",usuarioSessao.Nome);

                //redirecionamento
                
                return View(); //RedirectToAction("Lista");
            }
        }
        public IActionResult Logout(){

            // limpar todos os dados da sessao
            HttpContext.Session.Clear();

            //redirecionamento
            return View ("Login");
        }
        public IActionResult Lista(){
            
            //Validando se o usuario esta logado
            if(HttpContext.Session.GetInt32("IdUsuario")==null){
                return RedirectToAction("Login","Usuario");
            } 

            UsuarioRepository ur = new UsuarioRepository();
            List<Usuario> lista = ur.Listar();
            return View(lista);
            
        }
        public IActionResult Excluir(int Id){

            //Validando se o usuario esta logado
            if(HttpContext.Session.GetInt32("IdUsuario")==null){
                return RedirectToAction("Login","Usuario");
            } 

            UsuarioRepository ur = new UsuarioRepository();
            Usuario userEncontrado = ur.Buscar(Id);

            
            if (userEncontrado.Id>0){
                ur.remover(userEncontrado);
            } else
            {
                ViewData["mensagem"] = "Usuario não localizado";
            }

            return RedirectToAction("Lista");

        }
        public IActionResult Inserir(){
            return View();

        }
        [HttpPost]
        public IActionResult Inserir(Usuario novoUser){
            
            UsuarioRepository ur = new UsuarioRepository();
            ur.inserir(novoUser);
            
            ViewData["mensagem"] = "Cadastro realizado com sucesso";
            return View();

        }
        public IActionResult Alterar(int Id){

            //Validando se o usuario esta logado
            if(HttpContext.Session.GetInt32("IdUsuario")==null){
                return RedirectToAction("Login","Usuario");
            } 

            UsuarioRepository ur = new UsuarioRepository();
            Usuario userEncontrado = ur.Buscar(Id);

            return View(userEncontrado);

        }

        [HttpPost]
        public IActionResult Alterar(Usuario usuario){

            UsuarioRepository ur = new UsuarioRepository();
            ur.atualizar(usuario);

            return RedirectToAction("Lista");
        }            
    }
}