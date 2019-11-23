using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using AutoMapper;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using MinhaPrimeiraAPI.DAL;
using MinhaPrimeiraAPI.Models;
using MinhaPrimeiraAPI.Models.Validations;
using MinhaPrimeiraAPI.ViewModels;

namespace MinhaPrimeiraAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        private readonly IProdutoRepository _produtoRepository;
        private readonly IMapper _mapper;

        public ProdutosController(IProdutoRepository produtoRepository, IMapper mapper)
        {
            _produtoRepository = produtoRepository;
            _mapper = mapper;
        }

        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.Created)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public ActionResult<Produto> AdicionarProduto(ProdutoAdicionarViewModel produtoVM)
        {
            var prd = _mapper.Map<Produto>(produtoVM);

            ValidationResult resultadoValidacao = new ProdutoValidation().Validate(prd);

            if (resultadoValidacao.IsValid == false)
            {
                return BadRequest(new
                {
                    erro = resultadoValidacao.Errors.Select(a => a.ErrorMessage)
                });
            }

            _produtoRepository.Adicionar(_mapper.Map<Produto>(produtoVM));

            return Created(nameof(AdicionarProduto), new { IdCadastrado = prd.Id });
        }

        [HttpPut]
        [ProducesResponseType((int)HttpStatusCode.NoContent)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public ActionResult Editar(ProdutoEditarViewModel produtoVM)
        {
            _produtoRepository.Editar(_mapper.Map<Produto>(produtoVM));

            return NoContent();
        }

        [HttpDelete("{id}")]
        [ProducesResponseType((int)HttpStatusCode.NoContent)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public ActionResult Apagar(int id)
        {
            var produto = _produtoRepository.Obter(id);

            _produtoRepository.Apagar(produto);

            return NoContent();
        }

        [HttpGet("{id}")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public ActionResult<Produto> Obter(int id)
        {
            var produto = _produtoRepository.Obter(id);

            if (produto != null)
                return Ok(produto);
            else
                return NotFound(new { mensagem = $"Id {id} não foi encontrado!" });

        }

        [HttpGet]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public ActionResult<IEnumerable<Produto>> Obter()
        {
            var produtos = _produtoRepository.Obter();

            return Ok(produtos);
        }
    }
}