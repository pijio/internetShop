using System.Threading.Tasks;
using InternetShop.Api.Services.AAS;
using InternetShop.SiteApp.Services.CustomLogger;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using NLog;

namespace InternetShop.Api.Controllers
{
    
    [ApiController]
    [EnableCors("ShopApiPolicy")]
    [Route("/")]
    public class UserController : ControllerBase
    {
        private readonly Logger _logger;
        private readonly AAService _aaService;
        private readonly IConfiguration _configuration;
        public UserController(AAService service, ICustomLogger logger, IConfiguration configuration)
        {
            _aaService = service;
            _logger = logger.Manager;
            _configuration = configuration;
        }

        [HttpPost("auth")]
        public async Task<IActionResult> Authenticate(string username, string password)
        {
            var responce = await _aaService.Authenticate(username, password);
            if (responce == null)
            {
                return BadRequest("Логин или пароль неправильные");
            }
            
            return Ok(responce);
        }
        
        [HttpPost("register")]
        public async Task<IActionResult> Register(string username, string password, string email, string secretKey)
        {
            var employeeKey = _configuration.GetSection("SecretKeys")["EmployeeKey"];
            if (secretKey != employeeKey)
            {
                return BadRequest("Секретный ключ неправильный!");
            }
            var response = await _aaService.Register(username, password, email);
            if (response == null)
            {
                return BadRequest("Данный логин или пароль уже используются");
            }

            return Ok(response);
        }
    }
}