using EntityLayer.WebApp.ViewModels.AboutUsVM;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.Services.WebApp.Abstract;


namespace Project.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AboutUsController : Controller
    {
        private readonly IAboutUsService _aboutUsService;

        public AboutUsController(IAboutUsService aboutUsService)
        {
            _aboutUsService = aboutUsService;
        }
        public async Task<IActionResult> GetAboutUsList()
        {
            var aboutUsList = await _aboutUsService.GetAllListAsync();
            return View(aboutUsList);
        }

        [HttpGet]
        public IActionResult AddAboutUs()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddAboutUs(AboutUsAddVM request)
        {
            await _aboutUsService.AddAsync(request);
            return RedirectToAction("GetAboutUsList", "AboutUs", new { Area = ("Admin") });
        }

        [HttpGet]
        public async Task<IActionResult> UpdateAboutUs(int id)
        {
            var about = await _aboutUsService.GetByIdAsync(id);
            return View(about);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateAboutUs(AboutUsUpDateVM request)
        {
            await _aboutUsService.UpDateAsync(request);
            return RedirectToAction("GetAboutUsList", "AboutUs", new { Area = ("Admin") });
        }
         
        public async Task<IActionResult> DeleteAboutUs(int id)
        {
            await _aboutUsService.DeleteAsync(id);
            return RedirectToAction("GetAboutUsList", "AboutUs", new { Area = ("Admin") });
        }


    }
}
