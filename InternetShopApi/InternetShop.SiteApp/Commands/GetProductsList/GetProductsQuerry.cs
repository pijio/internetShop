using MediatR;
using InternetShop.DAL;
namespace InternetShop.SiteApp.Commands.GetProductsList
{
    public class GetProductsQuerry : IRequest<Product[]>
    {
        
    }
}