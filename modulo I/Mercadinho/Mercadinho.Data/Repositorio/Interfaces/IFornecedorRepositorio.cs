using Mercadinho.Data.Modelo;
using System;
using System.Collections.Generic;

namespace Mercadinho.Data.Repositorio.Interfaces
{
    public interface IFornecedorRepositorio
    {
        IEnumerable<Fornecedor> ObterAtivos();
        void EfetuarRecevimento(int id, int quantidade);
    }
}
