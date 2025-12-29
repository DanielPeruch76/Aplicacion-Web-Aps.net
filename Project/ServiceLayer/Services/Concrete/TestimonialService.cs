using AutoMapper;
using EntityLayer.WebApp.Entities;
using EntityLayer.WebApp.ViewModels.Testimonial;
using RepositoryLayer.UnitOfWork.Abstract;
using ServiceLayer.Services.Abstract;
using ServiceLayer.Services.GenericService;

namespace ServiceLayer.Services.Concrete
{
    public class TestimonialService : GenericService<Testimonial, TestimonialListVM, TestimonialAddVM, TestimonialUpdateVM, int>,
        ITestimonialService
    {
        public TestimonialService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }
    }
}
