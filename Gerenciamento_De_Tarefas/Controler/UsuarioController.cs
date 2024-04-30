using Gerenciamento_De_Tarefas.Domain.ModeloPadrao;
using Gerenciamento_De_Tarefas.Domain.TarefasModel;
using Gerenciamento_De_Tarefas.Domain.UsuarioModel;
using Microsoft.AspNetCore.Mvc;

namespace Gerenciamento_De_Tarefas.Controler
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : Controller
    {
        private IModeloPadraoServices<Usuario> _modeloPadraoServices;

        public UsuarioController(IModeloPadraoServices<Usuario> modeloPadraoServices)
        {
            _modeloPadraoServices = modeloPadraoServices;
        }

        [HttpGet("obter-usuarios")]
        public OkObjectResult ObterTodos()
        {
            var usuarios = _modeloPadraoServices.GetAll();
            return Ok(usuarios);
        }

        [HttpGet("obter-usuarios-por-id/{id}")]
        public OkObjectResult OberPorId(int id)
        {
            var usuarios = _modeloPadraoServices.Get(id);
            return Ok(usuarios);
        }

        [HttpPost("criar-usuarios")]
        public OkObjectResult Criar([FromBody] Usuario usuario)
        {
            _modeloPadraoServices.Add(usuario);
            return Ok(usuario);
        }

        [HttpDelete("remover-usuarios/{id}")]
        public OkResult Remover(int id)
        {
            _modeloPadraoServices.Delete(id);
            return Ok();
        }

        [HttpPut("editar-usuarios")]
        public OkResult Editar([FromBody] Usuario usuario)
        {
            _modeloPadraoServices.Update(usuario);
            return Ok();
        }
    }
}
