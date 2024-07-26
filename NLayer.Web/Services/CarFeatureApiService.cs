using Microsoft.EntityFrameworkCore;
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

            
            if (filter.MinKm != null)
            {
                int minKm = int.Parse(filter.MinKm);
                query = query.Where(x => int.Parse(x.Km) >= minKm);
            }

            if (filter.MaxKm != null)
            {
                int maxKm = int.Parse(filter.MaxKm);
                query = query.Where(x => int.Parse(x.Km) <= maxKm);
            }

            if (filter.Location != null)
            {
                query = query.Where(x => x.Car.Location.Equals(filter.Location, StringComparison.OrdinalIgnoreCase) || x.Car.State.Equals(filter.Location, StringComparison.OrdinalIgnoreCase));
            }

            if (filter.Color != null && filter.Color.Any())
            {
                query = query.Where(x => filter.Color.Contains(x.Color));
            }

            if (filter.BrandOrModel != null)
            {
                query = query.Where(x=> x.Car.Brand == filter.BrandOrModel || x.Car.Model == filter.BrandOrModel);
            }

            var filteredData = query.ToList();

            return filteredData;
        }

        public async Task<IDictionary<string, int>> GetCarCountsByBrand()
        {
            var cars = await _httpClient.GetFromJsonAsync<CustomResponseDto<List<CarFeatureWithCarDto>>>("CarFeature/GetCarFeatureWithCar");
            return cars.Data.GroupBy(x => x.Car.Brand).ToDictionary(d => d.Key, d => d.Count());
        }

        public async Task<IDictionary<string,int>> GetCarCountsByBodyType()
        {
            var cars = await _httpClient.GetFromJsonAsync<CustomResponseDto<List<CarFeatureWithCarDto>>>("CarFeature/GetCarFeatureWithCar");
            return cars.Data.GroupBy(x => x.BodyType).ToDictionary(d => d.Key, d => d.Count());
        }

        public async Task<IDictionary<string, int>> GetCarCountsByFuelType()
        {
            var cars = await _httpClient.GetFromJsonAsync<CustomResponseDto<List<CarFeatureWithCarDto>>>("CarFeature/GetCarFeatureWithCar");
            return cars.Data.GroupBy(x => x.FuelType).ToDictionary(d => d.Key, d => d.Count());
        }

        public async Task<IDictionary<string, int>> GetCarCountsByGearType()
        {
            var cars = await _httpClient.GetFromJsonAsync<CustomResponseDto<List<CarFeatureWithCarDto>>>("CarFeature/GetCarFeatureWithCar");
            return cars.Data.GroupBy(x => x.GearType).ToDictionary(d => d.Key, d => d.Count());
        }

        public async Task<IDictionary<string, int>> GetCarCountsByColorType()
        {
            var cars = await _httpClient.GetFromJsonAsync<CustomResponseDto<List<CarFeatureWithCarDto>>>("CarFeature/GetCarFeatureWithCar");
            return cars.Data.GroupBy(x => x.Color).ToDictionary(d => d.Key, d => d.Count());
        }

    }
}
