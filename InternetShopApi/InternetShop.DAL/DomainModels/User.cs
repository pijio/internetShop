using System.Text.Json.Serialization;

namespace InternetShop.DAL.DomainModels
{
    public class User : IBaseEntity
    {
        public long Id { get; set; }
        public string Username { get; set; }
        [JsonIgnore]
        public string Password { get; set; }
        public string Email { get; set; }
    }
}