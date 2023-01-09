using System.Threading.Tasks;
using InternetShop.Api.Services.AAS;
using InternetShop.SiteApp.Services.CustomLogger;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using NLog;

namespace InternetShop.Api.Controllers
{
    
    [ApiController]
    [EnableCors("ShopApiPolicy")]
    [Route("/shop")]
    public class UserController : ControllerBase
    {
        private readonly Logger _logger;
        private readonly AAService _aaService;
        public UserController(AAService service, ICustomLogger logger)
        {
            _aaService = service;
            _logger = logger.Manager;
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
        public async Task<IActionResult> Register(string username, string password, string email)
        {
            var response = await _aaService.Register(username, password, email);
            if (response == null)
            {
                return BadRequest("Данный логин или пароль уже используются");
            }

            return Ok(response);
        }
    }
}