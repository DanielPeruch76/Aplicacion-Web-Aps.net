using EntityLayer.WebApp.ViewModels.AboutUsVM;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.Services.WebApp.Abstract;


namespace Project.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AboutUsController : Controller
    {
        private readonly IAboutUsService _aboutUsService;
        private readonly IValidator<AboutUsAddVM> _addValidator;
        private readonly IValidator<AboutUsUpDateVM> _updateValidator;

        public AboutUsController(IAboutUsService aboutUsService, IValidator<AboutUsAddVM> addValidator, IValidator<AboutUsUpDateVM> updateValidator)
        {
            _aboutUsService = aboutUsService;
            _addValidator = addValidator;
            _updateValidator = updateValidator;
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
            var validation = await _addValidator.ValidateAsync(request);
            if (validation.IsValid)
            {
                await _aboutUsService.AddAsync(request);
                return RedirectToAction("GetAboutUsList", "AboutUs", new { Area = ("Admin") });
            }
            validation.AddToModelState(this.ModelState);
            return View();
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
            var validation = await _updateValidator.ValidateAsync(request);
            if (validation.IsValid)
            {
                await _aboutUsService.UpDateAsync(request);
                return RedirectToAction("GetAboutUsList", "AboutUs", new { Area = ("Admin") });
            }
            validation.AddToModelState(this.ModelState);
            return View();
        }
         
        public async Task<IActionResult> DeleteAboutUs(int id)
        {
            await _aboutUsService.DeleteAsync(id);
            return RedirectToAction("GetAboutUsList", "AboutUs", new { Area = ("Admin") });
        }


    }
}
