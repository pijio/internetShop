﻿using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace InternetShop.DAL
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
    
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton(Configuration);
        }
    }
}