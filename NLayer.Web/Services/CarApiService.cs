using NLayer.Core.DTOs;

namespace NLayer.Web.Services
{
    public class CarApiService
    {
        private readonly HttpClient _httpClient;

        public CarApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<CarDto>> GetCars()
        {
            var response = await _httpClient.GetFromJsonAsync<CustomResponseDto<List<CarDto>>>("Car");
            return response.Data;
        }
    }
}
