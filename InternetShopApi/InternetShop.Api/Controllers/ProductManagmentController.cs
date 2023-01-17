using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using InternetShop.Api.Infrastructure.Attributes;
using InternetShop.DAL;
using InternetShop.DAL.DomainModels;
using InternetShop.SiteApp.Commands.CreateProduct;
using InternetShop.SiteApp.Commands.GetProductTypes;
using InternetShop.SiteApp.Services.CustomLogger;
using MediatR;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using NLog;

namespace InternetShop.Api.Controllers
{
    [EnableCors("ShopApiPolicy")]
    [ApiController]
    [Route("/product")]
    public class ProductManagmentController : ControllerBase
    {
        private readonly IUnitOfWork _uow;
        private readonly IMediator _mediator;
        private readonly Logger _logger;

        public ProductManagmentController(IUnitOfWork uow, IMediator mediator, ICustomLogger logger)
        {
            _uow = uow;
            _mediator = mediator;
            _logger = logger.Manager;
        }


        [HttpPost("/create")]
        [Authorize]
        public async Task<IActionResult> CreateProduct([FromBody] CreateProductQuery productQuerry)
        {
            try
            {
            }
            catch 
            {
            }
            return Ok();
        }

        [HttpGet("/directories/types")]
        [Authorize]
        public async Task<ProductType[]> GetProductTypes()
        {
            return await _mediator.Send(new ProductTypesQuery());
        }
        
        
    }
}