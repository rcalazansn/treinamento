using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MinhaPrimeiraAPI.DAL;
using MinhaPrimeiraAPI.Models;

namespace MinhaPrimeiraAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        public readonly IProdutoRepository _produtoRepository;

        public ProdutosController(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        [HttpPost]
        public void Adicionar(Produto produto)
        {
            _produtoRepository.Adicionar(produto);
        }

        [HttpPut]
        public void Editar(Produto produto)
        {
            _produtoRepository.Editar(produto);
        }

        [HttpDelete("{id}")]
        public void Apagar(int id)
        {
            var produto = _produtoRepository.Obter(id);

            _produtoRepository.Apagar(produto);
        }

        [HttpGet("{id}")]
        public Produto Obter(int id)
        {
            return _produtoRepository.Obter(id);
        }

        [HttpGet]
        public IEnumerable<Produto> Obter()
        {
            return _produtoRepository.Obter();
        }
    }
}