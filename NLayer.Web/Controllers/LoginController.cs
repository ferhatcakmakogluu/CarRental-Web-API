using Microsoft.AspNetCore.Mvc;
using NLayer.Core.DTOs;
using NLayer.Core.Entities;
using NLayer.Web.Services;
using System.Net.Http;
using System.Text.Json;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace NLayer.Web.Controllers
{
    public class LoginController : Controller
    {
        private readonly UserApiService _userApiService;

        public LoginController(UserApiService userApiService)
        {
            _userApiService = userApiService;
        }

        public async Task<IActionResult> Index()
        {
            var response = await _userApiService.GetAllUserAsync();
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Register(UserDto userDto)
        {
            if (ModelState.IsValid)
            {
                await _userApiService.SaveUser(userDto);
                return RedirectToAction("Index", "Login");
            }
            return View();
        }
    }
}
