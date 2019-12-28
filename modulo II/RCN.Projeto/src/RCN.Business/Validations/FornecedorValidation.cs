using FluentValidation;
using RCN.Business.Model;
using System;
using System.Collections.Generic;
using System.Text;
using static RCN.Business.Validations.Personalizados.Documentos;

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
                RuleFor(f => f.Documento.Length).Equal(CpfValidacao.TamanhoCpf)
                .WithMessage("O documento precisa ter 11 caracteres");

                RuleFor(f => CpfValidacao.Validar(f.Documento)).Equal(true)
                .WithMessage("CPF inválido");
            });

            When(f => f.TipoFornecedor == TipoFornecedor.Juridica, () =>
            {
                RuleFor(f => f.Documento.Length).Equal(CnpjValidacao.TamanhoCnpj)
                .WithMessage("O documento precisa ter 14 caracteres");

                RuleFor(f => CnpjValidacao.Validar(f.Documento)).Equal(true)
                .WithMessage("CNPJ inválido");
            });
        }
    }
}
