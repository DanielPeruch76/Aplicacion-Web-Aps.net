using EntityLayer.WebApp.ViewModels.HomePage;
using ServiceLayer.Services.WebApp.GenericService;

namespace ServiceLayer.Services.WebApp.Abstract
{
    public interface IHomePageService : IGenericService<HomePageListVM,HomePageAddVM,HomePageUpdateVM,int>
    {
    }
}
