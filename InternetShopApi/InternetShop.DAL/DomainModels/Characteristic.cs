using System.Collections.Generic;

namespace InternetShop.DAL.DomainModels
{
    public class Characteristic : IBaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<ProductCharacteristic> ProductCharacteristics { get; set; }
    }
}