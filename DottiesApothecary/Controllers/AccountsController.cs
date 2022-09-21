using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using DottiesApothecary.Models;
using System.Threading.Tasks;
// using DottiesApothecary.ViewModels;

namespace DottiesApothecary.Controllers
{
    public class AccountController : Controller
    {
        private readonly DottiesApothecaryContext _db;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public AccountController (UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, DottiesApothecaryContext db)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _db = db;
        }

        public ActionResult Index()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        // [HttpPost]
        // public async Task<ActionResult> Register (RegisterViewModel model)
        // {
        //     var user = new ApplicationUser { UserName = model.Email };
        //     IdentityResult result = await _userManager.CreateAsync(user, model.Password);
        //     if (result.Succeeded)
        //     {
        //         return RedirectToAction("Index");
        //     }
        //     else
        //     {
        //         return View();
        //     }
        // }
    }
}

