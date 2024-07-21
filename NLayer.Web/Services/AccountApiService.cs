using NLayer.Core.DTOs;

namespace NLayer.Web.Services
{
    public class AccountApiService
    {
        private readonly HttpClient _httpClient;

        public AccountApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<AccountDto> LoginUser(string email, string password)
        {
            var response = await _httpClient.GetFromJsonAsync<CustomResponseDto<List<AccountDto>>>("Account");
            var res = response.Data.Where(x=>x.Email == email && x.Password == password).FirstOrDefault();
            return res;
        }

        public async Task<AccountDto> SaveAccount(AccountDto accountDto)
        {
            int userId = await GetUserId(accountDto);
            accountDto.UserId = userId;

            var response = await _httpClient.PostAsJsonAsync("Account",accountDto);
            if (!response.IsSuccessStatusCode)
            {
                return null;
            }
            var responseBody = await response.Content.ReadFromJsonAsync<CustomResponseDto<AccountDto>>();
            return responseBody.Data;
        }

        public async Task<int> GetUserId(AccountDto accountDto)
        {
            UserApiService userApiService = new UserApiService(_httpClient);
            var users = await userApiService.GetAllUserAsync();
            UserDto user = users.Where(x=>x.Email == accountDto.Email && x.Password == accountDto.Password).FirstOrDefault();
            return user.Id;
        }
    }
}
