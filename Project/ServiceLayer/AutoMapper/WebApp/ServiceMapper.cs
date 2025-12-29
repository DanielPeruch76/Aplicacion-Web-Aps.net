using AutoMapper;
using EntityLayer.WebApp.Entities;
using EntityLayer.WebApp.ViewModels.Service;

namespace ServiceLayer.AutoMapper.WebApp
{
    public class ServiceMapper : Profile
    {
        public ServiceMapper()
        {
            CreateMap<Service,ServiceAddVM>().ReverseMap();
            CreateMap<Service,ServiceListVM>().ReverseMap();
            CreateMap<Service,ServiceUpdateVM>().ReverseMap();
        }
    }
}
