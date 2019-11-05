using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto2
{
    public class TesteCrud : IBaseRepository<Conta>
    {
        public void Apagar(int id)
        {
            throw new NotImplementedException();
        }

        public void Editar(Conta entidade)
        {
            throw new NotImplementedException();
        }

        public void Inserir(Conta entidade)
        {
            throw new NotImplementedException();
        }

        public Conta Obter(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Conta> Obter()
        {
            throw new NotImplementedException();
        }
    }

    public class TesteCrud2 : IBaseRepository<Cliente>
    {
        public void Apagar(int id)
        {
            throw new NotImplementedException();
        }

        public void Editar(Cliente entidade)
        {
            throw new NotImplementedException();
        }

        public void Inserir(Cliente entidade)
        {
            throw new NotImplementedException();
        }

        public Cliente Obter(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Cliente> Obter()
        {
            throw new NotImplementedException();
        }
    }

    public class Sedex
    {

    }

    public class PAC
    {

    }

    public interface ICorreios
    {
        void RealizarEntrega();
    }
}
