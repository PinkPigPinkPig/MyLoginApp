using Maui_MyLoginApp.Models;
using Maui_MyLoginApp.Services;

namespace Maui_MyLoginApp;

public partial class MainPage : ContentPage
{
	int count = 0;
	readonly IUserRepository _userRepository = new UserService();

	public MainPage()
	{
		InitializeComponent();
	}

	private async void OnCounterClicked(object sender, EventArgs e)
	{
        List<User> data = await _userRepository.GetAllUser();
        if (data != null)
        {
            listUsers.ItemsSource = data;
        }
    }

    void signOut_Clicked(System.Object sender, System.EventArgs e)
    {
		Shell.Current.GoToAsync("//SignIn");
    }

    void listUsers_ItemSelected(System.Object sender, Microsoft.Maui.Controls.SelectedItemChangedEventArgs e)
    {
    }
}


