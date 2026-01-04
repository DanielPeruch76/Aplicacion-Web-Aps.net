using EntityLayer.WebApp.ViewModels.Service;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.Services.WebApp.Abstract;

namespace Project.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ServiceController : Controller
    {
        private readonly IServiceService _serviceService;
        private readonly IValidator<ServiceAddVM> _addValidator;
        private readonly IValidator<ServiceUpdateVM> _updateValidator;

        public ServiceController(IServiceService serviceService)
        {
            _serviceService = serviceService;
        }
        public async Task<IActionResult> GetServiceList()
        {
            var service = await _serviceService.GetAllListAsync();
            return View(service);
        }

        [HttpGet]
        public IActionResult AddService()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddService(ServiceAddVM request)
        {
            var validation = await _addValidator.ValidateAsync(request);
            if (validation.IsValid)
            {
                await _serviceService.AddAsync(request);
                return RedirectToAction("GetServiceList", "Service", new { Area = ("Admin") });
            }
            validation.AddToModelState(this.ModelState);
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> UpdateService(int id)
        {
            var service = await _serviceService.GetByIdAsync(id);
            return View(service);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateService(ServiceUpdateVM request)
        {
            var validation = await _updateValidator.ValidateAsync(request);
            if (validation.IsValid)
            {
                await _serviceService.UpDateAsync(request);
                return RedirectToAction("GetServiceList", "Service", new { Area = ("Admin") });
            }
            validation.AddToModelState(this.ModelState);
            return View();
        }
               

        public async Task<IActionResult> DeleteService(int id)
        {
            await _serviceService.DeleteAsync(id);
            return RedirectToAction("GetServiceList", "Service", new { Area = ("Admin") });
        }

    }
}
