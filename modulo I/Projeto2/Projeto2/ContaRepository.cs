using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto2
{
    public class ContaRepository : IContaRepository
    {
        //C - create (insert)
        //R - read   (select)
        //U - update (update)
        //D - delete (delete)

        public void Inserir(Conta conta)
        {
            using (Projeto2Context context = new Projeto2Context())
            {
                context.Contas.Add(conta);
                context.SaveChanges();
            }
        }

        public void Editar(Conta conta)
        {
            using (Projeto2Context context = new Projeto2Context())
            {
                /*Editar modelo 1*/
                // context.Entry<Conta>(conta).State = System.Data.Entity.EntityState.Modified;
                // context.SaveChanges();

                //Editar modelo 2
                Conta contaDB = context.Contas.Where(x => x.Id == conta.Id).FirstOrDefault();

                if (contaDB != null)
                {
                    context.Entry(contaDB).CurrentValues.SetValues(conta);
                    context.SaveChanges();
                }
            }
        }

        public void Apagar(int id)
        {
            using (Projeto2Context context = new Projeto2Context())
            {
                Conta contaDB = context.Contas.Where(x => x.Id == id).FirstOrDefault();

                if (contaDB != null)
                {
                    context.Contas.Remove(contaDB);
                }
            }
        }

        public Conta Obter(int id)
        {
            using (Projeto2Context context = new Projeto2Context())
            {
                return context.Contas
                    // .Include("Cliente")
                    .Where(x => x.Id == id).FirstOrDefault();
            }
        }

        public IEnumerable<Conta> Obter()
        {
            using (Projeto2Context context = new Projeto2Context())
            {
                return context.Contas.ToList();
            }
        }

        public void RealizarSaque(Conta conta, decimal valor)
        {
            using (Projeto2Context context = new Projeto2Context())
            {
                string query = "UPDATE tab_conta SET saldo = (saldo - {0}) WHERE id = {1}";
                context.Database.ExecuteSqlCommand(query, valor, conta.Id);
            }
        }

        public void RealizarDeposito(Conta conta, decimal valor)
        {
            using (Projeto2Context context = new Projeto2Context())
            {
                string query = "UPDATE tab_conta SET saldo=(saldo+{0}) WHERE id={1}";

                context.Database.ExecuteSqlCommand(query, valor, conta.Id);
            }
        }

        public void RealizarTransferecia(Conta contaOrigem, Conta ContaDestino, decimal valor)
        {
            using (Projeto2Context context = new Projeto2Context())
            {
                string queryDebito = "UPDATE tab_conta SET saldo = (saldo - {0}) WHERE id = {1}";
                string queryCredito = "UPDATE tab_conta SET saldo = (saldo + {0}) WHERE id = {1}";

                context.Database.ExecuteSqlCommand(queryDebito, valor, contaOrigem.Id);

                context.Database.ExecuteSqlCommand(queryCredito, valor, ContaDestino.Id);
            }
        }

        public Conta Obter(string agencia, string contaCorrente)
        {
            using (Projeto2Context context = new Projeto2Context())
            {
                return context.Contas.Where(c => c.Agencia == agencia && c.ContaCorrente == contaCorrente).FirstOrDefault();
            }
        }

        public bool ExisteSaldo(int id, decimal valor)
        {
            using (Projeto2Context context = new Projeto2Context())
            {
                Conta conta = context.Contas.Where(a => a.Id == id).FirstOrDefault();

                return conta.Saldo >= valor ? true : false;
            }
        }
    }
}
