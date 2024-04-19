using Gerenciamento_De_Tarefas.Domain.ModeloPadrao;
using Gerenciamento_De_Tarefas.Domain.TarefasModel;
using Gerenciamento_De_Tarefas.Infra.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciamento_De_Tarefas.Infra.RepositorioPadrao
{
    public class TarefasRepositorio : IModeloPadraoRepositorio<Tarefas>
    {
        private AppDbContext _appDbContext;
        public TarefasRepositorio(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public void Add(Tarefas objeto)
        {
            _appDbContext.Add(objeto);
        }

        public void Delete(Tarefas objeto)
        {
            _appDbContext.Remove(objeto);
        }

        public Tarefas Get(int id)
        {
            return _appDbContext.Tarefas.FirstOrDefault(x => x.Id == id);
        }

        public List<Tarefas> GetAll()
        {
            return _appDbContext.Tarefas.ToList();
        }

        public void Update(Tarefas objeto)
        {
            _appDbContext.Update(objeto);
        }
    }
}
