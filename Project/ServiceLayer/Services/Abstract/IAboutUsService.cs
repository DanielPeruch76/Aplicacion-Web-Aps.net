using EntityLayer.WebApp.ViewModels.AboutUsVM;
using ServiceLayer.Services.GenericService;

namespace ServiceLayer.Services.Abstract
{
    public interface IAboutUsService : IGenericService<AboutUsListVM,AboutUsAddVM,AboutUsUpDateVM,int>
    {

    }
}
