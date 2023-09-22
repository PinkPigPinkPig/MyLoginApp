using System;
namespace Maui_MyLoginApp.Models
{
	public class User
	{
		public int Id { get; set; }
		public string Username { get; set; }
		public string Password { get; set; }
		public string Image { get; set; }
		public string Firstname { get; set; }
		public string Lastname { get; set; }
		public int Age { get; set; }

		public string GetFullName()
		{
			if(this.Firstname != null && this.Lastname != null)
			{
                return @"{this.Firstname} {this.Lastname}";
            }
			return "";
		}
    }
}

