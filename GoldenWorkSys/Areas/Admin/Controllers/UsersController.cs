using Microsoft.AspNetCore.Mvc;

namespace GoldenWorkSys.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UsersController : Controller
    {

        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
    }
}
