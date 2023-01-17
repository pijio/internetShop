namespace InternetShop.DAL.DomainModels
{
    public class Category : IBaseEntity
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
    }
}