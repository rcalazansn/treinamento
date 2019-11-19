using MinhaPrimeiraAPI.Models;
using System.Collections.Generic;

namespace MinhaPrimeiraAPI.DAL
{
    public interface IProdutoRepository
    {
        void Adicionar(Produto produto);
        void Editar(Produto produto);
        void Apagar(Produto produto);
        Produto Obter(int id);
        IEnumerable<Produto> Obter();
    }
}
