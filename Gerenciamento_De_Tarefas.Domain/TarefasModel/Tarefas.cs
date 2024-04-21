using Gerenciamento_De_Tarefas.Domain.Enums;
using Gerenciamento_De_Tarefas.Domain.UsuarioModel;

namespace Gerenciamento_De_Tarefas.Domain.TarefasModel
{
    public class Tarefas
    {
        public int  Id { get; set; }
        public string Descricao { get; set; }
        public StatusEnum Status { get; set;}
        public Usuario Usuario { get; set;}
        public DateTime DataInicial { get; set;}
        public DateTime DataFinal { get; set;}
        
    }
}
