using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Text.Json;

namespace Services
{
    public class AuthService
    {
        public string? Token { get; set; }

        public async Task<string> Login(string username, string password)
        {
            using var client = HttpClientFactory.CreateUnsafeClient();
            string apiUrl = ConfigurationManager.AppSettings["ApiUrl"]!;
            try
            {
                string request = apiUrl + "/tokens";
                var authToken = Convert.ToBase64String(Encoding.ASCII.GetBytes($"{username}:{password}"));
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", authToken);
                var response = await client.PostAsync(request, new StringContent(""));
                if (!response.IsSuccessStatusCode)
                {
                    if(response.StatusCode == HttpStatusCode.BadRequest)
                    {
                        throw new Exception("Пользователь не найден");
                    }
                    if (response.StatusCode == HttpStatusCode.Unauthorized)
                    {
                        throw new Exception("Неверный пароль");
                    }
                    if (response.StatusCode == HttpStatusCode.Forbidden)
                    {
                        throw new Exception("Пользователь заблокирован");
                    }
                    throw new Exception("Ошибка авторизации");
                }
                string jsonString = await response.Content.ReadAsStringAsync();
                using JsonDocument doc = JsonDocument.Parse(jsonString);
                JsonElement root = doc.RootElement;
                string token = root.GetProperty("token").GetString()!;
                string role = root.GetProperty("role").GetString()!;
                if(role != "ADMIN")
                {
                    throw new Exception("Данный клиент предназначен для сотрудников");
                }
                Token = token;
                return token;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw ;
            }
        }

        public void Logout()
        {
            Token = null;
        }
    }
}
