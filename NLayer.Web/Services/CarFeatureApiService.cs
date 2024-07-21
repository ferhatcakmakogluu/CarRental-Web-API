using NLayer.Core.DTOs;
using NLayer.Web.Models;

namespace NLayer.Web.Services
{
    public class CarFeatureApiService
    {
        private readonly HttpClient _httpClient;

        public CarFeatureApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<CarFeatureWithCarDto>> GetCarFeatureWithCarsAsync()
        {
            var response = await _httpClient.GetFromJsonAsync<CustomResponseDto<List<CarFeatureWithCarDto>>>("CarFeature/GetCarFeatureWithCar");
            return response.Data;
        }

        public async Task<List<CarFeatureWithCarDto>> GetFilteredCarFeatureWithCar(CarFilterModel filter)
        {
            var allCars = await _httpClient.GetFromJsonAsync<CustomResponseDto<List<CarFeatureWithCarDto>>>("CarFeature/GetCarFeatureWithCar");


            var query = allCars.Data.AsQueryable();

            if (filter.Brand != null && filter.Brand.Any())
            {
                query = query.Where(x => filter.Brand.Contains(x.Car.Brand));
            }

            if (filter.BodyType != null && filter.BodyType.Any())
            {
                query = query.Where(x => filter.BodyType.Contains(x.BodyType));
            }

            if (filter.FuelType != null && filter.FuelType.Any())
            {
                query = query.Where(x => filter.FuelType.Contains(x.FuelType));
            }

            if (filter.GearType != null && filter.GearType.Any())
            {
                query = query.Where(x => filter.GearType.Contains(x.GearType));
            }

            if (filter.Location != null)
            {
                query = query.Where(x => x.Car.Location.Equals(filter.Location, StringComparison.OrdinalIgnoreCase) || x.Car.State.Equals(filter.Location, StringComparison.OrdinalIgnoreCase));
            }

            if (filter.Color != null && filter.Color.Any())
            {
                query = query.Where(x => filter.Color.Contains(x.Color));
            }

            var filteredData = query.ToList();

            /*
            int minKm = filter.Km.Count > 0 ? Int32.Parse(filter.Km[0]) : 0;
            int maxKm = filter.Km.Count > 1 ? Int32.Parse(filter.Km[1]) : int.MaxValue;

            var filteredData = allCars.Data
                .Where(x => filter.Brand != null && filter.Brand.Contains(x.Car.Brand))
                .Where(x => filter.BodyType != null && filter.BodyType.Contains(x.BodyType))
                .Where(x => filter.FuelType != null && filter.FuelType.Contains(x.FuelType))
                .Where(x => filter.GearType != null && filter.GearType.Contains(x.GearType))
                .Where(x => filter.Location != null && (x.Car.Location.Equals(filter.Location, StringComparison.OrdinalIgnoreCase) || x.Car.State.Equals(filter.Location, StringComparison.OrdinalIgnoreCase)))
                .Where(x => filter.Color != null && filter.Color.Contains(x.Color))
                .ToList();
            */


            /*var filteredData = allCars.Data
                .Where(x => filter.BodyType.Contains(x.BodyType))
                .Where(x => filter.GearType.Contains(x.GearType))
                .ToList();*/
            return filteredData;
        }
    }
}
