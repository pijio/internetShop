using InternetShop.DAL;
using InternetShop.DAL.DomainModels;
using MediatR;

namespace InternetShop.SiteApp.Commands.GetFiltredProductList
{
    public class FiltersQuery : IRequest<Product[]>
    {
        public string? CategoryName { get; set; }
        public OrderedProps Order { get; set; }
        public bool Direction { get; set; }

        public FiltersQuery(string? categoryName, OrderedProps order, bool direction)
        {
            CategoryName = categoryName;
            Order = order;
            Direction = direction;
        }
    }

    public enum OrderedProps : byte
    {
        Rate,
        Price,
        InStock
    }
}