using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Rova.Shared.Models;

namespace Rova.Mobile.Services
{
    public class AuthService
    {
        private readonly HttpClient _httpClient;

        public AuthService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<UserDto> LoginAsync(string username, string password)
        {
            var loginModel = new { Username = username, Password = password };
            var response = await _httpClient.PostAsJsonAsync("api/auth/login", loginModel);

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<UserDto>();
            }

            throw new Exception("Login failed. Please check your credentials.");
        }

        public async Task LogoutAsync()
        {
            var response = await _httpClient.PostAsync("api/auth/logout", null);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Logout failed.");
            }
        }

        public async Task<bool> IsUserAuthenticatedAsync()
        {
            var response = await _httpClient.GetAsync("api/auth/isAuthenticated");
            return response.IsSuccessStatusCode && await response.Content.ReadAsStringAsync() == "true";
        }
    }
}