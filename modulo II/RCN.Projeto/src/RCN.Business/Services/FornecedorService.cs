using RCN.Business.Interfaces;
using RCN.Business.Interfaces.Services;
using RCN.Business.Model;
using RCN.Business.Notificacoes;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using RCN.Business.Validations;
using FluentValidation.Results;

namespace RCN.Business.Services
{
    public class FornecedorService : BaseService, IFornecedorService
    {
        private readonly IFornecedorRepository _fornecedorRepository;
        public FornecedorService(IFornecedorRepository fornecedorRepository, INotificador notificador)
            : base(notificador)
        {
            _fornecedorRepository = fornecedorRepository;
        }
        public async Task<bool> Apagar(Fornecedor fornecedor)
        {
            await _fornecedorRepository.Apagar(fornecedor);
            return true;
        }

        public async Task<bool> Editar(Fornecedor fornecedor)
        {
            //Validar se o documento é valido (CPF/CNPJ)
            if (!EfetuarValidacao(new FornecedorValidation(), fornecedor)) return false;

            //Validar se ja existe registro com o documento
            if (_fornecedorRepository
                .Buscar(f => f.Documento == fornecedor.Documento && f.Id != fornecedor.Id).Result.Any())
            {
                Notificar("Já existe um fornecedor com este documento");
                return false;
            }

            await _fornecedorRepository.Editar(fornecedor);
            return true;
        }

        public async Task<bool> Inserir(Fornecedor fornecedor)
        {
            //Validar se o documento é valido (CPF/CNPJ)
            if (!EfetuarValidacao(new FornecedorValidation(), fornecedor)) return false;

            //Validar se ja existe registro com o documento
            if (_fornecedorRepository.Buscar(f => f.Documento == fornecedor.Documento).Result.Any())
            {
                Notificar("Já existe um fornecedor com este documento");
                return false;
            }

            await _fornecedorRepository.Inserir(fornecedor);
            return true;
        }

        public void Dispose()
        {
            _fornecedorRepository.Dispose();
        }
    }
}
