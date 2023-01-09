using System.Collections.Generic;
using InternetShop.DAL;
using MediatR;

namespace InternetShop.SiteApp.Commands.OrderCreateNotification
{
    public class OrderCreated : INotification
    {
        public string OrderId { get; }
        public OrderCreated(string orderId)
        {
            OrderId = orderId;
        }
    }
}