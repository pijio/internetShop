using InternetShop.SiteApp.Services.CustomLogger;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace InternetShop.Api.Services
{
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// Метод расширения добавляющий сервис логирования
        /// </summary>
        /// <param name="services"></param>
        public static void AddCustomerLogger(this IServiceCollection services)
        {
            services.AddTransient<ICustomLogger, NLogger>();
        }
        /// <summary>
        /// Метод расширения добавляющий в проект сервис с итоговой конфигурацией
        /// </summary>
        /// <param name="services"></param>
        /// <param name="finalConfig">Объект со всеми конфигурациями и провайдерами</param>
        public static void AddConfiguration(this IServiceCollection services, IConfiguration finalConfig)
        {
            services.AddSingleton<IConfiguration>(finalConfig);
        }
        /// <summary>
        /// cors
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddCorsPolicy(this IServiceCollection services)
        {
            return services.AddCors(options => options.AddPolicy("CorsPolicy",
                builder => builder.SetIsOriginAllowed(_ => true)
                    .AllowAnyMethod()
                    .AllowAnyHeader()
                    .AllowCredentials()));
        }
    }
}