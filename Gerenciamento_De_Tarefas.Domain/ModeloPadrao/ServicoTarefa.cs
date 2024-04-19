using Gerenciamento_De_Tarefas.Domain.TarefasModel;

namespace Gerenciamento_De_Tarefas.Domain.ModeloPadrao
{
    public class ServicoTarefa : IModeloPadraoServices<Tarefas>
    {
        private readonly IModeloPadraoRepositorio<Tarefas> _modeloPadraoRepositorio;

        public ServicoTarefa(IModeloPadraoRepositorio<Tarefas> modeloPadraoRepositorio)
        {
            _modeloPadraoRepositorio = modeloPadraoRepositorio;
        }

        public void Add(Tarefas objeto)
        {
            _modeloPadraoRepositorio.Add(objeto);
        }

        public void Delete(int id)
        {
            var tarefas = Get(id);
            _modeloPadraoRepositorio.Delete(tarefas);
        }

        public Tarefas Get(int id)
        {
            return _modeloPadraoRepositorio.Get(id);
        }

        public List<Tarefas> GetAll()
        {
            return _modeloPadraoRepositorio.GetAll();
        }

        public void Update(Tarefas objeto)
        {
            _modeloPadraoRepositorio.Update(objeto);
        }
    }
}
