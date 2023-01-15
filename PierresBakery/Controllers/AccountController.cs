using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using PierresBakery.Models;
using PierresBakery.ViewModels;
using System.Threading.Tasks;

namespace PierresBakery.AddControllersWithViews
{
  public class AccountController : Controller
  {
    private readonly PierresBakeryContext _db;
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly SignInManager<ApplicationUser> _signInManager;

    public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, PierresBakeryContext db)
    {
      _db = db;
      _userManager = userManager;
      _signInManager = signInManager;
    }

    public ActionResult Index()
    {
      return View();
    }

    public IActionResult Register()
    {
      return View();
    }
  }
}