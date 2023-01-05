using System.Collections.Generic;

namespace InternetShop.DAL
{
    public class Category : IBaseEntity
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
    }
}