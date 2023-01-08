using System;

namespace InternetShop.DAL
{
    public class Order : IBaseEntity
    {
        public string OrderId { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public string OrderDetailId { get; set; }
        public OrderDetail OrderDetail { get; set; }
    }
}