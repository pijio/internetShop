using System.Text.Json.Serialization;
using InternetShop.DAL;

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
        [JsonPropertyName("processor")]
        public string Processor { get; set; }
        [JsonPropertyName("ram")]
        public string Ram { get; set; }
        [JsonPropertyName("screenSizes")]
        public string ScreenSize { get; set; }
        [JsonPropertyName("price")]
        public double Price { get; set; }
        [JsonPropertyName("category")]
        public string Category { get; set; }
        [JsonPropertyName("os")]
        public string Os { get; set; }    
        [JsonPropertyName("disc")]
        public string Disc { get; set; }       
        [JsonPropertyName("popular")]
        public int Rate { get; set; }
        [JsonPropertyName("videoUrl")]
        public string VideoUrl { get; set; }
        [JsonPropertyName("title")]
        public string Title { get; set; }
        [JsonPropertyName("printer_ram")]
        public string PrinterRam { get; set; }
        [JsonPropertyName("dpi")]
        public string Dpi { get; set; }
        [JsonPropertyName("type")]
        public string PrinterType { get; set; }
        [JsonPropertyName("format")]
        public string Format { get; set; }
        [JsonPropertyName("ppm")]
        public string MatrixType { get; set; }
        #endregion

        public static explicit operator ProductModel(Product product)
        {
            var model = new ProductModel();
            model.Id = product.ProductId;
            model.InStock = product.InStock;
            model.Key = product.Key;
            if (product.AdditInfo != null)
            {
                model.ImageUrl = product.AdditInfo.ImageUrl;
                model.ImageUrl1 = product.AdditInfo.ImageUrl1;
                model.ImageUrl2 = product.AdditInfo.ImageUrl2;
                model.ImageUrl3 = product.AdditInfo.ImageUrl3;
                model.VideoUrl = product.AdditInfo.VideoUrl;
            }

            model.Name = product.Name;
            if (product.Characteristics != null)
            {
                model.Processor = product.Characteristics.Processor;
                model.Os = product.Characteristics.Os;
                model.Ram = product.Characteristics.Ram.HasValue ? $"{product.Characteristics.Ram}GB" : "";
                model.ScreenSize = product.Characteristics.ScreenSize.HasValue
                    ? $"{product.Characteristics.ScreenSize}'"
                    : "";
                model.Format = product.Characteristics.Format ?? "";
                model.PrinterRam = product.Characteristics.PrinterRam ?? "";
                model.PrinterType = product.Characteristics.PrinterType ?? "";
                model.MatrixType = product.Characteristics.MatrixType ?? "";
                model.Dpi = product.Characteristics.Dpi ?? "";
                model.Disc = product.Characteristics.DiscVolAndType;
            }
            model.Price = product.Price;
            model.Category = product.Category != null ? product.Category.CategoryName : "";
            model.Rate = (int)product.Rate;
            model.Title = product.Title;
            return model;
        }
    }
}