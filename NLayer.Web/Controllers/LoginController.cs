using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using NLayer.Core.DTOs;
using NLayer.Core.Entities;
using NLayer.Core.Enums.EntityTypes;
using NLayer.Web.Services;
using System.Net.Http;
using System.Text.Json;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace NLayer.Web.Controllers
{
    public class LoginController : Controller
    {
        private readonly UserApiService _userApiService;
        private readonly AccountApiService _accountApiService;

        public LoginController(UserApiService userApiService, AccountApiService accountApiService)
        {
            _userApiService = userApiService;
            _accountApiService = accountApiService;
        }

        public async Task<IActionResult> Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(AccountDto accountDto)
        {
            //eger kullanıcı varsa AccountApiServer de session olusturur
            var response = await _accountApiService.LoginUser(accountDto.Email,accountDto.Password);
            if (response != null)
            {
                var cookieOptions = new CookieOptions
                {
                    // Tarayıcı tarafından okunabilir
                    HttpOnly = true
                };
                string userId = response.UserId.ToString();
                Response.Cookies.Append("userId", userId, cookieOptions);

                var userInfo = await _userApiService.GetUserByIdAsync(userId);

                var userNameSurname = $"{userInfo.Name} {userInfo.LastName}";
                Response.Cookies.Append("userNameSurname", userNameSurname, cookieOptions);

                ViewBag.CookieUserId = response.UserId;
                ViewBag.LoginErrorMessage = "";
                //HttpContext.Session.SetInt32("UserId", response.UserId);

                return RedirectToAction("Index","Home");
            }
            ViewBag.LoginErrorMessage = "Kullanıcı adı veya şifre hatalı!";
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
                var response = await _userApiService.SaveUser(userDto);
                
                AccountDto accountDto = new AccountDto();
                accountDto.Email = userDto.Email;
                accountDto.Password = userDto.Password;
                accountDto.AccountType = AccountEnum.AccountTypeEnum.USER.ToString();

                await _accountApiService.SaveAccount(accountDto);

                return RedirectToAction("Index", "Login");
            }
            return View();
        }
    }
}
