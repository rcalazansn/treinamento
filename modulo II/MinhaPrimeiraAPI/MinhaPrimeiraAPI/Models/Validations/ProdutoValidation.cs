using FluentValidation;

namespace MinhaPrimeiraAPI.Models.Validations
{
    public class ProdutoValidation : AbstractValidator<Produto>
    {
        public ProdutoValidation()
        {
            RuleFor(p => p.Descricao)
                .NotEmpty()
                .Length(4, 5)
                .WithMessage("Descrição precisa ser informada");

            RuleFor(p => p.Valor)
                .NotEmpty()
                .WithMessage("Valor precisa ser informado");
        }
    }
}
