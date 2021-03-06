﻿using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Linq;

namespace Projeto2
{
    public class ClienteRepository : IClienteRepository
    {
        public void Inserir(Cliente cliente)
        {
            using (Projeto2Context context = new Projeto2Context())
            {
                context.Clientes.Add(cliente);
                context.SaveChanges();
            }
        }

        public void Editar(Cliente cliente)
        {
            //Context.Entry<Cliente>(cliente).State = System.Data.Entity.EntityState.Modified;
            //Context.SaveChanges();

            using (Projeto2Context context = new Projeto2Context())
            {
                Cliente clienteDB = context.Clientes.Where(x => x.Id == cliente.Id).FirstOrDefault();

                if (clienteDB != null)
                {
                    context.Entry(clienteDB).CurrentValues.SetValues(cliente);
                    context.SaveChanges();
                }
            }


        }

        public void Apagar(int id)
        {
            Cliente clienteDB = Obter(id);

            using (Projeto2Context context = new Projeto2Context())
            {

                if (clienteDB != null)
                {
                    context.Clientes.Remove(clienteDB);

                    context.SaveChanges();
                }
            }
        }

        public Cliente Obter(int id)
        {
            using (Projeto2Context context = new Projeto2Context())
            {
                return context.Clientes.Where(x => x.Id == id).FirstOrDefault();
            }
        }

        public IEnumerable<Cliente> Obter()
        {
            using (Projeto2Context context = new Projeto2Context())
            {
                return context.Clientes.ToList();
            }
        }
    }
}
