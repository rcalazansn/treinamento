using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using RCN.Business.Interfaces;
using RCN.Business.Interfaces.Services;
using RCN.Business.Notificacoes;
using RCN.Business.Services;
using RCN.Data.Repository;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace RCN.Api.Configurations
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection AddDependencyInjectionConfig(this IServiceCollection services)
        {
            services.AddScoped<INotificador, Notificador>();

            //Services
            services.AddScoped<IFornecedorService, FornecedorService>();
            services.AddScoped<IProdutoService, ProdutoService>();

            //Repository
            services.AddScoped<IFornecedorRepository, FornecedorRepository>();
            services.AddScoped<IProdutoRepository, ProdutoRepository>();

            services.AddTransient<IConfigureOptions<SwaggerGenOptions>, ConfigureSwaggerOptions>();
            return services;
        }
    }
}
