using Microsoft.AspNetCore.Mvc;
using NLayer.Web.Models;
using NLayer.Web.Services;
using System.Diagnostics;

namespace NLayer.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly CarFeatureApiService _carFeatureApiService;

        public HomeController(ILogger<HomeController> logger, CarFeatureApiService carFeatureApiService)
        {
            _logger = logger;
            _carFeatureApiService = carFeatureApiService;
        }

        public async Task<IActionResult> Index()
        {
            var carFeatureWithCarsData = await _carFeatureApiService.GetCarFeatureWithCarsAsync();
            return View(carFeatureWithCarsData);
        }


        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Filter(CarFilterModel filter)
        {
            var filteredData = await _carFeatureApiService.GetFilteredCarFeatureWithCar(filter);
            return View(filteredData);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error(ErrorViewModel errorViewModel)
        {
            return View(errorViewModel);
        }
    }
}
