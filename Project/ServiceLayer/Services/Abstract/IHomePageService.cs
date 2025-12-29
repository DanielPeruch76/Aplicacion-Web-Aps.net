using EntityLayer.WebApp.ViewModels.HomePage;
using ServiceLayer.Services.GenericService;

namespace ServiceLayer.Services.Abstract
{
    public interface IHomePageService : IGenericService<HomePageListVM,HomePageAddVM,HomePageUpdateVM,int>
    {
    }
}
