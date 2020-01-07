using AutoMapper;
using HealthChecks.UI.Client;
using KissLog;
using KissLog.Apis.v1.Listeners;
using KissLog.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics.HealthChecks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using RCN.Api.Configurations;
using RCN.Api.Extensions;
using RCN.Data.Context;
using System.IO.Compression;

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
            // services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            //services.AddScoped<KissLog.ILogger>((context) =>
            //{
            //    return KissLog.Logger.Factory.Get();
            //});

            services.AddApiVersioning(options =>
            {
                options.AssumeDefaultVersionWhenUnspecified = true;
                options.DefaultApiVersion = new Microsoft.AspNetCore.Mvc.ApiVersion(1, 0);
                options.ReportApiVersions = true; //API Headers
            });

            services.AddDbContext<ApiContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("sql"));
            });

            services.AddIdentityConfig(Configuration);

            services.Configure<RCNSettings>(Configuration);
            RCNSettings settings = Configuration.Get<RCNSettings>();

            System.Console.WriteLine(settings.EmailConfig.Email);



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


            services.AddVersionedApiExplorer(options =>
            {
                options.GroupNameFormat = "'v'VVV";
                options.SubstituteApiVersionInUrl = true; //Se nao colocar versão, é adicionado versão padrao
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

        public void Configure
        (
            IApplicationBuilder app, 
            IHostingEnvironment env, 
            ILoggerFactory loggerFactory,
            IApiVersionDescriptionProvider provider
        )
        {
            loggerFactory.AddFile
            (
                "log/rcn-{Date}.txt", 
                Microsoft.Extensions.Logging.LogLevel.Error
            );

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseSwaggerConfig(provider);

            app.UseResponseCaching();

            app.UseResponseCompression();

            app.UseHttpsRedirection();

            
            app.UseHealthChecks("/api/hc", new HealthCheckOptions
            {
                Predicate = _ => true,
                ResponseWriter = UIResponseWriter.WriteHealthCheckUIResponse
            });

            app.UseHealthChecksUI(); // /healthchecks-ui 

            // make sure it is added after app.UseStaticFiles() and app.UseSession(), and before app.UseMvc()
            app.UseKissLogMiddleware(options => {
                options.Listeners.Add(new KissLogApiListener(new KissLog.Apis.v1.Auth.Application(
                    Configuration["KissLog.OrganizationId"],
                    Configuration["KissLog.ApplicationId"])
                ));
            });

            app.UseAuthentication();

            app.UseMvc();
        }
    }
}
