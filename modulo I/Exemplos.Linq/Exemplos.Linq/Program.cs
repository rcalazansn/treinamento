using System;
using System.Collections.Generic;

namespace Exemplos.Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto retorno;
            IEnumerable<Produto> ListaRetorno;
            int quantidadeItens;

            Console.WriteLine("Carregando lista de produtos...");

            IList<Produto> Produtos = new List<Produto>();
            Produtos.Add(new Produto(95971, "Notebook Gamer Acer Aspire", 3899.90M));
            Produtos.Add(new Produto(99683, "Processador Intel Core i5", 799.90M));
            Produtos.Add(new Produto(104747, "iPhone 11 Branco", 5103.12M));
            Produtos.Add(new Produto(95566, "Mouse Gamer HyperX Pulsefire Surge RGB", 309.90M));
            Produtos.Add(new Produto(99866, "Monitor LG LED 23", 799.99M));
            Produtos.Add(new Produto(81132, "Headset Gamer HyperX", 231.47M));
            Produtos.Add(new Produto(98185, "Headset Gamer HyperX", 231.47M));
            Produtos.Add(new Produto(99866, "Monitor LG LED 23", 699.99M));


            Linq linq = new Linq();

            retorno = linq.RetornarPrimeiroItem(Produtos);
           // retorno = linq.RetornarPrimeiroItem(new List<Produto>());

           // retorno = linq.RetornarPrimeiroItemOuNull(Produtos);
           // retorno = linq.RetornarPrimeiroItemOuNull(new List<Produto>());

           // retorno = linq.RetornarUnicoRegistro(Produtos);
            //retorno = linq.RetornarUnicoRegistro(new List<Produto>());

            //retorno = linq.RetornarUnicoRegistroOuNull(Produtos);
            //retorno = linq.RetornarUnicoRegistroOuNull(new List<Produto>());

            //ListaRetorno = linq.RetornarListaOrdenadaDescricaoAsc(Produtos);
            //ListaRetorno = linq.RetornarListaOrdenadaDescricaoDesc(Produtos);

            //quantidadeItens = linq.RetornaQuantidadeItens(Produtos);
           // quantidadeItens = linq.RetornaQuantidadeItens(new List<Produto>());

           // retorno = linq.RetornaItemCasoExista(Produtos, 5);

           // bool exite = linq.VerificaSeItemExiste(Produtos, 6);
          //  bool naoExite = linq.VerificaSeItemExiste(Produtos, 65);

             //var listaInterio = linq.RetornaListaInteiroRemovendoDuplicados();

            Console.ReadKey();
        }
    }
}
