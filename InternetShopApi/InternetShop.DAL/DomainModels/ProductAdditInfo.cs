namespace InternetShop.DAL.DomainModels
{
    public class ProductAdditInfo : IBaseEntity
    {
        public int InfoId { get; set; }
        public string ImageUrl { get; set; }
        public string ImageUrl1 { get; set; }
        public string ImageUrl2 { get; set; }
        public string ImageUrl3 { get; set; }
        public string VideoUrl { get; set; }
    }
}