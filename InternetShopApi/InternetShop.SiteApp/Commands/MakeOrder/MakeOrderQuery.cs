using MediatR;

namespace InternetShop.SiteApp.Commands.MakeOrder
{
    public class MakeOrderQuery : IRequest<string>
    {
        public string CustomerName { get; set; }
        public string PhoneNumber { get; set; }
        public string OrderDetails { get; set; }
        public ProductDetails[] OrderProducts { get; set; }
        public class ProductDetails
        {
            public int ProductId { get; set; }
            public int ProductCount { get; set; }
        }
    }
}