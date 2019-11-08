using Mercadinho.Data.Modelo;
using Mercadinho.Data.Repositorio.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Mercadinho.Data.Repositorio
{
    public class ProdutoRepositorio : RepositorioBase<Produto>, IProdutoRepositorio
    {
        public bool EstaAtivado(int id) => MercadinhoContexto.Produtos.Where(p => p.Id == id && p.Ativo).Any();

        public bool EstaAtivado(string codigo) => MercadinhoContexto.Produtos.Where(p => p.Codigo == codigo && p.Ativo).Any();

        public IEnumerable<Produto> ObterAtivos() => ObterTodos().Where(a => a.Ativo).ToList();
    }
}
