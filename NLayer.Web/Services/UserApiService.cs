using NLayer.Core.DTOs;

namespace NLayer.Web.Services
{
    public class UserApiService
    {
        private readonly HttpClient _httpClient;

        public UserApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<UserDto>> GetAllUserAsync()
        {
            var response = await _httpClient.GetFromJsonAsync<CustomResponseDto<List<UserDto>>>("User");
            var x = 0;
            return response.Data;
        }
    }
}
