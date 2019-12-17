using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RCN.Business.Interfaces;
using RCN.Business.Model;
using RCN.Data.Context;

namespace RCN.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutosController(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Produto>>> Get()
        {
            return Ok(await _produtoRepository.Obter());
        }

        public async Task<ActionResult<Produto>> Get(Guid id)
        {
            var produto = await _produtoRepository.Obter(id);

            if (produto == null)
            {
                return NotFound();
            }

            return produto;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(Guid id, Produto produto)
        {
            if (id != produto.Id)
            {
                return BadRequest();
            }

            await _produtoRepository.Editar(produto);

            return NoContent();
        }

        [HttpPost]
        public async Task<ActionResult<Produto>> Post(Produto produto)
        {
            await _produtoRepository.Inserir(produto);

            return CreatedAtAction("Post", new { id = produto.Id }, produto);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Produto>> Delete(Guid id)
        {
            var produto = await _produtoRepository.Obter(id);
            if (produto == null)
            {
                return NotFound();
            }

            await _produtoRepository.Apagar(produto);

            return produto;
        }
    }
}
