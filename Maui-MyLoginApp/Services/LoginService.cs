using System;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text.Json.Serialization;
using Maui_MyLoginApp.Models;
using Newtonsoft.Json;

namespace Maui_MyLoginApp.Services
{
    public class LoginService : ILoginRepository
    {
        public async Task<User> Login(string username, string password)
        {
            var user = new User();
            var client = new HttpClient();

            string url = "https://dummyjson.com/auth/login";

            var data = new Dictionary<string, string>
            {
                {"username", username },
                {"password", password },
            };
            var content = new FormUrlEncodedContent(data);

            var response = await client.PostAsync(url, content);

            if(response.IsSuccessStatusCode)
            {
                string responseContent = response.Content.ReadAsStringAsync().Result;
                user = JsonConvert.DeserializeObject<User>(responseContent);
                return await Task.FromResult(user);
            }
            else
            {
                return null;
            }
        }
    }
}

