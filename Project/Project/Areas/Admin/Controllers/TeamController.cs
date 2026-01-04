using EntityLayer.WebApp.ViewModels.Team;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.Services.WebApp.Abstract;

namespace Project.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TeamController : Controller
    {
        private readonly ITeamService _teamService;
        private readonly IValidator<TeamAddVM> _addValidator;
        private readonly IValidator<TeamUpdateVM> _updateValidator;

        public TeamController(ITeamService teamService, IValidator<TeamAddVM> addValidator, IValidator<TeamUpdateVM> updateValidator)
        {
            _teamService = teamService;
            _addValidator = addValidator;
            _updateValidator = updateValidator;
        }

        public async Task<IActionResult> GetTeamList()
        {
            var team = await _teamService.GetAllListAsync();
            return View(team);
        }

        [HttpGet]
        public IActionResult AddTeam()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddTeam(TeamAddVM request)
        {
            var validation = await _addValidator.ValidateAsync(request);
            if (validation.IsValid)
            {
                await _teamService.AddAsync(request);
                return RedirectToAction("GetTeamList", "Team", new { Area = ("Admin") });
            }
            validation.AddToModelState(this.ModelState);
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> UpdateTeam(int id)
        {
            var team = await _teamService.GetByIdAsync(id);
            return View(team);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateTeam(TeamUpdateVM request)
        {
            var validation = await _updateValidator.ValidateAsync(request);
            if (validation.IsValid)
            {
                await _teamService.UpDateAsync(request);
                return RedirectToAction("GetTeamList", "Team", new { Area = ("Admin") });
            }
            validation.AddToModelState(this.ModelState);
            return View();
        }

        public async Task<IActionResult> DeleteTeam(int id)
        {
            await _teamService.DeleteAsync(id);
            return RedirectToAction("GetTeamList", "Team", new { Area = ("Admin") });
        }

    }
}
