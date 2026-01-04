using EntityLayer.WebApp.ViewModels.Contact;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.Services.WebApp.Abstract;

namespace Project.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ContactUsController : Controller
    {
        private readonly IContactUsService _contactUsService;
        private readonly IValidator<ContactUsAddVM> _addValidator;
        private readonly IValidator<ContactUsUpdateVM> _updateValidator;

        public ContactUsController(IContactUsService contactUsService, IValidator<ContactUsAddVM> addValidator, IValidator<ContactUsUpdateVM> updateValidator)
        {
            _contactUsService = contactUsService;
            _addValidator = addValidator;
            _updateValidator = updateValidator;
        }

        public async Task<IActionResult> GetContactUsList()
        {
            var contactUsList = await _contactUsService.GetAllListAsync();
            return View(contactUsList);
        }

        [HttpGet]
        public IActionResult AddContactUs()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddContactUs(ContactUsAddVM request)
        {
            var validation = await _addValidator.ValidateAsync(request);
            if (validation.IsValid)
            {
                await _contactUsService.AddAsync(request);
                return RedirectToAction("GetContactUsList", "ContactUs", new { Area = ("Admin") });
            }
            validation.AddToModelState(this.ModelState);
            return View();

        }

        [HttpGet]
        public async Task<IActionResult> UpdateContactUs(int id)
        {
            var contactUs = await _contactUsService.GetByIdAsync(id);
            return View(contactUs);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateContactUs(ContactUsUpdateVM request)
        {
            var validation = await _updateValidator.ValidateAsync(request);
            if (validation.IsValid)
            {
                await _contactUsService.UpDateAsync(request);
                return RedirectToAction("GetContactUsList", "ContactUs", new { Area = ("Admin") });
            }
            validation.AddToModelState(this.ModelState);
            return View();
        }

        public async Task<IActionResult> DeleteContactUs(int id)
        {
            await _contactUsService.DeleteAsync(id);
            return RedirectToAction("GetContactUsList", "ContactUs", new { Area = ("Admin") });
        }
    }
}
