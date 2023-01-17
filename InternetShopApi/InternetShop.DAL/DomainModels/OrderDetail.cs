using System;

namespace InternetShop.DAL.DomainModels
{
    public class OrderDetail : IBaseEntity
    {
        public string Id { get; set; }
        public string CustomerName { get; set; }
        public string PhoneNumber { get; set; }
        public string AdressAndComment { get; set; }
        public DateTime OrderDate { get; set; }

        public OrderDetail() {}
        public OrderDetail(string customerName, string number, string info)
        {
            Id = Guid.NewGuid().ToString();
            CustomerName = customerName;
            PhoneNumber = number;
            AdressAndComment = info;
            OrderDate = DateTime.Now;
        }
    }
}