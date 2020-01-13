using FluentValidation;
using RCN.Business.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace RCN.Business.Validations
{
    public class ProdutoValidation : AbstractValidator<Produto>
    {
        public ProdutoValidation()
        {
            RuleFor(p => p.Nome)
               .Length(2, 200).WithMessage("Nome precisa ter entre 2 e 100 caracteres")
               .NotEmpty().WithMessage("Nome precisa ser fornecido");

            RuleFor(p => p.Descricao)
               .Length(2, 1000).WithMessage("Descrição precisa ter entre 2 e 100 caracteres")
               .NotEmpty().WithMessage("Descrição precisa ser fornecido");
        }
    }
}
