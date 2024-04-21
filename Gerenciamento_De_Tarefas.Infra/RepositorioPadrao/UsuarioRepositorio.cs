using Gerenciamento_De_Tarefas.Domain.ModeloPadrao;
using Gerenciamento_De_Tarefas.Domain.UsuarioModel;
using Gerenciamento_De_Tarefas.Infra.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciamento_De_Tarefas.Infra.RepositorioPadrao
{
    public class UsuarioRepositorio : IModeloPadraoRepositorio<Usuario>
    {
        private AppDbContext _appDbContext;

        public UsuarioRepositorio(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public void Add(Usuario objeto)
        {
            _appDbContext.Add(objeto);
            _appDbContext.SaveChanges();
        }

        public void Delete(Usuario objeto)
        {
            _appDbContext.Remove(objeto);
        }

        public Usuario Get(int id)
        {
            return _appDbContext.Usuario.FirstOrDefault(x => x.Id == id);
        }

        public List<Usuario> GetAll()
        {
            return _appDbContext.Usuario.ToList();
        }

        public void Update(Usuario objeto)
        {
            _appDbContext.Update(objeto);
            _appDbContext.SaveChanges();
        }
    }
}
