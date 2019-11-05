using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public abstract class Crud<Entidade> : ICrud<Entidade> where Entidade : Entity
    {
        public Contexto _contexto { get; private set; }

        public Crud()
        {
            _contexto = new Contexto();
        }

        public bool Apagar(Entidade entidade)
        {
             _contexto.Set<Entidade>().Remove(entidade);

            int result = _contexto.SaveChanges();

            return result > 0 ? true : false;
        }

        public bool Editar(Entidade entidade)
        {
            _contexto.Entry<Entidade>(entidade).State = EntityState.Modified;

            int result = _contexto.SaveChanges();

            return result > 0 ? true : false;
        }

        public bool Inserir(Entidade entidade)
        {
            _contexto.Set<Entidade>().Add(entidade);

            int result = _contexto.SaveChanges();

            return result > 0 ? true : false;
        }

        public Entidade Obter(int id)
        {
            return _contexto.Set<Entidade>()
                .Where(p => p.Id == id)
                .FirstOrDefault();
        }

        public IEnumerable<Entidade> Obter()
        {
            return _contexto.Set<Entidade>().ToList();
        }
    }
}
