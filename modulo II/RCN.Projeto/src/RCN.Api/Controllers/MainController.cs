﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using RCN.Business.Notificacoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RCN.Api.Controllers
{
    [ApiController]
    public abstract class MainController : ControllerBase
    {
        private INotificador _notificador;

        public MainController(INotificador notificador)
        {
            _notificador = notificador;
        }

        public ActionResult Result(object obj = null)
        {
            if (!_notificador.TemNotificacao())
            {
                return Ok(new
                {
                    sucesso = true,
                    data = obj
                });
            }

            return BadRequest(new
            {
                sucesso = false,
                erros = _notificador.ObterNotificacoes().Select(n => n.Mensagem)
            });
        }

        public ActionResult Result(ModelStateDictionary modelState)
        {
            ObterNotificacoesModelInvalida(modelState);

            return Result();
        }

        private void ObterNotificacoesModelInvalida(ModelStateDictionary modelState)
        {
            var erros = modelState.Values.SelectMany(e => e.Errors);

            foreach (var erro in erros)
            {
                string mensagemErro = erro.Exception == null ? erro.ErrorMessage : erro.Exception.Message;
                _notificador.Handle(new Notificacao(mensagemErro));
            }
        }
    }
}
