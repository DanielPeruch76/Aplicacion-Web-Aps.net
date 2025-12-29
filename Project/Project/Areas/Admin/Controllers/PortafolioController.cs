using EntityLayer.WebApp.ViewModels.Portafolio;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.Services.Abstract;

namespace Project.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class PortafolioController : Controller
    {
        private readonly IPortafolioService _portafolioService;

        public PortafolioController(IPortafolioService portafolioService)
        {
            _portafolioService = portafolioService;
        }

        public async Task<IActionResult> GetPortafolioList()
        {
            var portafolio = await _portafolioService.GetAllListAsync();
            return View(portafolio);
        }

        [HttpGet]
        public IActionResult AddPortafolio()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddPortafolio(PortafolioAddVM request)
        {
            await _portafolioService.AddAsync(request);
            return RedirectToAction("GetPortafolioList", "Portafolio", new { Area = ("Admin") });
        }

        [HttpGet]
        public async Task<IActionResult> UpdatePortafolio(int id)
        {
            var portafolio = await _portafolioService.GetByIdAsync(id);
            return View(portafolio);
        }

        [HttpPost]
        public async Task<IActionResult> UpdatePortafolio(PortafolioUpdateVM request)
        {
            await _portafolioService.UpDateAsync(request);
            return RedirectToAction("GetPortafolioList", "Portafolio", new { Area = ("Admin") });
        }

        public async Task<IActionResult> DeletePortafolio(int id)
        {
            await _portafolioService.DeleteAsync(id);
            return RedirectToAction("GetPortafolioList", "Portafolio", new { Area = ("Admin") });
        }
    }
}
