using AutoMapper;
using EntityLayer.WebApp.Entities;
using EntityLayer.WebApp.ViewModels.AboutUsVM;


namespace ServiceLayer.AutoMapper.WebApp
{
    public class AboutUsMapper : Profile
    {
        public AboutUsMapper()
        {
            CreateMap<AboutUs,AboutUsListVM>().ReverseMap();
            CreateMap<AboutUs, AboutUsAddVM>().ReverseMap();
            CreateMap<AboutUs, AboutUsUpDateVM>().ReverseMap();
        }
    }
}
