using Microsoft.AspNetCore.Mvc;
using NLayer.Core.DTOs;
using NLayer.Core.Entities;
using NLayer.Web.Services;
using System.Net.Http;
using System.Text.Json;

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
        public IActionResult Register(UserDto user)
        {
            return RedirectToAction("Index", "Home");
        }
    }
}
