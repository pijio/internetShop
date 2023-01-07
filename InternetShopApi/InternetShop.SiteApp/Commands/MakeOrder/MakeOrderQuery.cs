namespace InternetShop.SiteApp.Commands.MakeOrder
{
    public class MakeOrderQuery
    {
        public string CustomerName { get; set; }
        public string PhoneNumber { get; set; }
        public string OrderDetails { get; set; }
        public int[] OrderProducts { get; set; }
    }
}