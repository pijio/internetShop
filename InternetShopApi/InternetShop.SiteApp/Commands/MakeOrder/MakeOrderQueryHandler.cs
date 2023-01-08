using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using InternetShop.DAL;
using MediatR;

namespace InternetShop.SiteApp.Commands.MakeOrder
{
    public class MakeOrderQueryHandler : IRequestHandler<MakeOrderQuery, string>
    {
        private readonly IUnitOfWork _uow;

        public MakeOrderQueryHandler(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public async Task<string> Handle(MakeOrderQuery query, CancellationToken token)
        {
            var details = new OrderDetail(query.CustomerName, query.PhoneNumber, query.OrderDetails);
            var orderParts = new List<Order>();
            var orderId = Guid.NewGuid().ToString();
            var products = (await _uow.GetGenericRepository<Product>().GetAllAsync()).ToArray();
            if(!query.OrderProducts.Any(x => products.Any(y => y.ProductId == x)))
            {
                throw new InvalidOperationException("Указанных в заказе товаров не существует в базе данных");
            }
            foreach (var productId in query.OrderProducts)
            {
                
                orderParts.Add(new Order() { OrderId = orderId, ProductId = productId, OrderDetailId = details.Id });
            }
            await _uow.GetGenericRepository<OrderDetail>().AddAsync(details);
            await _uow.GetGenericRepository<Order>().AddRangeAsync(orderParts);
            await _uow.SaveChangesAsync();
            return orderId;
        }
    }
}