using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace LoginNavigation
{
	public partial class ForgotPasswordPage : ContentPage
	{
		public ForgotPasswordPage()
		{
			InitializeComponent();
		}

		async void OnRecoverPasswordClicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new SearchResultPage());
		}
	}
}
