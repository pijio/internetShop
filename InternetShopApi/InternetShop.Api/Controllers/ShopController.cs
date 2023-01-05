using InternetShop.Api.CustomLogger;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using NLog;

namespace InternetShop.Api.Controllers
{
    [ApiController]
    [Route("/shop")]
    public class ShopController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly Logger _logManger;
        
        public ShopController(IMediator mediator, ICustomLogger logger)
        {
            _mediator = mediator;
            _logManger = logger.Manager;
        }
    }
}