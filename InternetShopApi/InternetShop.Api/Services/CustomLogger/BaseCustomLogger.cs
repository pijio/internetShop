using Microsoft.Extensions.Configuration;
using NLog;

namespace InternetShop.Api.CustomLogger
{
    public class BaseCustomLogger : ICustomLogger
    {
        public string LogPath { get; set; }
        public Logger Manager { get; set; }
        
        protected void ConfigureManager(IConfiguration configuration)
        {
            LogPath = configuration["LoggerPath"];
            LogManager.Configuration.Variables["path"] = LogPath;
        }
    }
}