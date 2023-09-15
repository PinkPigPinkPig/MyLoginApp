namespace Maui_MyLoginApp;

public partial class SignInPage : ContentPage
{
	public SignInPage()
	{
		InitializeComponent();
	}

    async void TapGestureRecognizer_Tapped_GoToSignUpPage(System.Object sender, System.EventArgs e)
    {
        await Shell.Current.GoToAsync("//SignUp");
    }
}
