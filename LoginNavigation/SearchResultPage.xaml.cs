using System;
using System.Collections.Generic;

using System.Text;
using Xamarin.Forms;



namespace LoginNavigation
{
	public partial class SearchResultPage : ContentPage
	{

		public SearchResultPage()
		{
			InitializeComponent();

		}
		async void OnFirstClick(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new DetailPage());
		}

	}
}
	