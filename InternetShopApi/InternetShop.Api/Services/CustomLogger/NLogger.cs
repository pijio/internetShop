﻿using Microsoft.Extensions.Configuration;
using NLog;

namespace InternetShop.Api.CustomLogger
{
    public class NLogger : BaseCustomLogger
    {
        public NLogger(IConfiguration configuration) 
        {
            ConfigureManager(configuration);
            Manager = LogManager.GetCurrentClassLogger();
        }
    }
}