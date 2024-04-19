using Gerenciamento_De_Tarefas.Domain.TarefasModel;
using Gerenciamento_De_Tarefas.Domain.UsuarioModel;

namespace Gerenciamento_De_Tarefas.Domain.ModeloPadrao
{
    public class ServicoUsuario : IModeloPadraoServices<Usuario>
    {
        private readonly IModeloPadraoRepositorio<Usuario> _modeloPadraoRepositorio;

        public ServicoUsuario(IModeloPadraoRepositorio<Usuario> modeloPadraoRepositorio)
        {
            _modeloPadraoRepositorio = modeloPadraoRepositorio;
        }

        public void Add(Usuario objeto)
        {
            _modeloPadraoRepositorio.Add(objeto);
        }

        public void Delete(int id)
        {
            var usuario = Get(id);
            _modeloPadraoRepositorio.Delete(usuario);
        }

        public Usuario Get(int id)
        {
            return _modeloPadraoRepositorio.Get(id);
        }

        public List<Usuario> GetAll()
        {
            return _modeloPadraoRepositorio.GetAll();
        }

        public void Update(Usuario objeto)
        {
            _modeloPadraoRepositorio.Update(objeto);
        }
    }
}
