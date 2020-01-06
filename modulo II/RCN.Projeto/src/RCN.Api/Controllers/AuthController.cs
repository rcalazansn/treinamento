using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using RCN.Api.ViewModel;
using RCN.Business.Notificacoes;

namespace RCN.Api.Controllers
{
    [Route("api/[controller]")]
    public class AuthController : MainController
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;
        public AuthController
        (
            INotificador notificador,
            SignInManager<IdentityUser> signInManager,
            UserManager<IdentityUser> userManager
        )
            : base(notificador)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }

        [HttpPost("regitrar")]
        public async Task<ActionResult> Registrar(RegitrarViewModel registrar)
        {
            if (!ModelState.IsValid) return Result(ModelState);

            var user = new IdentityUser
            {
                UserName = registrar.Login
            };

            var result = await _userManager.CreateAsync(user, registrar.Senha);

            if (result.Succeeded)
            {
                return Result("Usuario criado com sucesso!");
            }

            foreach (var erro in result.Errors)
            {
                NotificarErro(erro.Description);
            }

            return Result();
        }
    }
}