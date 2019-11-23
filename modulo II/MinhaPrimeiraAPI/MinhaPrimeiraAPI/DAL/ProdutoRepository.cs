using FluentValidation.Results;
using Microsoft.EntityFrameworkCore;
using MinhaPrimeiraAPI.Models;
using MinhaPrimeiraAPI.Models.Validations;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MinhaPrimeiraAPI.DAL
{
    public class ProdutoRepository : IProdutoRepository
    {
        public readonly Contexto _contexto;
        public ProdutoRepository(Contexto contexto)
        {
            _contexto = contexto;
        }

        public void Adicionar(Produto produto)
        {
            _contexto.Produtos.Add(produto);
            _contexto.SaveChanges();
        }

        public void Apagar(Produto produto)
        {
            _contexto.Produtos.Remove(produto);
            _contexto.SaveChanges();
        }

        public void Editar(Produto produto)
        {
            _contexto.Entry(produto).State = EntityState.Modified;
            _contexto.SaveChanges();
        }

        public Produto Obter(int id)
        {
            return _contexto.Produtos.Find(id);
            //return _contexto.Produtos.Where(a => a.Id == id).FirstOrDefault();
        }

        public IEnumerable<Produto> Obter()
        {
            return _contexto.Produtos.ToList();
        }
    }
}
