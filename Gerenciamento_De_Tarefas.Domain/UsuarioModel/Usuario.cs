using Gerenciamento_De_Tarefas.Domain.TarefasModel;
using System.Text.Json.Serialization;

namespace Gerenciamento_De_Tarefas.Domain.UsuarioModel
{
    public sealed class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set;}
        public string Senha { get; set; }

        public ICollection<Tarefas>? Tarefas { get; private set; } = new List<Tarefas>();

        //public ICollection<Tarefas>? tarefas
        //{
        //    set
        //    {
        //        Tarefas = new List<Tarefas>();
        //    }
        //}

    }
}
