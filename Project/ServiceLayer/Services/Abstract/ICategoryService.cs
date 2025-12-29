using EntityLayer.WebApp.ViewModels.Category;
using ServiceLayer.Services.GenericService;

namespace ServiceLayer.Services.Abstract
{
    public interface ICategoryService : IGenericService<CategoryListVM,CategoryAddVM,CategoryUpDateVM,int>
    {
    }
}
