using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto2
{
    public class ContaRepository
    {
        //C - create (insert)
        //R - read   (select)
        //U - update (update)
        //D - delete (delete)

        public Projeto2Context Context { get; set; }

        public ContaRepository()
        {
            Context = new Projeto2Context();
        }
        public void Inserir(Conta conta)
        {
            Context.Contas.Add(conta);
            Context.SaveChanges();
        }

        public void Editar(Conta conta)
        {
            //Editar modelo 1
            //Context.Entry<Conta>(conta).State = System.Data.Entity.EntityState.Modified;
            //Context.SaveChanges();

            //Editar modelo 2
            Conta contaDB = Obter(conta.Id);

            if (contaDB != null)
            {
                Context.Entry(contaDB).CurrentValues.SetValues(conta);
                Context.SaveChanges();
            }
        }

        public void Apagar(int id)
        {
            Conta contaDB = Obter(id);

            if (contaDB != null)
            {
                Context.Contas.Remove(contaDB);

                Context.SaveChanges();
            }
        }

        public Conta Obter(int id)
        {
            return Context.Contas.Where(x => x.Id == id).FirstOrDefault();
        }

        public IEnumerable<Conta> Obter()
        {
            return Context.Contas.ToList();
        }

        public void RealizarSaque(Conta conta, decimal valor)
        {
            Context.Database.ExecuteSqlCommand($"UPDATE tab_conta SET saldo=(saldo-{valor}) WHERE id={conta.Id}");
        }

        public void RealizarDeposito(Conta conta, decimal valor)
        {
            Context.Database.ExecuteSqlCommand($"UPDATE tab_conta SET saldo=(saldo+{valor}) WHERE id={conta.Id}");
        }
        public void RealizarTransferecia(Conta contaOrigem, Conta ContaDestino, decimal valor)
        {
            Context.Database.ExecuteSqlCommand($"UPDATE tab_conta SET saldo=(saldo-{valor}) WHERE id={contaOrigem.Id}");

            Context.Database.ExecuteSqlCommand($"UPDATE tab_conta SET saldo=(saldo+{valor}) WHERE id={ContaDestino.Id}");

        }
    }
}
