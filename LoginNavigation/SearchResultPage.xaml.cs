using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using System.Text;
using Xamarin.Forms;



namespace LoginNavigation
{
	public partial class SearchResultPage : ContentPage
	{
		List<SchoolFind> searchResultData;
		public SearchResultPage()
		{
			InitializeComponent();
		}
		public SearchResultPage(List<SchoolFind> resultData)
		{
			InitializeComponent();
			searchResultData = resultData;
			getData(resultData);
		}
		public void getData(List<SchoolFind> resultData) {
			degrelist.ItemsSource = resultData;
		}

		async void OnFirstClick(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new 	DetailsPage());
		}

		public void OnMenuButtonClicked(object sender, EventArgs args)
		{
			if (hide.IsVisible == false)
			{
				hide.IsVisible = true;
			}
			else
			{
				hide.IsVisible = false;
			}
		}

		async void OnProfileButtonClicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new ProfilePage());
		}

		async void OnFriendsButtonClicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new FriendsPage());
		}

		async void OnLogoutButtonClicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new FirstPage());
		}
		async void OnListNameClicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new DetailsPage());
		}

	}
}
	