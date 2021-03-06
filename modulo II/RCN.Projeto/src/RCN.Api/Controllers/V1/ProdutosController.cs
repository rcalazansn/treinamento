﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using RCN.Api.ViewModel;
using RCN.Business.Interfaces;
using RCN.Business.Interfaces.Services;
using RCN.Business.Model;
using RCN.Business.Notificacoes;
using RCN.Data.Context;

namespace RCN.Api.Controllers.V1
{
    [Route("api/v1/[controller]")]
    public class ProdutosController : MainController
    {
        private readonly IProdutoRepository _produtoRepository;
        private readonly IProdutoService _produtoService;
        private readonly IMapper _mapper;
        protected readonly IOptions<RCNSettings> _settings;

        public ProdutosController
        (
            IProdutoRepository produtoRepository,
            IProdutoService produtoService,
            IMapper mapper,
            INotificador notificador,
            IOptions<RCNSettings> settings
        ) : base(notificador)
        {
            _produtoRepository = produtoRepository;
            _produtoService = produtoService;
            _mapper = mapper;
            _settings = settings;
        }

        [HttpGet]
        [ResponseCache(Duration = 20)]
        public async Task<ActionResult<IEnumerable<ProdutoViewModel>>> Get()
        {
            return Ok(await _produtoRepository.Obter());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ProdutoViewModel>> Get(Guid id)
        {
            var produto = await _produtoRepository.Obter(id);

            if (produto == null)
            {
                return NotFound();
            }

            return _mapper.Map<ProdutoViewModel>(produto);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(Guid id, ProdutoEditarViewModel produtoVM)
        {
            if (!ModelState.IsValid) return Result(ModelState);

            if (id != produtoVM.Id)
            {
                return BadRequest();
            }

            await _produtoService.Editar(_mapper.Map<Produto>(produtoVM));

            return Result("Registro alterado com sucesso");
        }

        [HttpPost]
        public async Task<ActionResult<Produto>> Post(ProdutoAdicionarViewModel produtoVM)
        {
            if (!ModelState.IsValid) return Result(ModelState);

            var nomeImagem = $"{Guid.NewGuid()}.jpg";
            if(!UploadImagem(produtoVM.Imagem, nomeImagem))
            {
                return Result();
            }

            produtoVM.Imagem = nomeImagem;

            var prod = _mapper.Map<Produto>(produtoVM);

            await _produtoService.Inserir(prod);

            return Result("Regitro incluido com sucesso");
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Produto>> Delete(Guid id)
        {
            var produto = await _produtoRepository.Obter(id);
            if (produto == null)
            {
                return NotFound();
            }

            await _produtoService.Apagar(produto);

            return Result("Registro apagado com sucesso");
        }

        private bool UploadImagem(string imagemBase64, string nomeImagem)
        {
            if (string.IsNullOrEmpty(imagemBase64))
            {
                NotificarErro("Necessário informar uma imagem para o produto!");
                return false;
            }

            var imagemByte = Convert.FromBase64String(imagemBase64);

            var pathImgem = Path.Combine(_settings.Value.PathImagemAngular, nomeImagem);

            System.IO.File.WriteAllBytes(pathImgem, imagemByte);

            return true;
        }
    }
}
