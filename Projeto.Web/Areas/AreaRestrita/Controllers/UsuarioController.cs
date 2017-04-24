using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

using Projeto.Web.Areas.AreaRestrita.Security;
using Projeto.Entidades;
using Projeto.Armazenamento.Repositorios;
using Projeto.Web.Areas.AreaRestrita.Models;
using Projeto.Util;

namespace Projeto.Web.Areas.AreaRestrita.Controllers
{
    //Não permite acesso de usuários anônimos
    // [Authorize]
    [PermissoesFiltro(Roles = "Administrador")]
    public class UsuarioController : Controller
    {
        // GET: AreaRestrita/Usuario
        public ActionResult Index()
        {
            return View();
        }
        // GET: AreaRestrita/Usuario/Projetos
        [PermissoesFiltro(Roles = "Administrador")]
        public ActionResult Projetos()
        {
            return View();
        }

        // GET: AreaRestrita/Usuario/Projetos
        [PermissoesFiltro(Roles = "Administrador")]
        public ActionResult Funcionarios()
        {
            return View();
        }

        [PermissoesFiltro(Roles = "Administrador, Gerente, Colaborador")]
        public ActionResult Perfil()
        {
       
            Usuario usuarioSessao = (Usuario)Session["usuario"];
            UsuarioRepositorio rep = new UsuarioRepositorio();

            Usuario u = rep.ObterPorId(usuarioSessao.IdUsuario);

            UsuarioViewModelPerfil model = new UsuarioViewModelPerfil();

            model.IdUsuario = u.IdUsuario;
            model.Nome = u.Nome;
            model.Email = u.Email;
            model.Telefone = u.Telefone;
            model.Celular = u.Celular;
            model.DataCadastro = u.DataCadastro;

            model.IdGrupo = u.IdGrupo;
            model.Ativo = u.Ativo;
            model.Perfil = u.Perfil;

            return View(model);
        }

        [HttpPost]
        public ActionResult Perfil(UsuarioViewModelPerfil model)
        {

            if(ModelState.IsValid)
            {
                try
                {

                    Criptografia c = new Criptografia();

                    Usuario u = new Usuario();

                    u.IdUsuario = model.IdUsuario;
                    u.Nome = model.Nome.ToUpper();
                    u.Email = model.Email.ToUpper();
                    u.Telefone = model.Telefone;
                    u.Celular = model.Celular;
                    u.DataCadastro = model.DataCadastro;
                    u.IdGrupo = model.IdGrupo;
                    u.Ativo = model.Ativo;
                    u.Perfil = model.Perfil;
                    u.Senha = c.EncriptarSenha(model.Senha);

                    UsuarioRepositorio rep = new UsuarioRepositorio();

                    rep.Atualizar(u);

                    ViewBag.MsgSucesso = "Usuário atualizado com sucesso.";
                }
                catch (Exception e)
                {
                    ViewBag.MsgErro = "Erro: " + e.Message;
                }
            }

            return View(new UsuarioViewModelPerfil());
        }

    }

   


}