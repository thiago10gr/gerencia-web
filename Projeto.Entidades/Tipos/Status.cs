using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel;

namespace Projeto.Entidades.Tipos
{
    public enum Status
    {
        [Description("Aberto")]
        Aberto = 1,
        [Description("Concluído")]
        Concluido = 2,
        [Description("Fechado")]
        Fechado = 3
    }
}
