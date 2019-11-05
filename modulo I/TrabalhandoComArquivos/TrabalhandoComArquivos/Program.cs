using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhandoComArquivos
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Iniciando...");

            ArquivoUtils arquivoUtils = new ArquivoUtils();

            //arquivoUtils.DiretorioExiste();

            //  arquivoUtils.ArquivoExiste();

            //arquivoUtils.InformacoesArquivo();

            //arquivoUtils.CriarDiretorio();

            //arquivoUtils.CriarEscreverArquivo();

            //arquivoUtils.LerArquivo();

            Console.WriteLine("Pressione qualquer tecla para fechar");
            Console.ReadKey();
        }
    }
}
