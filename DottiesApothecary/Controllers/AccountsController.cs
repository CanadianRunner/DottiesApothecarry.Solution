using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using DottiesApothecary.Models;
using System.Threading.Tasks;
using DottiesApothecary.ViewModels;

namespace DottiesApothecary.Controllers
{
  public class AccountController : Controller
  {
    private readonly DottiesApothecaryContext _db;
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly SignInManager<ApplicationUser> _signInManager;

    public AccountController
  }
}