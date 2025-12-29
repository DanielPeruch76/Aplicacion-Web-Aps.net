using AutoMapper;
using EntityLayer.WebApp.Entities;
using EntityLayer.WebApp.ViewModels.HomePage;

namespace ServiceLayer.AutoMapper
{
    public class HomePageMapper : Profile
    {
        public HomePageMapper()
        {
            CreateMap<HomePage, HomePageAddVM>().ReverseMap();
            CreateMap<HomePage, HomePageListVM>().ReverseMap();
            CreateMap<HomePage, HomePageUpdateVM>().ReverseMap();
        }
    }
}
