using MediatR;
using InternetShop.DAL;
using InternetShop.DAL.DomainModels;

namespace InternetShop.SiteApp.Commands.GetProductsList
{
    public class GetProductsQuery : IRequest<Product[]>
    {
        // зеро параметров
    }
}