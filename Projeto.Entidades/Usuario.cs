using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Projeto.Entidades.Tipos;

namespace Projeto.Entidades
{
    public class Usuario
    {


        public int IdUsuario { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public DateTime DataCadastro { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public SimNao Ativo { get; set; }
        public Perfil Perfil { get; set; }
        public byte ? Foto { get; set; }

        public int IdGrupo { get; set; }

        public Grupo Grupo { get; set; }

        //Participação dos usuários no projeto
        public List<Participacao> Participacoes { get; set; }

        

        public Usuario()
        {
                
        }

        public Usuario(int idUsuario, string nome, string email, DateTime dataCadastro, string telefone, string celular, SimNao ativo, Perfil perfil, byte foto)
        {
            IdUsuario = idUsuario;
            Nome = nome;
            Email = email;
            DataCadastro = dataCadastro;
            Telefone = telefone;
            Celular = celular;
            Ativo = ativo;
            Perfil = perfil;
            Foto = foto;
        }

       

    }
}
