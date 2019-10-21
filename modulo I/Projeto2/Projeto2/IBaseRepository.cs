using System.Collections.Generic;

namespace Projeto2
{
    public interface IBaseRepository<T>
    {
        void Inserir(T conta);
        void Editar(T conta);
        void Apagar(int id);
        T Obter(int id);
        IEnumerable<T> Obter();
    }
}
