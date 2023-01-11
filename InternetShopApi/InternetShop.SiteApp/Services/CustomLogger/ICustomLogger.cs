using NLog;
namespace InternetShop.SiteApp.Services.CustomLogger
{
    public interface ICustomLogger
    {
        public string LogPath { get; }
        public Logger Manager { get; }
    }
}