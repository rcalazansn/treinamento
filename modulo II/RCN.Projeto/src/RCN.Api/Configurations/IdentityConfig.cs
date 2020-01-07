using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using RCN.Api.Data;
using RCN.Api.Extensions;
using System.Text;

namespace RCN.Api.Configurations
{
    public static class IdentityConfig
    {
        public static IServiceCollection AddIdentityConfig
        (
            this IServiceCollection services,
            IConfiguration configuration
        )
        {
            services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("sql"));
            });

            services.AddDefaultIdentity<IdentityUser>()
                    .AddEntityFrameworkStores<ApplicationDbContext>()
                    .AddErrorDescriber<IdentityMensagensPortugues>();

            //JWT
            var settingsSection = configuration.GetSection("SettingsJWT");
            services.Configure<SettingsJWT>(settingsSection);

            var settings = settingsSection.Get<SettingsJWT>();
            var key = Encoding.ASCII.GetBytes(settings.Secret);

            services.AddAuthentication(a =>
            {
                a.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                a.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(b =>
            {
                b.RequireHttpsMetadata = false;
                b.SaveToken = true;
                b.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidAudience = settings.ValidoEm,
                    ValidIssuer = settings.Emissor
                };
            });

            return services;
        }
    }
}
