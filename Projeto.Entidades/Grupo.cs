using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Projeto.Entidades.Tipos;

namespace Projeto.Entidades
{
    public class Grupo
    {
        public int IdGrupo { get; set; }
        public string Nome { get; set; }
        public DateTime DataCriacao { get; set; }
        public SimNao Ativo { get; set; }

        public List<Projeto> Projetos { get; set; }
        public List<Usuario> Usuarios { get; set; }

        public Grupo()
        {
                
        }

        public Grupo(int idGrupo, string nome, DateTime dataCriacao, SimNao ativo)
        {
            IdGrupo = idGrupo;
            Nome = nome;
            DataCriacao = dataCriacao;
            Ativo = ativo;
        }
    }
}
