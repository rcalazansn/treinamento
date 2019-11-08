using Mercadinho.Data.Modelo;
using Mercadinho.Data.Repositorio.Interfaces;

namespace Mercadinho.Data.Repositorio
{
    public class EstoqueRepositorio : RepositorioBase<Estoque>, IEstoqueRepositorio
    {
        public void EfetuarRecevimento(int produtoId, int quantidade)
        {
            var estoque = Obter(produtoId);

            if (estoque == null)
            {
                estoque.Id = produtoId;
                estoque.QtdeAtual = quantidade;

                int qtdeMinima = (quantidade - 3);
                estoque.QtdeMinima = qtdeMinima <= 0 ? 1 : qtdeMinima;

                Inserir(estoque);
            }
            else
            {
                estoque.QtdeAtual += quantidade;
                Editar(estoque);
            }
        }

        public void EfetuarVenda(int produtoId, int quantidade)
        {
            var estoque = Obter(produtoId);

            estoque.QtdeAtual -= quantidade;
            Editar(estoque);
        }
    }
}
