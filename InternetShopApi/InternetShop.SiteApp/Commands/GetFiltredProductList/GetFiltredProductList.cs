using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using InternetShop.DAL;
using InternetShop.SiteApp.Commands.GetProductsList;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace InternetShop.SiteApp.Commands.GetFiltredProductList
{
    public class GetFiltredProductList : IRequestHandler<FiltersQuery, Product[]>
    {
        public readonly IUnitOfWork _uow;
        public GetFiltredProductList(IUnitOfWork uow)
        {
            _uow = uow;
        }
        public async Task<Product[]> Handle(FiltersQuery querry, CancellationToken cancellationToken)
        {
            var products = (await _uow.GetGenericRepository<Product>().GetAllAsync())
                .Include(p => p.Category)
                .Include(p => p.Characteristics)
                .Include(p => p.AdditInfo)
                .Include(p => p.ProductType).ToArray();
            switch (querry.Order)
            {
                case OrderedProps.InStock:
                    products = products.Where(x => x.InStock).ToArray();
                    break;
                case OrderedProps.PriceAsc:
                case OrderedProps.PriceDesc:
                    products = (querry.Order==OrderedProps.PriceDesc 
                        ? products.OrderByDescending(x => x.Price)
                        : products.OrderBy(x => x.Price)).ToArray();
                    break;
                case OrderedProps.Rate:
                    products = (querry.Direction
                        ? products.OrderByDescending(x => x.Rate)
                        : products.OrderBy(x => x.Rate)).ToArray();
                    break;
            }
            
            if (querry.CategoryName != null)
            {
                products = products.Where(x => x.ProductTypeID.ToString() == querry.CategoryName).ToArray();
            }

            return products;

        }
    }
}