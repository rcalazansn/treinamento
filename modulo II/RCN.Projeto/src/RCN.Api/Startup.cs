using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using HealthChecks.UI.Client;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics.HealthChecks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using RCN.Api.Configurations;
using RCN.Api.Extensions;
using RCN.Business.Interfaces;
using RCN.Business.Notificacoes;
using RCN.Data.Context;
using RCN.Data.Repository;
using Swashbuckle.AspNetCore.Swagger;

namespace RCN.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApiContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("sql"));
            });

            services.AddAutoMapper(typeof(Startup));

            services.AddApiConfig();

            services.AddDependencyInjectionConfig();

            services.AddResponseCaching();

            services.AddResponseCompression(opt =>
            {
                // opt.Providers.Add<GzipCompressionProvider>();
                opt.Providers.Add<BrotliCompressionProvider>();
                opt.EnableForHttps = true;

            });

            services.Configure<BrotliCompressionProviderOptions>(options =>
            {
                options.Level = CompressionLevel.Optimal;
            });

            services.AddMvc()
                .SetCompatibilityVersion(CompatibilityVersion.Version_2_2)
                .AddXmlDataContractSerializerFormatters() // permite retornar em XML
                .AddJsonOptions(opcoes => // Remove valores nulos das respostas
                {
                    opcoes.SerializerSettings.NullValueHandling =
                        Newtonsoft.Json.NullValueHandling.Ignore;
                });

            services.AddHealthChecks()
                .AddSqlServer(Configuration.GetConnectionString("sql"), name: "BancoSQL")
                .AddCheck("Fornecedores", new SqlSeverHealthCheck(Configuration.GetConnectionString("sql")));

            services.AddHealthChecksUI();

            services.AddSwaggerConfig();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseSwaggerConfig();

            app.UseResponseCaching();

            app.UseResponseCompression();

            app.UseHttpsRedirection();

            
            app.UseHealthChecks("/api/hc", new HealthCheckOptions
            {
                Predicate = _ => true,
                ResponseWriter = UIResponseWriter.WriteHealthCheckUIResponse
            });

            app.UseHealthChecksUI(); // /healthchecks-ui 

            app.UseMvc();
        }
    }
}
