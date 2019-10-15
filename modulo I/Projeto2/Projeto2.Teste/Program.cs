using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto2.Teste
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaRepository repository = new ContaRepository();

            #region Inserir Conta
            Conta conta = new Conta();
            conta.Limite = 100;
            conta.Saldo = 1000;
            conta.ContaCorrente = "123456";
            conta.Agencia = "7545";
            conta.Banco = "Itau";

            // repository.Inserir(conta);
            #endregion

            #region Editar Conta

            Conta contaEditar = new Conta();
            contaEditar.Id = 1;
            contaEditar.Limite = 100;
            contaEditar.Saldo = 1000;
            contaEditar.ContaCorrente = "333";
            contaEditar.Agencia = "222";
            contaEditar.Banco = "Itau SA";

            // repository.Editar(contaEditar);
            #endregion

            #region Apagar Conta
            //   repository.Apagar(2);
            #endregion

            #region Obter apenas uma Conta
            Conta conta_1 = repository.Obter(1);

            Console.WriteLine(conta_1);
            #endregion

            #region Obter todas Contas
            IEnumerable<Conta> contas = repository.Obter();

            foreach (var item in contas)
            {
                Console.WriteLine(item.Banco);
            }
            #endregion

            #region Realizar Saque
            Conta contaSaque = repository.Obter(1);

         //   repository.RealizarSaque(contaSaque, 5);
            #endregion

            #region Realizar Deposito
            Conta contaDeposito = repository.Obter(1);
            repository.RealizarDeposito(contaDeposito, 5);
            #endregion

            #region Realizar Transferencia

            Conta contaOrigem = repository.Obter(1);
            Conta contaDestino = repository.Obter(3);

            repository.RealizarTransferecia(contaOrigem, contaDestino, 6);
            #endregion

            Console.ReadKey();
        }
    }
}
