using EntityLayer.WebApp.ViewModels.Team;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.Services.WebApp.Abstract;

namespace Project.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TeamController : Controller
    {
        private ITeamService _teamService;
        public TeamController(ITeamService teamService)
        {
            _teamService = teamService;
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
            await _teamService.AddAsync(request);
            return RedirectToAction("GetTeamList", "Team", new { Area = ("Admin") });
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
            await _teamService.UpDateAsync(request);
            return RedirectToAction("GetTeamList", "Team", new { Area = ("Admin") });
        }

        public async Task<IActionResult> DeleteTeam(int id)
        {
            await _teamService.DeleteAsync(id);
            return RedirectToAction("GetTeamList", "Team", new { Area = ("Admin") });
        }

    }
}
