using Mercadinho.Data.Modelo;
using System.Collections.Generic;

namespace Mercadinho.Data.Repositorio.Interfaces
{
    public interface IProdutoRepositorio
    {
        bool EstaAtivado(int id);
        bool EstaAtivado(string codigo);
        IEnumerable<Produto> ObterAtivos();
    }
}
