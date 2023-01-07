using System;

namespace InternetShop.DAL
{
    public class Order
    {
        public string OrderId { get; set; }
        public int ProductId { get; set; }
        public string OrderDetailId { get; set; }
        public OrderDetail OrderDetail { get; set; }
    }
}