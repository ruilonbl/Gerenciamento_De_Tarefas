using FluentValidation;
using Gerenciamento_De_Tarefas.Domain.UsuarioModel;

namespace Gerenciamento_De_Tarefas.Domain.Validacoes
{
    public class ValidacaoUsuario : AbstractValidator<Usuario>
    {
        public ValidacaoUsuario()
        {
            RuleFor(p => p.Nome)
                .NotEmpty()
                .WithMessage("É obrigatio informar o nomne");
        }
    }
}
