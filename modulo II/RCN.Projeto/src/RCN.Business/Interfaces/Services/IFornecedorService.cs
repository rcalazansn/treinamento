using RCN.Business.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RCN.Business.Interfaces.Services
{
    public interface IFornecedorService : IDisposable
    {
        Task<bool> Inserir(Fornecedor fornecedor);
        Task<bool> Editar(Fornecedor fornecedor);
        Task<bool> Apagar(Fornecedor fornecedor);
    }
}
