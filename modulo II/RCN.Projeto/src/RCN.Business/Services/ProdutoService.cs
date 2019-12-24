﻿using RCN.Business.Interfaces;
using RCN.Business.Interfaces.Services;
using RCN.Business.Model;
using RCN.Business.Notificacoes;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RCN.Business.Services
{
    public class ProdutoService : BaseService, IProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;
        public ProdutoService
        (
            IProdutoRepository produtoRepository, 
            INotificador notificador
        )
            : base(notificador)
        {
            _produtoRepository = produtoRepository;
        }

        public async Task<bool> Apagar(Produto produto)
        {
            await _produtoRepository.Apagar(produto);
            return true;
        }

        public async Task<bool> Editar(Produto produto)
        {
            await _produtoRepository.Editar(produto);
            return true;
        }

        public async Task<bool> Inserir(Produto produto)
        {
            await _produtoRepository.Inserir(produto);
            return true;
        }

        public void Dispose()
        {
            _produtoRepository.Dispose();
        }
    }
}
