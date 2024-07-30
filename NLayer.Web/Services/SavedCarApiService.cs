using NLayer.Core.DTOs;
using NLayer.Core.Entities;

namespace NLayer.Web.Services
{
    public class SavedCarApiService
    {
        private readonly HttpClient _httpClient;

        public SavedCarApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<SavedCar>> GetAllSavedCars()
        {
            var savedCars = await _httpClient.GetFromJsonAsync<CustomResponseDto<List<SavedCar>>>("SavedCar");
            return savedCars.Data;
        }

        public async Task<List<SavedCar>> GetSavedCarOfUser(string accountId)
        {
            var savedCar = await _httpClient.GetFromJsonAsync<CustomResponseDto<List<SavedCar>>>("SavedCar/GetSavedCarWithAccountId/"+accountId);
            return savedCar.Data;
        }

        public async Task<List<SavedCar>> GetSavedCarOfUserByUserId(string userId)
        {
            var account = await _httpClient.GetFromJsonAsync < CustomResponseDto<AccountDto>>("Account/GetAccountByUserId/"+userId);
            var savedCar = await _httpClient.GetFromJsonAsync<CustomResponseDto<List<SavedCar>>>("SavedCar/GetSavedCarWithAccountId/" + account.Data.Id.ToString());
            return savedCar.Data;
        }

        public async Task<SavedCar> AddSavedCar(SavedCar savedCar)
        {
            var response = await _httpClient.PostAsJsonAsync("SavedCar", savedCar);
            if (!response.IsSuccessStatusCode)
            {
                return null;
            }
            var responseBody = await response.Content.ReadFromJsonAsync<CustomResponseDto<SavedCar>>();
            return responseBody.Data;
        }

        public async Task<bool> RemoveSavedCar(int id)
        {
            var response = await _httpClient.DeleteAsync($"SavedCar/{id}");
            return response.IsSuccessStatusCode;
        }
    }
}
