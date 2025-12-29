using EntityLayer.WebApp.ViewModels.Category;
using ServiceLayer.Services.WebApp.GenericService;

namespace ServiceLayer.Services.WebApp.Abstract
{
    public interface ICategoryService : IGenericService<CategoryListVM,CategoryAddVM,CategoryUpDateVM,int>
    {
    }
}
