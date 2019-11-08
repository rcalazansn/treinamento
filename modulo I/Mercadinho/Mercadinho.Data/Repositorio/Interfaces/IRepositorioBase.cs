using Mercadinho.Data.Modelo;
using System;
using System.Collections.Generic;

namespace Mercadinho.Data.Repositorio.Interfaces
{
    public interface IRepositorioBase<E> : IDisposable where E : EntidadeBase
    {
        void Inserir(E entidade);
        void Editar(E entidade);
        void Apagar(E entidade);
        E Obter(int id);
        IEnumerable<E> ObterTodos();
    }
}
