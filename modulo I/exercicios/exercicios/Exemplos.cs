
using System;
using System.Collections.Generic;
using System.Text;

namespace exercicios
{
    public class Exemplos
    {
        public void FatorialNumeroQuatro()
        {
            int fatorial = 4 * 3 * 2 * 1;
            Console.WriteLine($"Fatorial quatro: 4 X 3 X 2 X 1 = {fatorial}");
        }

        public int FatorialNumeroCinco()
        {
            int fatorial = 5 * 4 * 3 * 2 * 1;
            return fatorial;
        }

        public int FatorialQualquerNumero(int numero)
        {
            int resultado = 1;

            for (int i = 1; i <= numero; i++)
            {
                resultado = resultado * i;
            }

            return resultado;
        }

        public void MaiorNumero(int numero1, int numero2)
        {
            if (numero1 > numero2)
            {
                Console.WriteLine($"{numero1} e maior que {numero2}");
            }
            else if (numero2 > numero1)
            {
                Console.WriteLine($"{numero2} e maior que {numero1}");
            }
            else
            {
                Console.WriteLine("sao igual os valores");
            }
        }

        public void NumeroEhImpar(int numero)
        {
            if (numero % 2 != 0)
                Console.WriteLine("O numero e IMPAR");
            else
                Console.WriteLine("O numero e PAR");
        }

        public void Calculadora(int valor1, int valor2, string operacao)
        {
            switch (operacao)
            {
                case "/":
                    Console.WriteLine($"{valor1} / {valor2} = {(valor1 / valor2)}");
                    break;
                case "*":
                    Console.WriteLine($"{valor1} * {valor2} = {(valor1 * valor2)}");
                    break;
                case "-":
                    Console.WriteLine($"{valor1} - {valor2} = {(valor1 - valor2)}");
                    break;
                case "+":
                    Console.WriteLine($"{valor1} + {valor2} = {(valor1 + valor2)}");
                    break;
                default:
                    Console.WriteLine("Nao foi informada uma operação valida!");
                    break;
            }
        }

        public void Tabuada(int tabuada)
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"{i} * {tabuada} = {i * tabuada}");
            }
        }

        public void Temperatura(int temperatura, string operacao)
        {
            decimal t = 0;
            switch (operacao.ToLower())
            {
                case "f":
                    t = (((temperatura * 9) / 5) + 32);
                    Console.WriteLine($"{temperatura}");
                    break;
                case "c":
                    t = (((temperatura - 32) * 5) / 9);
                    break;
                default:
                    Console.WriteLine("Nao foi informada uma oepracao valida");
                    break;
            }

            Console.WriteLine($"{temperatura}");
        }
    }
}
