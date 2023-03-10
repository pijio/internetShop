using System;
using System.Threading.Tasks;
using InternetShop.Api.RepresentationModels;
using InternetShop.DAL;
using InternetShop.SiteApp.Commands.GetFiltredProductList;
using InternetShop.SiteApp.Commands.GetProductsList;
using InternetShop.SiteApp.Commands.MakeOrder;
using InternetShop.SiteApp.Services.CustomLogger;
using MediatR;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using NLog;

namespace InternetShop.Api.Controllers
{
    [ApiController]
    [EnableCors("ShopApiPolicy")]
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
        
        [HttpGet("products")]
        public async Task<ProductModel[]> GetProducts()
        {
            return Array.ConvertAll(await _mediator.Send(new GetProductsQuery()), item => (ProductModel)item);
        }
        [HttpGet("filtredProducts")]
        public async Task<ProductModel[]> GetFiltredProducts(string category, byte order, bool orderDirection)
        {
            return Array.ConvertAll(
                await _mediator.Send(new FiltersQuery(category, (OrderedProps)order, orderDirection)),
                item => (ProductModel)item);
        }

        [HttpPost("makeorder")]
        public async Task<IActionResult> MakeOrder(MakeOrderQuery orderData)
        {
            try
            {
                await _mediator.Send(orderData);
                return Ok();
            }
            catch (InvalidOperationException e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}