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
            ContaRepository repositoryConta = new ContaRepository();
            ClienteRepository repositoryCliente = new ClienteRepository();
            BancoRepository repositoryBanco = new BancoRepository();

            #region Inserir Conta
            Conta conta = new Conta();
            conta.Limite = 100;
            conta.Saldo = 1000;
            conta.ContaCorrente = "123456";
            conta.Agencia = "7545";

            // Console.WriteLine("Inserir Conta");
            // repository.Inserir(conta);
            #endregion

            #region Editar Conta

            Conta contaEditar = new Conta();
            contaEditar.Id = 1;
            contaEditar.Limite = 100;
            contaEditar.Saldo = 1000;
            contaEditar.ContaCorrente = "333";
            contaEditar.Agencia = "222";

            //Console.WriteLine("Editar Conta");
            // repository.Editar(contaEditar);
            #endregion

            #region Apagar Conta
            //Console.WriteLine("Apagar conta");
            //   repository.Apagar(2);
            #endregion

            #region Obter apenas uma Conta
            Conta conta_1 = repositoryConta.Obter(1);

            Console.WriteLine(conta_1);
            #endregion

            #region Obter todas Contas
            IEnumerable<Conta> contas = repositoryConta.Obter();

            foreach (var item in contas)
            {
                Console.WriteLine(item.Banco);
            }
            #endregion

            #region Realizar Saque
            Conta contaSaque = repositoryConta.Obter(1);

            //   repository.RealizarSaque(contaSaque, 5);
            #endregion

            #region Realizar Deposito
            Conta contaDeposito = repositoryConta.Obter(1);
            // repositoryConta.RealizarDeposito(contaDeposito, 5);
            #endregion

            #region Realizar Transferencia

            Conta contaOrigem = repositoryConta.Obter(1);
            Conta contaDestino = repositoryConta.Obter(3);

            //   repositoryConta.RealizarTransferecia(contaOrigem, contaDestino, 6);
            #endregion


            #region Gravar Cliente e Conta

            Cliente cliente1 = new Cliente();
            cliente1.Nascimento = new DateTime(1986, 04, 28);
            cliente1.NomeTitular = "Rodrigo Calazans";
            repositoryCliente.Inserir(cliente1);/*Quando usar "ID" deve ser chamado cada um dos "salveChanges"*/

            Banco banco = new Banco();
            banco.Codigo = "001";
            banco.Nome = "Bradesco";
            repositoryBanco.Inserir(banco); /*Quando usar "ID" deve ser chamado cada um dos "salveChanges"*/

            Conta conta1 = new Conta();
            conta1.Limite = 100;
            conta1.Saldo = 1000;
            conta1.ContaCorrente = "123456";
            conta1.Agencia = "7545";

            conta1.ClienteId = cliente1.Id;
            conta1.BancoId = banco.Id;
            repositoryConta.Inserir(conta1);  /*Quando usar "ID" deve ser chamado cada um dos "salveChanges"*/

            /*pode ser feito apenas um "salveChanges" quando é atribuido o objeto */
            //conta1.Cliente = cliente1;
            //conta1.Banco = banco;
            //repositoryConta.Inserir(conta1);

            #endregion

            Console.WriteLine("Processo finalizado");
            Console.ReadKey();
        }
    }
}
