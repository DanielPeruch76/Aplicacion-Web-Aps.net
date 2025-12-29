using AutoMapper;
using EntityLayer.WebApp.Entities;
using EntityLayer.WebApp.ViewModels.Category;

namespace ServiceLayer.AutoMapper.WebApp
{
    public class CategoryMapper : Profile
    {
        public CategoryMapper()
        {
            CreateMap<Category,CategoryListVM>().ReverseMap();
            CreateMap<Category, CategoryAddVM>().ReverseMap();
            CreateMap<Category, CategoryUpDateVM>().ReverseMap();
        }
    }
}
