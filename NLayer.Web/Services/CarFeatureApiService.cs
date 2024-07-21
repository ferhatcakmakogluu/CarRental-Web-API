using NLayer.Core.DTOs;

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
    }
}
