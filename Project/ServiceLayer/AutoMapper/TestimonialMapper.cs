using AutoMapper;
using EntityLayer.WebApp.Entities;
using EntityLayer.WebApp.ViewModels.Testimonial;
namespace ServiceLayer.AutoMapper
{
    public class TestimonialMapper : Profile
    {
        public TestimonialMapper()
        {
            CreateMap<Testimonial,TestimonialAddVM>().ReverseMap();
            CreateMap<Testimonial,TestimonialListVM>().ReverseMap();
            CreateMap<Testimonial,TestimonialUpdateVM>().ReverseMap();
        }
    }
}
