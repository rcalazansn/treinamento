using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercadinho.Data.Repositorio.Interfaces
{
    public interface IEstoqueRepositorio
    {
        void EfetuarRecevimento(int produtoId, int quantidade);

        void EfetuarVenda(int produtoId, int quantidade);
    }
}
