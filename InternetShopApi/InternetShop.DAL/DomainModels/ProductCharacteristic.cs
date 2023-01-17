namespace InternetShop.DAL.DomainModels
{
    public class ProductCharacteristic : IBaseEntity
    {
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int CharacteristicId { get; set; }
        public Characteristic Characteristic { get; set; }
        public string Value { get; set; }
    }
}