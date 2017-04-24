using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel;

namespace Projeto.Entidades.Tipos
{
    public enum TipoArea
    {        [Description("Pessoa Física")]        PessoaFisica = 1,        [Description("Pessoa Jurídica")]        PessoaJuridica = 2
    }
}
