using EntityLayer.WebApp.ViewModels.Portafolio;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.Services.WebApp.Abstract;

namespace Project.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class PortafolioController : Controller
    {
        private readonly IPortafolioService _portafolioService;
        private readonly IValidator<PortafolioAddVM> _addValidator;
        private readonly IValidator<PortafolioUpdateVM> _updateValidator;

        public PortafolioController(IPortafolioService portafolioService, IValidator<PortafolioAddVM> addValidator, IValidator<PortafolioUpdateVM> updateValidator)
        {
            _portafolioService = portafolioService;
            _addValidator = addValidator;
            _updateValidator = updateValidator;
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
            var validation = await _addValidator.ValidateAsync(request);
            if (validation.IsValid)
            {
                await _portafolioService.AddAsync(request);
                return RedirectToAction("GetPortafolioList", "Portafolio", new { Area = ("Admin") });
            }
            validation.AddToModelState(this.ModelState);
            return View();
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
            var validation = await _updateValidator.ValidateAsync(request);
            if (validation.IsValid)
            {
                await _portafolioService.UpDateAsync(request);
                return RedirectToAction("GetPortafolioList", "Portafolio", new { Area = ("Admin") });
            }
            validation.AddToModelState(this.ModelState);
            return View();
        }

        public async Task<IActionResult> DeletePortafolio(int id)
        {
            await _portafolioService.DeleteAsync(id);
            return RedirectToAction("GetPortafolioList", "Portafolio", new { Area = ("Admin") });
        }
    }
}
