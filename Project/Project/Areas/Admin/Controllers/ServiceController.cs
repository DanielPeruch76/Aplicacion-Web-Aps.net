using EntityLayer.WebApp.ViewModels.Service;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.Services.WebApp.Abstract;

namespace Project.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ServiceController : Controller
    {
        private readonly IServiceService _serviceService;

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
            await _serviceService.AddAsync(request);
            return RedirectToAction("GetServiceList", "Service", new { Area = ("Admin") });
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
            await _serviceService.UpDateAsync(request);
            return RedirectToAction("GetServiceList", "Service", new { Area = ("Admin") });
        }

        public async Task<IActionResult> DeleteService(int id)
        {
            await _serviceService.DeleteAsync(id);
            return RedirectToAction("GetServiceList", "Service", new { Area = ("Admin") });
        }

    }
}
