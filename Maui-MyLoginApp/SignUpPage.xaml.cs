namespace Maui_MyLoginApp;

public partial class SignUpPage : ContentPage
{
	public SignUpPage()
	{
		InitializeComponent();
	}

    async void TapGestureRecognizer_Tapped_GoToSignInPage(System.Object sender, System.EventArgs e)
    {
        await Shell.Current.GoToAsync("//SignIn");
    }
}
