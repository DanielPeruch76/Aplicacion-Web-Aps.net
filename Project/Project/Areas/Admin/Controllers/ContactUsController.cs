using EntityLayer.WebApp.ViewModels.Contact;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.Services.WebApp.Abstract;

namespace Project.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ContactUsController : Controller
    {
        private IContactUsService _contactUsService;

        public ContactUsController(IContactUsService contactUsService)
        {
            this._contactUsService = contactUsService;
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
            await _contactUsService.AddAsync(request);
            return RedirectToAction("GetContactUsList", "ContactUs", new { Area = ("Admin") });
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
            await _contactUsService.UpDateAsync(request);
            return RedirectToAction("GetContactUsList", "ContactUs", new { Area = ("Admin") });
        }

        public async Task<IActionResult> DeleteContactUs(int id)
        {
            await _contactUsService.DeleteAsync(id);
            return RedirectToAction("GetContactUsList", "ContactUs", new { Area = ("Admin") });
        }
    }
}
