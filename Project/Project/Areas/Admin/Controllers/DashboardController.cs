using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Project.Areas.Admin.Controllers
{
      public class DashboardController : Controller
    {
        [Authorize]
        [Area("Admin")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
