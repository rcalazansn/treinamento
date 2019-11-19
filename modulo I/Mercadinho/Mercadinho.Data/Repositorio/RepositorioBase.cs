using Mercadinho.Data.Contexto;
using Mercadinho.Data.Modelo;
using Mercadinho.Data.Repositorio.Interfaces;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Mercadinho.Data.Repositorio
{
    public class RepositorioBase<E> : IRepositorioBase<E> where E : EntidadeBase
    {
        public MercadinhoContexto MercadinhoContexto { get; private set; }
        public RepositorioBase()
        {
            MercadinhoContexto = new MercadinhoContexto();
        }

        public void Inserir(E entidade)
        {
            MercadinhoContexto.Set<E>().Add(entidade);
            MercadinhoContexto.SaveChanges();
        }

        public void Editar(E entidade)
        {
            MercadinhoContexto.Entry(entidade).State = EntityState.Modified;
            MercadinhoContexto.SaveChanges();
        }
        public void Apagar(E entidade)
        {
            MercadinhoContexto.Set<E>().Remove(entidade);
            MercadinhoContexto.SaveChanges();
        }

        public E Obter(int id)
        {
            return MercadinhoContexto.Set<E>().Where(a => a.Id == id).FirstOrDefault();

           // return MercadinhoContexto.Set<E>().Where(a => a.Id == id).FirstOrDefault();

           // return MercadinhoContexto.Set<E>().Find(id);
        }

        public virtual IEnumerable<E> ObterTodos()
        {
            return MercadinhoContexto.Set<E>().ToList();
        }

        public void Dispose()
        {
            MercadinhoContexto.Dispose();
        }
    }
}
