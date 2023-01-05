using MediatR;
using InternetShop.DAL;
namespace InternetShop.SiteApp.Commands.GetProductsList
{
    public class GetProductsQuery : IRequest<Product[]>
    {
        // зеро параметров
    }
}