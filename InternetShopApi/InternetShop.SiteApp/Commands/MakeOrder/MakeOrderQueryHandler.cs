using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using InternetShop.DAL;
using InternetShop.DAL.DomainModels;
using InternetShop.SiteApp.Commands.OrderCreateNotification;
using MediatR;

namespace InternetShop.SiteApp.Commands.MakeOrder
{
    public class MakeOrderQueryHandler : IRequestHandler<MakeOrderQuery, string>
    {
        private readonly IUnitOfWork _uow;
        private readonly IMediator _mediator;

        public MakeOrderQueryHandler(IMediator mediator, IUnitOfWork uow)
        {
            _uow = uow;
            _mediator = mediator;
        }

        public async Task<string> Handle(MakeOrderQuery query, CancellationToken token)
        {
            var details = new OrderDetail(query.CustomerName, query.PhoneNumber, query.OrderDetails);
            var orderParts = new List<Order>();
            var orderId = Guid.NewGuid().ToString();
            var products = (await _uow.GetGenericRepository<Product>().GetAllAsync()).ToArray();
            if(!query.OrderProducts.Any(x => products.Any(y => y.ProductId == x.ProductId)))
            {
                throw new InvalidOperationException("Указанных в заказе товаров не существует в базе данных");
            }
            foreach (var product in query.OrderProducts)
            {
                orderParts.Add(new Order
                {
                    OrderId = orderId, ProductId = product.ProductId, OrderDetailId = details.Id,
                    ProductCount = product.ProductCount
                });
            }
            await _uow.GetGenericRepository<OrderDetail>().AddAsync(details);
            await _uow.GetGenericRepository<Order>().AddRangeAsync(orderParts);
            await _uow.SaveChangesAsync();
            await _mediator.Publish(new OrderCreated(orderId), token);
            return orderId;
        }
    }
}