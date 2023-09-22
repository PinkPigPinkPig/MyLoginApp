using System;
using Maui_MyLoginApp.Models;
using Newtonsoft.Json;
using Serilog;

namespace Maui_MyLoginApp.Services
{
    public class UserService : IUserRepository
    {

        public Task<User> AddUser(string firstname, string lastname, int age)
        {

            throw new NotImplementedException();
        }

        public async Task<List<User>> GetAllUser()
        {
            using var log = new LoggerConfiguration()
                    .WriteTo.Console()
                    .CreateLogger();
            var listUser = new List<User>();
            var client = new HttpClient();

            string url = "https://dummyjson.com/users";

            var response = await client.GetAsync(url);
            log.Information(response.ToString());


            if (response.IsSuccessStatusCode)
            {
                string responseContent = response.Content.ReadAsStringAsync().Result;
                ListUserReponse data = JsonConvert.DeserializeObject<ListUserReponse>(responseContent);
                listUser = data.Users;
                return listUser;
            }
            else
            {
                return null;
            }
        }
    }

    public class ListUserReponse
    {
        public List<User> Users { get; set; }
    }
}

