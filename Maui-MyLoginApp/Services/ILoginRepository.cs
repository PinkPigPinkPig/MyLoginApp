using System;
using Maui_MyLoginApp.Models;

namespace Maui_MyLoginApp.Services
{
	public interface ILoginRepository
	{
		Task<User> Login(string username, string password);
	}
}

