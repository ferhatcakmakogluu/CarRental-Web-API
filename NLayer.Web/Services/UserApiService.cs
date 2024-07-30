using AutoMapper;
using NLayer.Core.DTOs;

namespace NLayer.Web.Services
{
    public class UserApiService
    {
        private readonly HttpClient _httpClient;
        private readonly IMapper _mapper;

        public UserApiService(HttpClient httpClient, IMapper mapper = null)
        {
            _httpClient = httpClient;
            _mapper = mapper;
        }

        public async Task<List<UserDto>> GetAllUserAsync()
        {
            var response = await _httpClient.GetFromJsonAsync<CustomResponseDto<List<UserDto>>>("User");
            return response.Data;
        }

        public async Task<UserDto> GetUserByIdAsync(string id)
        {
            var response = await _httpClient.GetFromJsonAsync<CustomResponseDto<UserDto>>("User/"+id);
            return response.Data;
        }

        public async Task<UserUpdateDto> GetUserUpdateDtoByIdAsync(string id)
        {
            var response = await _httpClient.GetFromJsonAsync<CustomResponseDto<UserUpdateDto>>("User/" + id);
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

        public async Task<UserUpdateDto> UpdateUser(UserUpdateDto userDto)
        {
            var response = await _httpClient.PutAsJsonAsync("User", userDto);
            return userDto;
        }

    }
}
