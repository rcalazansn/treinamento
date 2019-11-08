using Mercadinho.Data.Modelo;
using Mercadinho.Data.Repositorio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Mercadinho.Data.Repositorio
{
    public class FornecedorRepositorio : RepositorioBase<Fornecedor>, IFornecedorRepositorio
    {
        public void EfetuarRecevimento(int id, int quantidade)
        {
            Fornecedor fornecedor = Obter(id);

            fornecedor.QuantidadeRecebimento = quantidade;
            fornecedor.DataRecebimento = DateTime.Now;

            Editar(fornecedor);
        }

        public IEnumerable<Fornecedor> ObterAtivos() => ObterTodos().Where(a => a.Ativo).ToList();
    }
}
