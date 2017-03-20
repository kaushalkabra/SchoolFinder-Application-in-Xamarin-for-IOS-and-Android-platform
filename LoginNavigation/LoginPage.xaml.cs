using System;
using Xamarin.Forms;
using System.Threading.Tasks;

namespace LoginNavigation
{
	
	public partial class LoginPage : ContentPage
	{
		loginManager manager;
		public LoginPage()
		{
			InitializeComponent();
			manager = loginManager.DefaultManager;
		}

		async void OnSignUpButtonClicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new SignUpPage());
		}

		async void OnLoginButtonClicked(object sender, EventArgs e)
		{
			var user = new login
			{
				userName = usernameEntry.Text,
				Password = passwordEntry.Text
			};
			await checkItem(user);
			//messageLabel.Text = "Successful";
		}

		async Task checkItem(login item)

		{
			Boolean result = await manager.CheckTaskAsync(item);
			if (result == true)
			{
				messageLabel.Text = "Login Successful!";
				await Navigation.PushAsync(new MainPage(usernameEntry.Text));

			}
			else {
				messageLabel.Text = "Username and Password did not match.Please try again!!";
				passwordEntry.Text = "";
			} 
		}

		async void OnForgotButtonClicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new ForgotPasswordPage());
		}
	}
}
