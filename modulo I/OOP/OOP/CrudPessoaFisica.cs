using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class CrudPessoaFisica : Crud<PessoaFisica>, ICrudPessoaFisica
    {
        public void Inativar()
        {
            _contexto.Database.ExecuteSqlCommand("");
            throw new NotImplementedException();
        }

        public IEnumerable<PessoaFisica> ObterCPF(string CPF)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PessoaFisica> ObterPorNome(string nome)
        {
            throw new NotImplementedException();
        }
    }
}
