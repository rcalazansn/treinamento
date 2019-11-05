using System.Collections.Generic;
using System.Linq;

namespace Exemplos.Linq
{
    public class Linq
    {
        /// <summary>
        /// Retorna o primerio item, caso não haja item na lista, gera exceção caso a lista esteja vazia
        /// </summary>
        /// <returns></returns>
        public Produto RetornarPrimeiroItem(IList<Produto> produtos)
        {
            return produtos.First();
        }

        /// <summary>
        /// Retorna o primerio item da lista, quando não houver itens na lista retorna null
        /// </summary>
        /// <returns></returns>
        public Produto RetornarPrimeiroItemOuNull(IList<Produto> produtos)
        {
            return produtos.FirstOrDefault();
        }

        /// <summary>
        /// Verifica se existe apenas um registro, caso haja mais de um registro igual é gerado uma exceção,
        /// caso não haja elementos é gerada uma exceção
        /// </summary>
        /// <param name="produtos"></param>
        /// <returns></returns>
        public Produto RetornarUnicoRegistro(IList<Produto> produtos)
        {
            return produtos.Single();
        }

        /// <summary>
        /// Verifica se existe apenas um registro, caso haja mais de um registro igual é gerado uma exceção,
        /// quando não houver itens na lista retorna null
        /// </summary>
        /// <param name="produtos"></param>
        /// <returns></returns>
        public Produto RetornarUnicoRegistroOuNull(IList<Produto> produtos)
        {
            return produtos.SingleOrDefault();
        }

        /// <summary>
        /// Retorna lista ordenada pela descrição ASC
        /// </summary>
        /// <param name="produtos"></param>
        /// <returns></returns>
        public IEnumerable<Produto> RetornarListaOrdenadaDescricaoAsc(IList<Produto> produtos)
        {
            return produtos.OrderBy(a => a.Descricao);
        }

        /// <summary>
        /// Retorna lista ordenada pela descrição DESC
        /// </summary>
        /// <param name="produtos"></param>
        /// <returns></returns>
        public IEnumerable<Produto> RetornarListaOrdenadaDescricaoDesc(IList<Produto> produtos)
        {
            return produtos.OrderByDescending(a => a.Descricao);
        }

        /// <summary>
        /// Retorna quantidade de itens na lista, caso não haja itens retorna quantidade zero
        /// </summary>
        /// <param name="produtos"></param>
        /// <returns></returns>
        public int RetornaQuantidadeItens(IList<Produto> produtos)
        {
            return produtos.Count;
        }

        /// <summary>
        /// Retorna item com o id (podendo ser utilizando, first, single, firstOrDefault ou singleOrDefault)
        /// dependendo da expressão utilizada, pode ou não gerar uma exceção ou NULL
        /// </summary>
        /// <param name="produtos"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public Produto RetornaItemCasoExista(IList<Produto> produtos, int id)
        {
            return produtos.Where(i => i.Id == id)
                .First();
            //.FirstOrDefault();
            //.Single();
            //.SingleOrDefault();
        }

        /// <summary>
        /// Verifica se item com id existe, caso exista retorna true caso contrario false
        /// </summary>
        /// <param name="produtos"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool VerificaSeItemExiste(IList<Produto> produtos, int id)
        {
            return produtos.Any(a => a.Id == id);
        }

        /// <summary>
        /// Retorna apenas a descricao do item (podendo ser utilizando, first, single, firstOrDefault ou singleOrDefault)
        /// dependendo da expressão utilizada, pode ou não gerar uma exceção ou NULL
        /// </summary>
        /// <param name="produtos"></param>
        /// <returns></returns>
        public string RetornaApenasDescricao(IList<Produto> produtos)
        {
            return produtos.Select(i => i.Descricao)
                .First();
            //.FirstOrDefault();
            //.Single();
            //.SingleOrDefault();
        }

        /// <summary>
        /// Retorna itens removendo os duplicados
        /// </summary>
        /// <param name="produtos"></param>
        /// <returns></returns>
        public IEnumerable<int> RetornaListaInteiroRemovendoDuplicados()
        {
            List<int> Inteiros = new List<int>();
            Inteiros.Add(1);
            Inteiros.Add(2);
            Inteiros.Add(2);
            Inteiros.Add(3);
            Inteiros.Add(3);
            Inteiros.Add(4);

            return Inteiros.Distinct();
        }
    }
}
