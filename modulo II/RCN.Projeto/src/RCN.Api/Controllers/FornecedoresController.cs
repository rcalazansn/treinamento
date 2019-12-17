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
    public class FornecedoresController : ControllerBase
    {
        private readonly IFornecedorRepository _fornecedorRepository;

        public FornecedoresController(IFornecedorRepository fornecedorRepository)
        {
            _fornecedorRepository = fornecedorRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Fornecedor>>> GetFornecedores()
        {
            return Ok(await _fornecedorRepository.Obter());
        }

        public async Task<ActionResult<Fornecedor>> GetFornecedor(Guid id)
        {
            var fornecedor = await _fornecedorRepository.Obter(id);

            if (fornecedor == null)
            {
                return NotFound();
            }

            return fornecedor;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutFornecedor(Guid id, Fornecedor fornecedor)
        {
            if (id != fornecedor.Id)
            {
                return BadRequest();
            }

            await _fornecedorRepository.Editar(fornecedor);

            return NoContent();
        }

        [HttpPost]
        public async Task<ActionResult<Fornecedor>> PostFornecedor(Fornecedor fornecedor)
        {
            await _fornecedorRepository.Inserir(fornecedor);

            return CreatedAtAction("GetFornecedor", new { id = fornecedor.Id }, fornecedor);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Fornecedor>> DeleteFornecedor(Guid id)
        {
            var fornecedor = await _fornecedorRepository.Obter(id);
            if (fornecedor == null)
            {
                return NotFound();
            }

            await _fornecedorRepository.Apagar(fornecedor);

            return fornecedor;
        }
    }
}
