using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace LoginNavigation
{
	
	public partial class FirstPage : ContentPage
	{
		public FirstPage()
		{
			InitializeComponent();
		}
		async void OnSignUpButtonClicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new SignUpPage());
		}
		async void OnLoginButtonClickedFirstPage(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new LoginPage());
		}
		async void OnGuestButtonClicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new MainPage());
		}

	}
}
