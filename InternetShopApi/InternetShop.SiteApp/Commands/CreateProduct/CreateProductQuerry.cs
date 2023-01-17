using System.Collections;
using System.Collections.Generic;
using MediatR;

namespace InternetShop.SiteApp.Commands.CreateProduct
{
    public class CreateProductQuery : IRequest
    {
        public string ProductName { get; set; }
        public string ProductTitle { get; set; }
        public bool InStock { get; set; }
        public double Price { get; set; }
        public ProductInfoModel AdditInfo { get; set; }
        public int ProductTypeId { get; set; }
    }

    public class ProductInfoModel
    {
        public string YoutubeUrl { get; set; }
        public IEnumerable<string> ImagesUrl { get; set; }
    }
}