using System;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using InternetShop.DAL;
using InternetShop.SiteApp.Utilities;
using Microsoft.Extensions.Configuration;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using InternetShop.SiteApp.Services.CustomLogger;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using NLog;

namespace InternetShop.Api.Services.AAS
{
    /// <summary>
    /// Сервис авторизации и аутентификации
    /// </summary>
    public class AAService
    {
        private IUnitOfWork _uow;
        private Logger _logger;
        private IConfiguration _configuration;
        public AAService(IUnitOfWork uow, ICustomLogger logger, IConfiguration configuration)
        {
            _uow = uow;
            _logger = logger.Manager;
            _configuration = configuration;
        }

        public async Task<AuthenticateResponce> Authenticate(string username, string password)
        {
            var rep = _uow.GetGenericRepository<User>();
            var hash = Helpers.GetHashString(password);
            var user = await rep.FirstOrDefaultAsync(x => x.Password == hash && x.Username == username);
            if (user == null)
            {
                _logger.Warn($"Попытка логина под логином {username}");
                return null;
            }

            return new AuthenticateResponce(user, GenerateJwtToken(user));
        }

        public async Task<AuthenticateResponce> Register(string username, string password, string email)
        {
            var rep = _uow.GetGenericRepository<User>();
            if(rep.Any(x => x.Username == username || x.Email == email))
            {
                _logger.Warn($"Попытка регистрации с ником {username} и email {email}");
                return null;
            }
            var hash = Helpers.GetHashString(password);
            var newUser = new User { Username = username, Email = email, Password = hash};
            await rep.AddAsync(newUser);
            await _uow.SaveChangesAsync();
            newUser = await rep.FirstOrDefaultAsync(x => x.Username == username);
            return new AuthenticateResponce(newUser, GenerateJwtToken(newUser));
        }

        private string GenerateJwtToken(User user)
        {
            {
                var tokenHandler = new JwtSecurityTokenHandler();
                var key = Encoding.ASCII.GetBytes(_configuration["Secret"]);
                var tokenDescriptor = new SecurityTokenDescriptor
                {
                    Subject = new ClaimsIdentity(new[] { new Claim("id", user.Id.ToString()) }),
                    Expires = DateTime.UtcNow.AddDays(7),
                    SigningCredentials = new SigningCredentials(
                        new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
                };
                var token = tokenHandler.CreateToken(tokenDescriptor);
                return tokenHandler.WriteToken(token);
            }
        }

        public async Task<User> GetById(long id)
        {
            return await _uow.GetGenericRepository<User>().FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}