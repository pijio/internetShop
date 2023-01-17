using InternetShop.DAL;
using InternetShop.DAL.DomainModels;

namespace InternetShop.Api.Services.AAS
{
    public class AuthenticateResponce
    {
        public long Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Token { get; set; }

        public AuthenticateResponce(User user, string token)
        {
            Id = user.Id;
            Username = user.Username;
            Email = user.Email;
            Token = token;
        } 
    }
}