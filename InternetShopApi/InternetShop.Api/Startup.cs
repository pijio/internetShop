using System;
using InternetShop.Api.Services;
using InternetShop.Api.Infrastructure;
using InternetShop.Api.Services.AAS;
using InternetShop.DAL;
using InternetShop.SiteApp;
using InternetShop.SiteApp.Services.CustomLogger;
using InternetShop.SiteApp.Services.EmailService;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace InternetShop.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = new ConfigurationBuilder()
                .AddJsonFile("customlogger.conf.json")
                .AddJsonFile("smtpsettings.json")
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
            var connString = Environment.GetEnvironmentVariable("ConnectionString")
                             ?? Configuration.GetSection("ConnectionStrings")["PostgreSql"];
            services.AddDbContext<InternetShopDbContext>(opt =>
            {
                opt.UseNpgsql(connString);
            });
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddConfiguration(Configuration);
            services.AddCustomerLogger();
            services.AddSiteApp();
            services.AddCors(o => o.AddPolicy("ShopApiPolicy", builder =>
            {
                builder.WithOrigins("http://localhost:3000", "https://localhost:3000")
                    .AllowAnyMethod()
                    .AllowAnyHeader();
            }));
            services.AddScoped<AAService, AAService>();
            services.Configure<MailSettings>(Configuration.GetSection("MailSettings"));
            services.AddEmailService();
        }

        // Конвеер запросов, подключение мидлвар компонентов
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ICustomLogger logger)
        {
            logger.Manager.Info("Web app starting...");
            if (Environment.GetEnvironmentVariable("Migrate") != null &&
                Convert.ToBoolean(Environment.GetEnvironmentVariable("Migrate")))
            {
                using (var serviceScope = app.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope())
                {
                    var context = serviceScope.ServiceProvider.GetRequiredService<InternetShopDbContext>();
                    context.Database.Migrate();
                    logger.Manager.Info("migrations applied...");
                }
            } 
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

            app.UseMiddleware<JwtMiddleware>();
            app.UseHttpsRedirection();
            app.UseRouting();
            
            app.UseAuthorization();
            app.UseCors("ShopApiPolicy");
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}