using System;

namespace exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("Hello World 1");
             Console.WriteLine("Hello World 2");

             string nome;
             bool inativo;
             int numero;
             long numero_1;
             decimal valor = 10_000_00;
             decimal valor_1 = 20.00M;
             DateTime hoje = DateTime.Now; //Data Atual
             DateTime data_manual = new DateTime(2019, 09, 28); //Data Manual
             string hoje_formadata = hoje.ToString("dd/MM/yyyy HH:mm:ss"); //Formatação
             string hoje_formadata_2 = hoje.ToString("T"); //Time
             char tipo;

             int[] array_int = new int[5];


             string[] array_string = new string[5];
             array_string[0] = "A";
             array_string[1] = "B";
             array_string[2] = "C";
             array_string[3] = "D";
             array_string[4] = "E";

             Console.WriteLine(">>" + hoje_formadata);
             Console.WriteLine($">> {hoje_formadata_2} <<");
             Console.WriteLine($">> {valor.ToString()} <<");

             string variavel_usuario = Console.ReadLine();

             // Console.WriteLine($"Variavel:{Console.ReadLine()}");
             // Console.WriteLine($"Variavel:{variavel_usuario}");

             if (variavel_usuario.ToLower() == "calazans")
             {
                 Console.WriteLine("nome igual calazans");
             }
             else
             {
                 Console.Write("nome diferente de calazans,");
                 Console.Write($"o nome informado foi:{variavel_usuario}");
             }

             Console.WriteLine($"Tamanho: {variavel_usuario.Length}");
             Console.WriteLine($"Tamanho: {variavel_usuario.PadLeft(10, '-')}");
             Console.WriteLine($"Tamanho: {variavel_usuario.PadRight(10, '*')}");*/

            Exemplos exemplo = new Exemplos();
            /*
            exemplo.FatorialNumeroQuatro();

            Console.WriteLine();
            int retorno = exemplo.FatorialNumeroCinco();
            Console.WriteLine($"Fatorial cinco={retorno}");

            Console.WriteLine();
            Console.Write("Informe o fatorial que deseja:");
            string numeroUsuario = Console.ReadLine();
            int numeroFatorial = Convert.ToInt32(numeroUsuario);
            Console.WriteLine($"FatorialQualquerNumero:{exemplo.FatorialQualquerNumero(numeroFatorial)}");

            Console.WriteLine();
            Console.Write("Informa o primeiro valor:");
            int valor1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Informa o segundo valor:");
            int valor2 = Convert.ToInt32(Console.ReadLine());
            exemplo.MaiorNumero(valor1, valor2);

            Console.WriteLine();
            Console.Write("Qual numero deseja saber se e impar ou par:");
            int numero = Convert.ToInt32(Console.ReadLine());
            exemplo.NumeroEhImpar(numero);
            */

            /*
            Console.WriteLine();
            Console.Write("primeiro valor:");
            int valorCalculadora1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("segundo valor:");
            int valorCalculadora2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Qual operacao [/ * - +]:");
            string operacao = Console.ReadLine();
            exemplo.Calculadora(valorCalculadora1, valorCalculadora2, operacao);
            */

            /*Console.WriteLine();
            Console.Write("Tabuada:");
            int tabuada = Convert.ToInt32(Console.ReadLine());
            exemplo.Tabuada(tabuada);*/

            Console.WriteLine();
            Console.Write("Temperatura:");
            int temperatura = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Celsius => Fahrenheit = [C]");
            Console.Write("Fahrenheit => Celsius= [F]");
            string operacao = Console.ReadLine();
            exemplo.Temperatura(temperatura, operacao);
        }
    }
}
