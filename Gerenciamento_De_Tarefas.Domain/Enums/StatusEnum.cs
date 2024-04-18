using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciamento_De_Tarefas.Domain.Enums
{
    public enum StatusEnum
    {
        [Description("A fazer")]
        AFazer = 0,

        [Description("Em andamento")]
        EmAndamento = 1,

        [Description("Concluida")]
        Concluida = 2,

        [Description("Fechado")]
        Fechado = 3

    }
}
