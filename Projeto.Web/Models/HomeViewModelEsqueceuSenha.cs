using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;

namespace Projeto.Web.Models
{
    public class HomeViewModelEsqueceuSenha
    {
        [Required(ErrorMessage = "Por favor, informe o email de acesso.")]
        [Display(Name = "Email de Acesso")]
        public string Email { get; set; }
    }
}