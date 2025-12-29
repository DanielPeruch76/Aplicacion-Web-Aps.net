using EntityLayer.WebApp.ViewModels.Testimonial;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.Services.Abstract;

namespace Project.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TestimonialController : Controller
    {
       private readonly ITestimonialService _testimonialService;

        public TestimonialController(ITestimonialService testimonialService)
        {
            _testimonialService = testimonialService;
        }

        public async Task<IActionResult> GetTestimonialList()
        {
            var testimonial = await _testimonialService.GetAllListAsync();
            return View(testimonial);
        }

        [HttpGet]
        public IActionResult AddTestimonial()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddTestimonial(TestimonialAddVM request)
        {
            await _testimonialService.AddAsync(request);
            return RedirectToAction("GetTestimonialList", "Testimonial", new { Area = ("Admin") });
        }

        [HttpGet]
        public async Task<IActionResult> UpdateTestimonial(int id)
        {
            var testimonial = await _testimonialService.GetByIdAsync(id);
            return View(testimonial);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateTestimonial(TestimonialUpdateVM request)
        {
            await _testimonialService.UpDateAsync(request);
            return RedirectToAction("GetTestimonialList", "Testimonial", new { Area = ("Admin") });
        }

        public async Task<IActionResult> DeleteTestimonial(int id)
        {
            await _testimonialService.DeleteAsync(id);
            return RedirectToAction("GetTestimonialList", "Testimonial", new { Area = ("Admin") });
        }
    }
}
