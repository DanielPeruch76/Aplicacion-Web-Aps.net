using EntityLayer.WebApp.ViewModels.Portafolio;
using ServiceLayer.Services.GenericService;

namespace ServiceLayer.Services.Abstract
{
    public interface IPortafolioService : IGenericService<PortafolioListVM, PortafolioAddVM, PortafolioUpdateVM, int>
    {
    }
}
