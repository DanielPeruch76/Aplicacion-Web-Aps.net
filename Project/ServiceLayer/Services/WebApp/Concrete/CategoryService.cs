using AutoMapper;
using EntityLayer.WebApp.Entities;
using EntityLayer.WebApp.ViewModels.Category;
using RepositoryLayer.UnitOfWork.Abstract;
using ServiceLayer.Services.WebApp.Abstract;
using ServiceLayer.Services.WebApp.GenericService;

namespace ServiceLayer.Services.WebApp.Concrete
{
    public class CategoryService : GenericService<Category, CategoryListVM, CategoryAddVM, CategoryUpDateVM, int>,
        ICategoryService
    {
        public CategoryService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }
    }
}
