using System;

namespace TratamentoErros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("inicinado...");

            SimulacaoErros simulacaoErros = new SimulacaoErros();

            //simulacaoErros.GerarExcecao();
            // simulacaoErros.ValidarNomePreechido("");
           // simulacaoErros.GerarExcecaoTratamento();

            //simulacaoErros.AcessoBandoDados();
            // simulacaoErros.AcessoBandoDadosTratamento();

            //simulacaoErros.TratamentoFinally();
            // simulacaoErros.TratamentoArquivo();



            /*NOTIFICAÇÔES*/
            //simulacaoErros.ValidarNomePreechidoNotificacao("");
           simulacaoErros.ValidarClienteNotificacao(new Cliente());

            Console.WriteLine("precione qualquer tecla para continuar");
            Console.ReadKey();
        }
    }
}
