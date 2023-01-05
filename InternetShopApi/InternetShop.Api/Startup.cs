using System;
using System.Collections.Generic;
using System.Linq;
using InternetShop.Api.Services;
using System.Threading.Tasks;
using InternetShop.Api.CustomLogger;
using InternetShop.Api.Infrastructure;
using InternetShop.SiteApp;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace InternetShop.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = new ConfigurationBuilder()
                .AddJsonFile("customlogger.conf.json")
                .AddConfiguration(configuration)
                .Build();
        }
        
        public IConfiguration Configuration { get; }

        // Настройка сервисов
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddSwaggerGen(s =>
            {
                s.SwaggerDoc("v1", new OpenApiInfo { Title = "Internet shop API", Version = "v1" });
                s.CustomSchemaIds(x=> x.FullName);
            });
            services.AddConfiguration(Configuration);
            services.AddCustomerLogger();
            services.AddSiteApp();
        }

        // Конвеер запросов, подключение мидлвар компонентов
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ICustomLogger logger)
        {
            logger.Manager.Info("Web app starting...");
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(uibind => 
                    uibind.SwaggerEndpoint
                        ("/swagger/v1/swagger.json", "My API V1")
                );
            }
            else
            {
                app.UseHsts();
                app.UseMiddleware<ErrorHandlingMiddleware>();
            }
            app.UseHttpsRedirection();
            app.UseRouting();

            app.UseAuthorization();
            
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}