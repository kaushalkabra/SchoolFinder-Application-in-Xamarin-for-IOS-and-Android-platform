using System;
using Xamarin.Forms;

namespace LoginNavigation
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
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
		async void OnFindSchool(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new SearchResultPage());
		}



	}
}
