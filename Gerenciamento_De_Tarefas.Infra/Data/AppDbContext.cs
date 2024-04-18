using Gerenciamento_De_Tarefas.Domain.TarefasModel;
using Gerenciamento_De_Tarefas.Domain.UsuarioModel;
using Microsoft.EntityFrameworkCore;

namespace Gerenciamento_De_Tarefas.Infra.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {
        }

        public DbSet<Tarefas> Tarefas { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
    }
}
