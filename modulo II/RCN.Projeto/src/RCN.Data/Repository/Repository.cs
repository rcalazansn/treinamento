using Microsoft.EntityFrameworkCore;
using RCN.Business.Interfaces;
using RCN.Business.Model;
using RCN.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RCN.Data.Repository
{
    public class Repository<E> : IRepository<E> where E : Entity
    {
        private readonly ApiContext _apiContext;
        public Repository(ApiContext apiContext)
        {
            _apiContext = apiContext;
        }

        public async Task Inserir(E entity)
        {
            _apiContext.Add(entity);
            await _apiContext.SaveChangesAsync();
        }

        public async Task Apagar(E entity)
        {
            _apiContext.Set<E>().Remove(entity);
            await _apiContext.SaveChangesAsync();
        }

        public async Task Editar(E entity)
        {
            _apiContext.Entry(entity).State = EntityState.Modified;
            await _apiContext.SaveChangesAsync();
        }

        public async Task<E> Obter(Guid id)
        {
            return await _apiContext.Set<E>().FindAsync(id);
        }

        public async Task<IEnumerable<E>> Obter()
        {
            return await _apiContext.Set<E>().ToListAsync();
        }

        public void Dispose()
        {
            _apiContext.Dispose();
        }

        public async Task<IEnumerable<E>> Buscar(Expression<Func<E, bool>> predicate)
        {
            return await _apiContext.Set<E>()
                .Where(predicate).ToListAsync();
        }
    }
}
