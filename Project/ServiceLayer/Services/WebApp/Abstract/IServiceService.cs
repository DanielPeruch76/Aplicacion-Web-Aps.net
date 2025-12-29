using EntityLayer.WebApp.ViewModels.Service;
using ServiceLayer.Services.WebApp.GenericService;

namespace ServiceLayer.Services.WebApp.Abstract
{
    public interface IServiceService : IGenericService<ServiceListVM, ServiceAddVM, ServiceUpdateVM, int>
    {
    }
}
