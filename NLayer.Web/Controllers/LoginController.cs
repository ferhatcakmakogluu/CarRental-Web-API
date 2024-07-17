using Microsoft.AspNetCore.Mvc;
using NLayer.Core.DTOs;

namespace NLayer.Web.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(UserDto user)
        {
            return RedirectToAction("Index", "Home");
        }
    }
}
