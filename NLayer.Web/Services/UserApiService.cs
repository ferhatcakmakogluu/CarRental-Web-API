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
            return response.Data;
        }

        public async Task<UserDto> SaveUser(UserDto userDto)
        {
            var response = await _httpClient.PostAsJsonAsync("User", userDto);
            if (!response.IsSuccessStatusCode)
            {
                return null;
            }

            var responseBody = await response.Content.ReadFromJsonAsync<CustomResponseDto<UserDto>>();
            return responseBody.Data;
        }

    }
}
