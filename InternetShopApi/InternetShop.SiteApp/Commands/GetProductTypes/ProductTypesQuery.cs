using InternetShop.DAL;
using InternetShop.DAL.DomainModels;
using MediatR;

namespace InternetShop.SiteApp.Commands.GetProductTypes
{
    public class ProductTypesQuery : IRequest<ProductType[]>
    {
        
    }
}