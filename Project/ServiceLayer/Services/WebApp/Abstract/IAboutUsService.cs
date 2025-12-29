using EntityLayer.WebApp.ViewModels.AboutUsVM;
using ServiceLayer.Services.WebApp.GenericService;

namespace ServiceLayer.Services.WebApp.Abstract
{
    public interface IAboutUsService : IGenericService<AboutUsListVM,AboutUsAddVM,AboutUsUpDateVM,int>
    {

    }
}
