using System;
using System.Threading.Tasks;
using System.Linq;
using Xamarin.Forms;

namespace LoginNavigation
{
	public partial class SignUpPage : ContentPage
	{
		loginManager manager;
		public SignUpPage()
		{
			InitializeComponent();

			manager = loginManager.DefaultManager;

		}

	public async void OnSignUpButtonClicked(object sender, EventArgs e)
		{
			var todo = new login { 
			userName = usernameEntry.Text,
			Password = passwordEntry.Text,
				SecurityQuestion = securityQuestion.Text,
				Answer = securityAnswer.Text};
			await AddItem(todo);

		}

		async Task AddItem(login item)

		{
			Boolean result = await manager.SaveTaskAsync(item);
			if (result == true)
			{
				messageLabel.Text = "SignUp Successful";
				await Navigation.PushAsync(new LoginPage());
				usernameEntry.Text = "";
				passwordEntry.Text = "";
				securityQuestion.Text = "";
				securityAnswer.Text = "";
			}
			else { 
				messageLabel.Text = "Username already exists. Please try different username!";
				usernameEntry.Text = "";
			}


			//loginManager.ItemsSource = await manager.GetTodoItemsAsync();
		}
			


	}
		
}