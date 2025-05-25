using Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http.Headers;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Reflection.Metadata.Ecma335;
using Services.SupportClasses;

namespace Services
{
    public class UserService
    {
        public string? Token { get; set; }

        public async Task<UserPaginatedList> GetUsers(int page)
        {
            if (Token == null)
            {
                throw new ArgumentNullException("Необходимо получить токен для авторизации");
            }
            using var client = HttpClientFactory.CreateUnsafeClient();
            string apiUrl = ConfigurationManager.AppSettings["ApiUrl"]!;
            try
            {
                string request = apiUrl + "/users";
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Token);
                var response = await client.GetAsync(request);
                if (!response.IsSuccessStatusCode)
                {
                    if (response.StatusCode == HttpStatusCode.Forbidden)
                    {
                        throw new Exception("Недостаточно прав");
                    }
                    throw new Exception("Ошибка доступа к API");
                }
                string jsonString = await response.Content.ReadAsStringAsync();
                return UserPaginatedList.Deserealise(jsonString);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
