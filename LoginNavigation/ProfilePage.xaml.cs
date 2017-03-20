using System;
using System.Threading.Tasks;
using System.Linq;
using Xamarin.Forms;


namespace LoginNavigation
{
	public partial class ProfilePage : ContentPage
	{
		String name;
		ProfileManager manager;
		public ProfilePage()
		{
			InitializeComponent();
			manager = ProfileManager.DefaultManager;
			submit.IsEnabled = false;
		}

		public ProfilePage(String username)
		{
			InitializeComponent();
			name = username;
			nameEntry.Text = name;
			manager = ProfileManager.DefaultManager;
		}

		public async void OnSubmitButtonClicked(object sender, EventArgs e)
		{
			var user = new profile { 
				Name = nameEntry.Text,
				Marks = Convert.ToInt32(GreSatMarks.Text),
				Program = Program_Degree.Text,
				EmailId = ContactDetails.Text
			};
			await AddProfile(user);
		}

		async Task AddProfile(profile item) {
			Boolean result = await manager.SaveTaskAsync(item);
			if (result == true)
			{
				messageLabel.Text = "Profile created successfully!";
			}
			else {
				messageLabel.Text = "Name and Email id already exist in database.";
			}
		}
	}
}
