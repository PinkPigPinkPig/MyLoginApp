using System;
using Microsoft.Toolkit.Mvvm.ComponentModel;

namespace Maui_MyLoginApp.ViewModels
{
	public partial class BaseViewModel : ObservableObject
	{
        [ObservableProperty]
        public bool _isBusy;
        [ObservableProperty]
        public string _title;
    }
}

