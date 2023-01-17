using System.Text.Json.Serialization;
using InternetShop.DAL;
using InternetShop.DAL.DomainModels;

namespace InternetShop.Api.RepresentationModels
{
    public class ProductModel
    {
        #region Model props

        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("inStock")]
        public bool InStock { get; set; }
        [JsonPropertyName("key")]
        public int Key { get; set; }
        [JsonPropertyName("imageUrl")]
        public string ImageUrl { get; set; }
        [JsonPropertyName("imageUrl1")]
        public string ImageUrl1 { get; set; }
        [JsonPropertyName("imageUrl2")]
        public string ImageUrl2 { get; set; }
        [JsonPropertyName("imageUrl3")]
        public string ImageUrl3 { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("price")]
        public double Price { get; set; }
        [JsonPropertyName("category")]
        public string Category { get; set; }
        [JsonPropertyName("popular")]
        public int Rate { get; set; }
        [JsonPropertyName("videoUrl")]
        public string VideoUrl { get; set; }
        [JsonPropertyName("title")]
        public string Title { get; set; }
        #endregion

        public static explicit operator ProductModel(Product product)
        {
            var model = new ProductModel();
            model.Id = product.ProductId;
            model.InStock = product.InStock;
            model.Key = product.ProductTypeID;
            if (product.AdditInfo != null)
            {
                model.ImageUrl = product.AdditInfo.ImageUrl;
                model.ImageUrl1 = product.AdditInfo.ImageUrl1;
                model.ImageUrl2 = product.AdditInfo.ImageUrl2;
                model.ImageUrl3 = product.AdditInfo.ImageUrl3;
                model.VideoUrl = product.AdditInfo.VideoUrl;
            }

            model.Name = product.Name;
            model.Price = product.Price;
            model.Category = product.Category != null ? product.Category.CategoryName : "";
            model.Rate = (int)product.Rate;
            model.Title = product.Title;
            return model;
        }
    }
}