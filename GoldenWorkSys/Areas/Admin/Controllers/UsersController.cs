using Microsoft.AspNetCore.Mvc;
using GoldenWorkSys.Models;
using Microsoft.AspNetCore.Identity;
using Bl;

namespace GoldenWorkSys.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UsersController : Controller
    {
        UserManager<ApplicationUser> _userManager;
        public UsersController(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View(new UsersModel());
        }

        [HttpPost]
        public async Task<IActionResult> Register(UsersModel model)
        {
            if (!ModelState.IsValid) 
            {
                return View("Register",model);
            }
            ApplicationUser user = new ApplicationUser(){
                FirstName= model.FirstName,
                LastName= model.LastName,
                Email= model.Email,
                UserName = model.Email 
            };
            var result = await _userManager.CreateAsync(user, model.Password);
            try
            {
                if (result.Succeeded)
                {

                }
                else
                {

                }
            }
            catch(Exception ex) 
            {

            }
            return View(new UsersModel());
        }
    }
}
