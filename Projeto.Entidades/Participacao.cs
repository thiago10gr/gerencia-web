using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Entidades
{
    public class Participacao
    {
        public int IdProjeto { get; set; }
        public int IdUsuario { get; set; }

        public Projeto Projeto { get; set; }
        public Usuario Usuario { get; set; }


        public Participacao()
        {
                
        }

    }
}
