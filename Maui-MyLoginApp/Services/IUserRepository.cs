using System;
using Maui_MyLoginApp.Models;

namespace Maui_MyLoginApp.Services
{
	public interface IUserRepository
	{
        Task<List<User>> GetAllUser();
        Task<User> AddUser(string firstname, string lastname, int age);
    }
}

