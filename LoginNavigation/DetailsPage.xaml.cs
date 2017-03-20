using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LoginNavigation
{
	public partial class DetailsPage : ContentPage
	{
		SearchManager search;
		public DetailsPage()
		{
			InitializeComponent();
			search = SearchManager.DefaultManager;
			getschool();
		}

		private async Task getschool()
		{
			universityname.BindingContext = await search.GetSearchItemsAsync();

		}

		async void OnFirstClick(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new MainPage());
		}

		void OnCostTapped(object sender, EventArgs args)
		{
			if (OnCostSelect.IsVisible == false)
			{
				OnCostSelect.IsVisible = true;
			}
			else
			{
				OnCostSelect.IsVisible = false;
			}

		}


		void OnAidTapped(object sender, EventArgs args)
		{
			if (OnAidSelect.IsVisible == false)
			{
				OnAidSelect.IsVisible = true;
			}
			else
			{
				OnAidSelect.IsVisible = false;
			}

		}

		void OnEarningTapped(object sender, EventArgs args)
		{
			if (OnEarningSelect.IsVisible == false)
			{
				OnEarningSelect.IsVisible = true;
			}
			else
			{
				OnEarningSelect.IsVisible = false;
			}

		}

		void OnGradTapped(object sender, EventArgs args)
		{
			if (OnGradSelect.IsVisible == false)
			{
				OnGradSelect.IsVisible = true;
			}
			else
			{
				OnGradSelect.IsVisible = false;
			}

		}

	}
}
