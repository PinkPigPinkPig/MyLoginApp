using Maui_MyLoginApp.Models;
using Maui_MyLoginApp.Services;

namespace Maui_MyLoginApp;

public partial class SignInPage : ContentPage
{
    readonly ILoginRepository _loginRepository = new LoginService();
	public SignInPage()
	{
		InitializeComponent();
	}

    async void TapGestureRecognizer_Tapped_GoToSignUpPage(System.Object sender, System.EventArgs e)
    {
        await Shell.Current.GoToAsync("//SignUp");
    }

    async void Button_Clicked_SignIn(System.Object sender, System.EventArgs e)
    {
        string username = inputName.Text;
        string password = inputPassword.Text;
        if(username == null || password == null)
        {
            DisplayAlert("Warning", "Please input username & password", "OK");
            return;
        }
        var data = await _loginRepository.Login(username, password);
        if (data != null)
        {
            DisplayAlert("Success", @"Welcome, {data.Username}", "OK");
            await Shell.Current.GoToAsync("//MainPage");
        }
        else
        {
            DisplayAlert("Warning", "Login Fail", "OK");
        }
    }
}
