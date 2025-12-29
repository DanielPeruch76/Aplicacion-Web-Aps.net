using AutoMapper;
using EntityLayer.WebApp.Entities;
using EntityLayer.WebApp.ViewModels.Portafolio;

namespace ServiceLayer.AutoMapper
{
    public class PortafolioMapper : Profile
    {
        public PortafolioMapper()
        {
            CreateMap<Portafolio,PortafolioAddVM>().ReverseMap();
            CreateMap<Portafolio,PortafolioListVM>().ReverseMap();
            CreateMap<Portafolio,PortafolioUpdateVM>().ReverseMap();
        }
    }
}
