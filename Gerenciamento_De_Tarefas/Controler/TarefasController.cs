using Gerenciamento_De_Tarefas.Domain.ModeloPadrao;
using Gerenciamento_De_Tarefas.Domain.TarefasModel;
using Gerenciamento_De_Tarefas.Domain.UsuarioModel;
using Microsoft.AspNetCore.Mvc;

namespace Gerenciamento_De_Tarefas.Controler
{
    [Route("api/[controller]")]
    [ApiController]
    public class TarefasController : Controller
    {
        private IModeloPadraoServices<Tarefas> _modeloPadraoServices;

        public TarefasController(IModeloPadraoServices<Tarefas> modeloPadraoServices)
        {
            _modeloPadraoServices = modeloPadraoServices;
        }

        [HttpGet("obter-tarefas")]
        public OkObjectResult ObterTodos()
        {
            var usuarios = _modeloPadraoServices.GetAll();
            return Ok(usuarios);
        }

        [HttpGet("obter-tarefas-por-id/{id}")]
        public OkObjectResult OberPorId(int id)
        {
            var usuarios = _modeloPadraoServices.Get(id);
            return Ok(usuarios);
        }

        [HttpPost("criar-tarefas")]
        public OkObjectResult Criar([FromBody] Tarefas tarefas)
        {
            _modeloPadraoServices.Add(tarefas);
            return Ok(tarefas);
        }
        [HttpDelete("remover-usuario/{id}")]
        public OkResult Remover(int id)
        {
            _modeloPadraoServices.Delete(id);
            return Ok();
        }

        [HttpPut("editar-tarefas")]
        public OkResult Editar([FromBody] Tarefas tarefas)
        {
            _modeloPadraoServices.Update(tarefas);
            return Ok();
        }

    }
}
