using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
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
            CarFilterModel filterModel = new CarFilterModel();
            var carFeatureWithCarsData = await _carFeatureApiService.GetCarFeatureWithCarsAsync();
            filterModel.CarFeatureWithCars = carFeatureWithCarsData;
            
            //for filter attributes
            filterModel.CarBrandCounts = await _carFeatureApiService.GetCarCountsByBrand();
            filterModel.CarBodyTypeCounts = await _carFeatureApiService.GetCarCountsByBodyType();
            filterModel.CarGearTypeCounts = await _carFeatureApiService.GetCarCountsByGearType();
            filterModel.CarColorTypeCounts = await _carFeatureApiService.GetCarCountsByColorType();
            filterModel.CarFuelTypeCounts = await _carFeatureApiService.GetCarCountsByFuelType();
            return View(filterModel);
        }

        [HttpPost]
        public async Task<IActionResult> Index(CarFilterModel filter)
        {
            var filteredData = await _carFeatureApiService.GetFilteredCarFeatureWithCar(filter);
            filter.CarFeatureWithCars = filteredData;

            //for filter attributes
            filter.CarBrandCounts = await _carFeatureApiService.GetCarCountsByBrand();
            filter.CarBodyTypeCounts = await _carFeatureApiService.GetCarCountsByBodyType();
            filter.CarGearTypeCounts = await _carFeatureApiService.GetCarCountsByGearType();
            filter.CarColorTypeCounts = await _carFeatureApiService.GetCarCountsByColorType();
            filter.CarFuelTypeCounts = await _carFeatureApiService.GetCarCountsByFuelType();
            return View(filter);
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
