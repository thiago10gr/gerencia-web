using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Projeto.Entidades.Tipos;

namespace Projeto.Entidades
{
    public class Tarefa
    {
        public int IdTarefa { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public int HorasEstimadas { get; set; }
        public int HorasTrabalhadas { get; set; }
        public Status Status { get; set; }

        public int IdProjeto { get; set; }

        public Projeto Projeto { get; set; }

        public Tarefa()
        {

        }

        public Tarefa(int idTarefa, string titulo, string descricao, DateTime dataInicio, DateTime dataFim, int horasEstimadas, int horasTrabalhadas, Status status)
        {
            IdTarefa = idTarefa;
            Titulo = titulo;
            Descricao = descricao;
            DataInicio = dataInicio;
            DataFim = dataFim;
            HorasEstimadas = horasEstimadas;
            HorasTrabalhadas = horasTrabalhadas;
            Status = status;
        }
    }
}
