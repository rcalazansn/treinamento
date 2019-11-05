using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public interface ICrud<Entidade>
    {
        bool Inserir(Entidade entidade);
        bool Editar(Entidade entidade);
        bool Apagar(Entidade entidade);
        Entidade Obter(int id);
        IEnumerable<Entidade> Obter();
    }
}
