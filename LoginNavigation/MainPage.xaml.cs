using System;
using Xamarin.Forms;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Text;

namespace LoginNavigation
{
	public partial class MainPage : ContentPage
	{
		string usernmae;
		SearchManager search;
		TitleManager tiltem;
		public MainPage()
		{
			InitializeComponent();
			search = SearchManager.DefaultManager;
			tiltem = TitleManager.DefaultManager;
			getsearch();
		}

		public MainPage(String name) { 
			InitializeComponent();
			usernmae = name;
			search = SearchManager.DefaultManager;
			tiltem = TitleManager.DefaultManager;
			getsearch();
		}

		private async Task getsearch()
		{
			programlist.ItemsSource = await tiltem.GetTitleItemsAsync();
			degreelist.ItemsSource = await tiltem.GetTitleItemsAsync();
			sizelist.ItemsSource = await tiltem.GetTitleItemsAsync();
			statelist.ItemsSource = await search.GetSearchItemsAsync();
			namelist.ItemsSource = await search.GetSearchItemsAsync();
			regionlist.ItemsSource = await tiltem.GetTitleItemsAsync();
			typeoforganisationlist.ItemsSource = await tiltem.GetTitleItemsAsync();

		}

		 void OnMenuButtonClicked(object sender, EventArgs args) {
			
			if (hide.IsVisible == false)
			{
				hide.IsVisible = true;
			}
			else {
				hide.IsVisible = false;
			}
		}

		void OnProgramDegreeTapped(object sender, EventArgs args)
		{
			if (ProgramDegreeClicked.IsVisible == false)
			{
				ProgramDegreeClicked.IsVisible = true;
			}
			else
			{
				ProgramDegreeClicked.IsVisible = false;
			}
		}
		void OnProgramTapped(object sender, EventArgs args)
		{
			if (Programframe.IsVisible == false)
			{
				Programframe.IsVisible = true;
			}
			else
			{
				Programframe.IsVisible = false;
			}

		}
		void OnDegreeTapped(object sender, EventArgs args)
		{

			if (Degreeframe.IsVisible == false)
			{
				Degreeframe.IsVisible = true;
			}
			else
			{
				Degreeframe.IsVisible = false;
			}

		}
		void OnLocationTapped(object sender, EventArgs args)
		{
			if (OnlocationSelect.IsVisible == false)
			{
				OnlocationSelect.IsVisible = true;
			}
			else
			{
				OnlocationSelect.IsVisible = false;
			}
		}
		void OnStateTapped(object sender, EventArgs args)
		{

			if (SelectStateFrame.IsVisible == false)
			{
				SelectStateFrame.IsVisible = true;
			}
			else
			{
				SelectStateFrame.IsVisible = false;
			}


		}
		void OnRegionTapped(object sender, EventArgs args)
		{
			if (SelectRegionFrame.IsVisible == false)
			{
				SelectRegionFrame.IsVisible = true;
			}
			else
			{
				SelectRegionFrame.IsVisible = false;
			}

		}
		void OnSizeTapped(object sender, EventArgs args)
		{
			if (OnSizeSelect.IsVisible == false)
			{
				OnSizeSelect.IsVisible = true;
			}
			else
			{
				OnSizeSelect.IsVisible = false;
			}
		}
		void OnStudentBodyTapped(object sender, EventArgs args)
		{
			if (SelectStudentBodyFrame.IsVisible == false)
			{
				SelectStudentBodyFrame.IsVisible = true;
			}
			else
			{
				SelectStudentBodyFrame.IsVisible = false;
			}

		}
		void OnNameTapped(object sender, EventArgs args)
		{
			if (OnNameSelect.IsVisible == false)
			{
				OnNameSelect.IsVisible = true;
			}
			else
			{
				OnNameSelect.IsVisible = false;
			}

		}
		void OnASTapped(object sender, EventArgs args)
		{
			if (OnAdvancedSearchSelect.IsVisible == false)
			{
				OnAdvancedSearchSelect.IsVisible = true;
			}
			else
			{
				OnAdvancedSearchSelect.IsVisible = false;
			}
		}
		void OnASBodyTapped(object sender, EventArgs args)
		{
			if (SelectASBodyFrame.IsVisible == false)
			{
				SelectASBodyFrame.IsVisible = true;
			}
			else
			{
				SelectASBodyFrame.IsVisible = false;
			}
		}

		async void OnProfileButtonClicked(object sender, EventArgs e)
		{
			if (usernmae != null)
			{
				await Navigation.PushAsync(new ProfilePage(usernmae));
			}
			else { 
				await Navigation.PushAsync(new ProfilePage());
			}
		}

		async void OnFriendsButtonClicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new FriendsPage(usernmae));
		}

		async void OnLogoutButtonClicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new FirstPage());
		}



		void OnProgram(object sender, EventArgs args)
		{
			var programtext = ((Label)sender);
			programlabel.Text = programtext.Text;
		}
		void OnDegree(object sender, EventArgs args)
		{
			var degreetext = ((Label)sender);
			degreelabel.Text = degreetext.Text;
		}
		void OnRegion(object sender, EventArgs args)
		{
			var regiontext = ((Label)sender);
			rlabel.Text = regiontext.Text;
		}
		void OnState(object sender, EventArgs args)
		{
			var statetext = ((Label)sender);
			statelabel.Text = statetext.Text;
		}
		void OnName(object sender, EventArgs args)
		{
			var nametext = ((Label)sender);
			namelabel.Text = nametext.Text;
		}
		void OnType(object sender, EventArgs args)
		{
			var typetext = ((Label)sender);
			typelabel.Text = typetext.Text;
		}
		void OnSize(object sender, EventArgs args)
		{
			var sizetext = ((Label)sender);
			sizelabel.Text = sizetext.Text;
		}


		async void OnFindSchool(object sender, EventArgs e)
		{
			var searchBuilder = new SchoolFind { };
			if (programlabel.Text != null)
			{
				List<Title> items = await tiltem.GetProgramNumber(programlabel.Text);
				searchBuilder.Program =  items[0].cid.ToString();
			}
			if (degreelabel.Text != null) {
				
			}
			if (statelabel.Text != null) {
				searchBuilder.State = statelabel.Text;
			}
			if (rlabel.Text != null) { 
				List<Title> items = await tiltem.GetRegionNumber(rlabel.Text);
				searchBuilder.Region = items[0].cid.ToString();
			}
			if (namelabel.Text != null) {
				searchBuilder.Name = namelabel.Text;
			}
			if (typelabel.Text != null) { 
				List<Title> items = await tiltem.GetTypeNumber(typelabel.Text);
				searchBuilder.TypeOfOrganization = items[0].cid.ToString(); 
			}
			if (sizelabel.Text != null) { 
				List<Title> items = await tiltem.GetSizeNumber(sizelabel.Text);
				searchBuilder.Size = items[0].cid.ToString();
			}


			List<SchoolFind> searchResultData = await search.GetSearchData(searchBuilder);
			await Navigation.PushAsync(new SearchResultPage(searchResultData));
		}

	}
}
