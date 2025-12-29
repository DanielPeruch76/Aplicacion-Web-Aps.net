using EntityLayer.WebApp.ViewModels.Portafolio;
using ServiceLayer.Services.WebApp.GenericService;

namespace ServiceLayer.Services.WebApp.Abstract
{
    public interface IPortafolioService : IGenericService<PortafolioListVM, PortafolioAddVM, PortafolioUpdateVM, int>
    {
    }
}
