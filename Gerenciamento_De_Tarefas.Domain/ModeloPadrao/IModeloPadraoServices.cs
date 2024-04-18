using Gerenciamento_De_Tarefas.Domain.UsuarioModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciamento_De_Tarefas.Domain.ModeloPadrao
{
    public interface IModeloPadraoServices <T> where T : class
    {
        void Add(T objeto);
        void Update(T objeto);
        void Delete(T objeto);
        T Get(int id);
        List<T> GetAll();
    }
}
