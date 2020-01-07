using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using RCN.Api.ViewModel;
using RCN.Business.Notificacoes;

namespace RCN.Api.Controllers.V1
{
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    [AllowAnonymous]
    public class AuthControllerController : MainController
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SettingsJWT _settingsJWT;

        public AuthControllerController
        (
            INotificador notificador,
            SignInManager<IdentityUser> signInManager,
            UserManager<IdentityUser> userManager,
            IOptions<SettingsJWT> settingsJWT
        )
            : base(notificador)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _settingsJWT = settingsJWT.Value;
        }

        [HttpPost("regitrar")]
        public async Task<ActionResult> Registrar(RegistrarUsuarioViewModel registrar)
        {
            if (!ModelState.IsValid) return Result(ModelState);

            var usuario = new IdentityUser()
            {
                UserName = registrar.Login,
            };

            var result = await _userManager.CreateAsync(usuario, registrar.Senha);

            if (result.Succeeded)
            {
                return Result("Regitro incluido com sucesso");
            }

            foreach (var erro in result.Errors)
            {
                NotificarErro($"{erro.Code}-{erro.Description}");
            }

            return Result(registrar);
        }

        [HttpPost("Login")]
        public async Task<ActionResult> Login(LoginUsuarioViewModel login)
        {
            if (!ModelState.IsValid) return Result(ModelState);

            var result = await _signInManager.PasswordSignInAsync(login.Login, login.Senha, false, true);

            if (result.Succeeded)
            {
                return Result(GerarJwtToken());
            }

            if (result.IsLockedOut)
            {
                NotificarErro("Usuario temporariamente bloqueado por tentativas invalidas!");
                return Result(login);
            }

            NotificarErro("Usuario e senha invalidos!");
            return Result(login);
        }

        private string GerarJwtToken()
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_settingsJWT.Secret);
            var token = tokenHandler.CreateToken(new SecurityTokenDescriptor
            {
                Issuer = _settingsJWT.Emissor,
                Audience = _settingsJWT.ValidoEm,
                Expires = DateTime.UtcNow.AddHours(_settingsJWT.ExpiracaoHoras),
                SigningCredentials =
                new SigningCredentials(new SymmetricSecurityKey(key),
                SecurityAlgorithms.HmacSha256Signature)
            });


            var encoderToken = tokenHandler.WriteToken(token);

            return encoderToken;
        }
    }
}