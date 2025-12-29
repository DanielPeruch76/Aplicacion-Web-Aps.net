using EntityLayer.WebApp.ViewModels.Testimonial;
using ServiceLayer.Services.WebApp.GenericService;

namespace ServiceLayer.Services.WebApp.Abstract
{
    public interface ITestimonialService : IGenericService<TestimonialListVM,TestimonialAddVM, TestimonialUpdateVM, int>
    {
    }
}
