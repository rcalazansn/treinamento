using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RCN.Business.Notificacoes;

namespace RCN.Api.Controllers.V1
{
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0", Deprecated = true)]
    public class TestesController : MainController
    {
        public TestesController(INotificador notificador)
            : base(notificador)
        {

        }

        [HttpGet]
        public ActionResult<string> Versao()
        {
            return Result("Sou a versão 1");
        }
    }
}