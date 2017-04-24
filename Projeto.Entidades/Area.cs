using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Entidades.Tipos;

namespace Projeto.Entidades
{
    //Área demandante
    public class Area
    {
        public int IdArea { get; set; }
        public string Nome { get; set; }
        public string Documento { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Observacoes { get; set; }
        public TipoArea TipoArea { get; set; }

        public List<Projeto> Projetos { get; set; }

        public Area()
        {

        }

        public Area(int idArea, string nome, string documento, string telefone, string email, string observacoes, TipoArea tipoArea)
        {
            IdArea = idArea;
            Nome = nome;
            Documento = documento;
            Telefone = telefone;
            Email = email;
            Observacoes = observacoes;
            TipoArea = tipoArea;
        }
    }
}
