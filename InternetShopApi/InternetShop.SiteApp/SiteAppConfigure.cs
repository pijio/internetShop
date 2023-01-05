using FluentValidation;
using InternetShop.DAL;
using InternetShop.SiteApp.Pipes;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace InternetShop.SiteApp
{
    public static class SiteAppConfigure
    {
        public static void AddSiteApp(this IServiceCollection services)
        {
            var ass_embly = typeof(SiteAppConfigure).Assembly;
            services.AddMediatR(ass_embly);
            services.AddValidatorsFromAssembly(ass_embly);
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationPipe<,>));
        }
    }
}