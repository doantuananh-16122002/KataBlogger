using KataBlogger.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace KataBlogger.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("Login")]
        public IActionResult Login()
        {
            return View(new LoginVM());
        }
    }
}