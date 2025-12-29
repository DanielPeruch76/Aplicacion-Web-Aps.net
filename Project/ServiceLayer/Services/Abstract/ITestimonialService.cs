using EntityLayer.WebApp.ViewModels.Testimonial;
using ServiceLayer.Services.GenericService;

namespace ServiceLayer.Services.Abstract
{
    public interface ITestimonialService : IGenericService<TestimonialListVM,TestimonialAddVM, TestimonialUpdateVM, int>
    {
    }
}
