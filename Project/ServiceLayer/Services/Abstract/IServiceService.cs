using EntityLayer.WebApp.ViewModels.Service;
using ServiceLayer.Services.GenericService;

namespace ServiceLayer.Services.Abstract
{
    public interface IServiceService : IGenericService<ServiceListVM, ServiceAddVM, ServiceUpdateVM, int>
    {
    }
}
