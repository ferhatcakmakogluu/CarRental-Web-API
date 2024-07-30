using Microsoft.AspNetCore.Mvc;
using NLayer.Core.Entities;
using NLayer.Web.Services;

namespace NLayer.Web.Controllers
{
    public class SavedCarController : Controller
    {
        private readonly SavedCarApiService _savedCarService;
        private readonly AccountApiService _accountApiService;

        public SavedCarController(SavedCarApiService savedCarService, AccountApiService accountApiService = null)
        {
            _savedCarService = savedCarService;
            _accountApiService = accountApiService;
        }

        public async Task<IActionResult> Index()
        {
            var userId = Request.Cookies["userId"];
            var accountOfUser = await _accountApiService.GetAccountByUserId(userId);
            var savedCarOfUser = await _savedCarService.GetSavedCarOfUser(accountOfUser.Id.ToString());
            return View(savedCarOfUser);
        }

        [HttpPost]
        public async Task<IActionResult> SavedCarToUserProfile(int carId)
        {
            SavedCar savedCar = new SavedCar();

            var userId = Request.Cookies["userId"];
            var usersAccountId = await _accountApiService.GetAccountByUserId(userId);

            savedCar.AccountId = usersAccountId.Id;
            savedCar.CarId = carId;
            savedCar.SavedTime = DateTime.Now;

            await _savedCarService.AddSavedCar(savedCar);

            var accountOfUser = await _accountApiService.GetAccountByUserId(userId);
            var savedCarOfUser = await _savedCarService.GetSavedCarOfUser(accountOfUser.Id.ToString());
            return RedirectToActionPermanent("Index", "SavedCar", savedCarOfUser);
        }

        [HttpPost]
        public async Task<IActionResult> RemoveSavedCarToUserProfile(int carId)
        {
            var userId = Request.Cookies["userId"];
            var savedCars = await _savedCarService.GetSavedCarOfUserByUserId(userId);
            var willRemoveCar = savedCars.Where(x=> x.CarId == carId).FirstOrDefault();
            await _savedCarService.RemoveSavedCar(willRemoveCar.Id);


            var accountOfUser = await _accountApiService.GetAccountByUserId(userId);
            var savedCarOfUser = await _savedCarService.GetSavedCarOfUser(accountOfUser.Id.ToString());
            return RedirectToActionPermanent("Index", "SavedCar", savedCarOfUser);
        }
    }
}
