using NLog;
namespace InternetShop.Api.CustomLogger
{
    public interface ICustomLogger
    {
        public string LogPath { get; }
        public Logger Manager { get; }
    }
}