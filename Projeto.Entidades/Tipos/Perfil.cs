using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel;

namespace Projeto.Entidades.Tipos
{
    public enum Perfil
    {
        [Description("Administrador")]
        Administrador = 1,
        [Description("Gerente")]
        Gerente = 2,
        [Description("Colaborador")]
        Colaborador = 3

    }
}
