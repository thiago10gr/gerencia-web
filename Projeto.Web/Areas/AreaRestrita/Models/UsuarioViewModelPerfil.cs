using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;
using Projeto.Entidades.Tipos;
using System.Web.Mvc;
using Projeto.Armazenamento.Repositorios;
using Projeto.Entidades;

namespace Projeto.Web.Areas.AreaRestrita.Models
{
    public class UsuarioViewModelPerfil
    {
        [Required(ErrorMessage = "Informe o ID do usuário")]
        public int IdUsuario { get; set; }

        [Required(ErrorMessage = "Informe o nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Informe o email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Informe o senha")]
        public string Senha { get; set; }


        [System.ComponentModel.DataAnnotations.Schema.NotMapped] // Does not effect with your database
        [System.ComponentModel.DataAnnotations.CompareAttribute("Senha", ErrorMessage = "As senhas não conferem.")]
        [Required(ErrorMessage = "Repita a senha")]

        public string ReSenha { get; set; }

        [Required(ErrorMessage = "Informe se está ativo ou não")]
        public SimNao Ativo { get; set; }

        [Required(ErrorMessage = "Informe o perfil")]
        public Perfil Perfil { get; set; }

        public DateTime DataCadastro { get; set; }

        public string Telefone { get; set; }

        public string Celular { get; set; }

        [Required(ErrorMessage = "Selecione o Grupo")]
        [Display(Name = "Grupo")] 
        public int IdGrupo { get; set; }

       
        public List<SelectListItem> ListagemGrupos
        {
            get
            {
                List<SelectListItem> lista = new List<SelectListItem>();

                GrupoRepositorio rep = new GrupoRepositorio();

                foreach (Grupo g in rep.ListarTodos())
                {
                    SelectListItem item = new SelectListItem();
                   
                    item.Text = g.Nome; 
                    item.Value = g.IdGrupo.ToString();
                   
                    lista.Add(item);
                }

                return lista;
            }
        }


      
        
    }

}
