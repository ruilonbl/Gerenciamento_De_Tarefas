using Gerenciamento_De_Tarefas.Domain.TarefasModel;
using System.Text.Json.Serialization;

namespace Gerenciamento_De_Tarefas.Domain.UsuarioModel
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set;}
        public string Senha { get; set; }
        [JsonIgnore]
        public List<Tarefas>? Tarefas { get; set; }
    }
}
