using Microsoft.AspNetCore.Mvc;
using GoldenWorkSys.Models;
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
            return View(new UsersModel());
        }

        [HttpPost]
        public IActionResult Register(UsersModel model)
        {
            return View(new UsersModel());
        }
    }
}
