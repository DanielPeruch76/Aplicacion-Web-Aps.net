using AutoMapper;
using EntityLayer.WebApp.Entities;
using EntityLayer.WebApp.ViewModels.SocialMedia;

namespace ServiceLayer.AutoMapper
{
    public class SocialMediaMapper : Profile
    {
        public SocialMediaMapper()
        {
            CreateMap<SocialMedia,SocialMediaAddVM>().ReverseMap();
            CreateMap<SocialMedia,SocialMediaListVM>().ReverseMap();
            CreateMap<SocialMedia,SocialMediaUpdateVM>().ReverseMap();
        }
    }
}
