using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciamento_De_Tarefas.Domain.UsuarioModel
{
    public interface IUsuarioRepositorio
    {
        void Add(Usuario usuario);
        void Update(Usuario usuario);
        void Delete(Usuario usuario);
        Usuario Get(int id);
        List<Usuario> GetAll(string? filtro);
    }
}
