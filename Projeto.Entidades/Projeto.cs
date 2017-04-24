using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Projeto.Entidades.Tipos;

namespace Projeto.Entidades
{
    public class Projeto
    {
        public int IdProjeto { get; set; }
        public string Nome { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public Status Status { get; set; }

        public int IdArea { get; set; }
        public int IdGrupo { get; set; }
        
        public Area Area { get; set; }
        public Grupo Grupo { get; set; }

        public List<Tarefa> Tarefas { get; set; }

        //Participação dos usuários no projeto
        public List<Participacao> Participacoes { get; set; }

        public Projeto()
        {
                
        }

        public Projeto(int idProjeto, string nome, DateTime dataInicio, DateTime dataFim, Status status)
        {
            IdProjeto = idProjeto;
            Nome = nome;
            DataInicio = dataInicio;
            DataFim = dataFim;
            Status = status;
        }
    }
}
