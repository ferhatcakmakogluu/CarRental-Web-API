using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using NLayer.Core.DTOs;
using NLayer.Core.Entities;
using NLayer.Core.Enums.EntityTypes;
using NLayer.Repository;
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
        private readonly AppDbContext _appDbContext;
        private readonly IMapper _mapper;

        public LoginController(UserApiService userApiService, AccountApiService accountApiService, IMapper mapper = null, AppDbContext appDbContext = null)
        {
            _userApiService = userApiService;
            _accountApiService = accountApiService;
            _mapper = mapper;
            _appDbContext = appDbContext;
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

        public IActionResult Logout()
        {
            Response.Cookies.Delete("userId");
            Response.Cookies.Delete("userNameSurname");
            return RedirectToAction("Index", "Home");
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


        public async Task<IActionResult> Profile()
        {
            var id = Request.Cookies["userId"];
            var user = await _userApiService.GetUserByIdAsync(id);
            var userUpdateDto = _mapper.Map<UserUpdateDto>(user);
            return View(userUpdateDto);
        }

        [HttpPost]
        public async Task<IActionResult> Profile(UserUpdateDto userUpdate)
        {
            var userDto = await _appDbContext.Users
                             .AsNoTracking()
                             .FirstOrDefaultAsync(u => u.Id == userUpdate.Id);

            var user = _mapper.Map<UserUpdateDto>(userDto);
            if (ModelState.IsValid)
            {
                user.Name = !string.IsNullOrEmpty(userUpdate.Name) ? userUpdate.Name : user.Name;
                user.LastName = !string.IsNullOrEmpty(userUpdate.LastName) ? userUpdate.LastName : user.LastName;
                user.PhoneNumber = !string.IsNullOrEmpty(userUpdate.PhoneNumber) ? userUpdate.PhoneNumber : user.PhoneNumber;
                user.Password = !string.IsNullOrEmpty(userUpdate.Password) ? userUpdate.Password : user.Password;
                user.Email = !string.IsNullOrEmpty(userUpdate.Email) ? userUpdate.Email : user.Email;
                user.PasswordAgain = string.IsNullOrEmpty(userUpdate.PasswordAgain) ? user.Password : userUpdate.PasswordAgain;
                user.CurrentPassword = string.IsNullOrEmpty(userUpdate.CurrentPassword) ? user.Password : userUpdate.CurrentPassword;

                var userSave = await _userApiService.UpdateUser(user);
                return View(userSave);
            }

            user.PasswordAgain = string.IsNullOrEmpty(userUpdate.PasswordAgain) ? user.Password : userUpdate.PasswordAgain;
            user.CurrentPassword = string.IsNullOrEmpty(userUpdate.CurrentPassword) ? user.Password : userUpdate.CurrentPassword;

            var responseModel = _mapper.Map<UserUpdateDto>(user);
            return View(responseModel);
        }
    }
}
