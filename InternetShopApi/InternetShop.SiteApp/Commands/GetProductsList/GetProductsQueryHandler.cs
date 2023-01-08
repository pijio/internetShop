using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using InternetShop.DAL;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace InternetShop.SiteApp.Commands.GetProductsList
{
    public class GetProductsQueryHandler : IRequestHandler<GetProductsQuery, Product[]>
    {
        private readonly IUnitOfWork _uow;

        public GetProductsQueryHandler(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public async Task<Product[]> Handle(GetProductsQuery querry, CancellationToken cancellationToken)
        {
            var result = (await _uow.GetGenericRepository<Product>().GetAllAsync())
                .Include(p => p.Category)
                .Include(p => p.Characteristics)
                .Include(p => p.AdditInfo)
                .Include(p => p.ProductType);
            return result.ToArray();
        }
    }
}