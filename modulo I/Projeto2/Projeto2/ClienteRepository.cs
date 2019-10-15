using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto2
{
   public class ClienteRepository
    {
        public Projeto2Context Context { get; set; }

        public ClienteRepository()
        {
            Context = new Projeto2Context();
        }

        public void Inserir(Cliente cliente)
        {
            Context.Clientes.Add(cliente);
            Context.SaveChanges();
        }

        public void Editar(Cliente cliente)
        {
            Cliente clienteDB = Obter(cliente.Id);

            if (clienteDB != null)
            {
                Context.Entry(clienteDB).CurrentValues.SetValues(cliente);
                Context.SaveChanges();
            }
        }

        public void Apagar(int id)
        {
            Cliente clienteDB = Obter(id);

            if (clienteDB != null)
            {
                Context.Clientes.Remove(clienteDB);

                Context.SaveChanges();
            }
        }

        public Cliente Obter(int id)
        {
            return Context.Clientes.Where(x => x.Id == id).FirstOrDefault();
        }

        public IEnumerable<Cliente> Obter()
        {
            return Context.Clientes.ToList();
        }
    }
}
