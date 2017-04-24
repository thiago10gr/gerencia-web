using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;


namespace Projeto.Web.Models
{
    public class HomeViewModelLogin
    {
        [Required(ErrorMessage = "Por favor, informe o email de acesso.")]
        [Display(Name = "Email de Acesso")]
        public string EmailAcesso { get; set; }

        [Required(ErrorMessage = "Por favor, informe a senha de acesso.")]
        [Display(Name = "Senha de Acesso")]
        public string SenhaAcesso { get; set; }
    }
}