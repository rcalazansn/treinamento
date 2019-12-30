using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RCN.Business.Notificacoes;

namespace RCN.Api.Controllers.V2
{
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("2.0")]
    public class TestesController : MainController
    {
        public TestesController(INotificador notificador)
            : base(notificador)
        {

        }

        [HttpGet]
        public ActionResult<string> Versao()
        {
            return Result("Sou a versão 2");
        }
    }
}