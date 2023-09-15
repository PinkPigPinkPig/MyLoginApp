using System;
using Microsoft.Toolkit.Mvvm.ComponentModel;

namespace Maui_MyLoginApp.ViewModels
{
	public partial class LoginPageViewModel : BaseViewModel
	{
		[ObservableProperty]
		private string _userName;

        [ObservableProperty]
        private string _password;
    }
}

