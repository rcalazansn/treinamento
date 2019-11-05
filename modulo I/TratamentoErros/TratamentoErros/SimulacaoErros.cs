using System;
using System.IO;

namespace TratamentoErros
{
    public class SimulacaoErros
    {
        public Notificacao _notificacao = new Notificacao();
        public void GerarExcecao()
        {
            throw new Exception("exceção forçada!");
        }

        public void ValidarNomePreechido(string nome)
        {
            if (nome == "")
            {
                throw new Exception("Nome precisa ser informado!");
            }
        }

        public void ValidarNomePreechidoNotificacao(string nome)
        {
            if (nome == "")
            {
                _notificacao.AdicionarNotificacao("Necessario informar o nome");
            }

            if (_notificacao._notificacoes.Count > 0)
            {
                Console.WriteLine($"Foi identificado um erro de validação: {_notificacao._notificacoes[0]}");
            }
        }

        public void ValidarClienteNotificacao(Cliente cliente)
        {
            if (string.IsNullOrEmpty(cliente.NomeTitular))
            {
                cliente.AdicionarNotificacao("Necessario informar o nome");
            }

            if (cliente.Nascimento == DateTime.MinValue)
            {
                cliente.AdicionarNotificacao("Necessario informar a data de nascimento");
            }

            if (cliente._notificacoes.Count > 0)
            {
                Console.WriteLine("Foi identificado um erro de validação");

                foreach (var item in cliente._notificacoes)
                {
                    Console.WriteLine($"\t{item}");
                }
            }
        }

        public void GerarExcecaoTratamento()
        {
            try
            {
                throw new Exception("exceção forçada!");
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"foi gerado uma exceção {ex.Message}");
            }
        }

        public void AcessoBandoDados()
        {
            using (ContentoEF context = new ContentoEF())
            {
                context.Database.ExecuteSqlCommand("SELECT * FROM tab_clientes WHERE coluna_=1");
            }
        }

        public void AcessoBandoDadosTratamento()
        {
            try
            {

                using (ContentoEF context = new ContentoEF())
                {
                    context.Database.ExecuteSqlCommand("SELECT * FROM tab_clientes WHERE coluna_=1");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Foi gerado uma exceção ao acesso o banco de dados {ex.Message}");
            }
        }

        public void TratamentoFinally()
        {
            try
            {
                Console.WriteLine("execucao try");
            }
            catch (Exception)
            {
                Console.WriteLine("execucao catch");
            }
            finally
            {
                Console.WriteLine("execucao finally");
            }
        }

        public void TratamentoArquivo()
        {
            try
            {

                using (StreamReader sr = File.OpenText("arquivo.txt"))
                  //using (StreamReader sr = File.OpenText("_arquivo.txt")) //arquivo
                 // using (StreamReader sr = File.OpenText("diretorio//arquivo.txt"))//diretorio
                {
                    Console.WriteLine($" Linha:{sr.ReadLine()}");
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine($"arquivo não encontrado: {ex}");
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine($"Diretorio não encontrado: {ex}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"exceção geral: {ex}");
            }
        }
    }
}
