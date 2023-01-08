using System.Collections.Generic;

namespace InternetShop.DAL
{
    public class Product : IBaseEntity
    {
        public int ProductId { get; set; }
        public bool InStock { get; set; }
        public int ProductTypeID { get; set; }
        public ProductType ProductType { get; set; }
        public string Name { get; set; }
        public double Rate { get; set; }
        public string Title { get; set; }
        public int CharactId { get; set; }
        public double Price { get; set; }
        public Characteristics Characteristics { get; set; }
        public int InfoId { get; set; }
        public ProductAdditInfo AdditInfo { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public List<Order> Orders { get; set; } = new();
    }
}