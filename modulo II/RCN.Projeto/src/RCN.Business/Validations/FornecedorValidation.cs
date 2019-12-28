using FluentValidation;
using RCN.Business.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace RCN.Business.Validations
{
    public class FornecedorValidation : AbstractValidator<Fornecedor>
    {
        public FornecedorValidation()
        {
            RuleFor(f => f.Nome)
                .Length(2, 100).WithMessage("Nome precisa ter entre 2 e 100 caracteres")
                .NotEmpty().WithMessage("Nome precisa ser fornecido");


            When(f => f.TipoFornecedor == TipoFornecedor.Fisica, () =>
            {
                RuleFor(f => f.Documento.Length).Equal(11)
                       .WithMessage("O documento precisa ter 11 caracteres");
            });

            When(f => f.TipoFornecedor == TipoFornecedor.Juridica, () =>
            {
                RuleFor(f => f.Documento.Length).Equal(14)
                       .WithMessage("O documento precisa ter 14 caracteres");
            });
        }
    }
}
