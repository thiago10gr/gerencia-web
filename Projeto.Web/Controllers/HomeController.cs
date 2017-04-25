using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Projeto.Web.Models;
using Projeto.Armazenamento.Repositorios;
using Projeto.Entidades;
using Projeto.Util;
using System.Web.Security; //FormsAuthenticationTicket

namespace Projeto.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home/Login
        public ActionResult Login()
        {
            return View();
        }

        // GET: Home/AcessoNegado
        public ActionResult AcessoNegado()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(HomeViewModelLogin model)
        {

            if (ModelState.IsValid)
            {
                try
                {
                    UsuarioRepositorio rep = new UsuarioRepositorio();

                    Criptografia c = new Criptografia();

                    Usuario u = rep.ObterPorEmailSenha(model.EmailAcesso, c.EncriptarSenha(model.SenhaAcesso));

                    if (u != null)
                    {
                        //ticket de acesso do usuario 
                        FormsAuthenticationTicket ticket = new FormsAuthenticationTicket(u.IdUsuario.ToString(), false, 5);

                        //criando um cookie para gravar o tiket do usuario
                        HttpCookie cookie = new HttpCookie(FormsAuthentication.FormsCookieName, FormsAuthentication.Encrypt(ticket));

                        Response.Cookies.Add(cookie);

                        Session.Add("usuario", u);

                        return RedirectToAction("Index", "Usuario", new { area = "AreaRestrita" });

                    }
                    else
                    {
                        ViewBag.MsgErro = "Acesso Negado. Tente novamente.";
                    }
                }
                catch (Exception e)
                {
                    ViewBag.MsgErro = e.Message;
                }

            }

            return View();
        }

        // GET: Home/Logout
        public ActionResult Logout()
        {
            //destruir o ticket do usuario..
            FormsAuthentication.SignOut();

            //redirecionar para a página de login..
            return RedirectToAction("Login", "Home", new { area = "" });
        }

        // GET : Home/EsqueceuSenha
        public ActionResult EsqueceuSenha()
        {
            return View();
        }

        [HttpPost]
        public ActionResult EsqueceuSenha(HomeViewModelEsqueceuSenha model)
        {
            return View();
        }
    }
}