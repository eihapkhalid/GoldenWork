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
        SignInManager<ApplicationUser> _signInManager;
        public UsersController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
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
            var RegisterResult = await _userManager.CreateAsync(user, model.Password);
            try
            {
                if (RegisterResult.Succeeded)
                {
                  var LoginResult= await  _signInManager.PasswordSignInAsync(user, model.Password,true,true);
                    if (LoginResult.Succeeded)
                    {
                        Redirect("/contract/list");//any page
                    }
                    else
                    {

                    }
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
