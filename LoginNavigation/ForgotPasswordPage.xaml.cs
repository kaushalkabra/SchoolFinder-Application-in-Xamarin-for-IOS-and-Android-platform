using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace LoginNavigation
{
	public partial class ForgotPasswordPage : ContentPage
	{
		loginManager manager;
		public ForgotPasswordPage()
		{
			InitializeComponent();
			manager = loginManager.DefaultManager;
		}

		async void getSecurityQuestion(object sender, EventArgs e)
		{
			var user = new login { userName = usernameEntry.Text };
			List<login> items = await manager.checkUserName(user);
			if (items.Count > 0)
			{
				securityQuestion.Placeholder = items[0].SecurityQuestion;
				securityQuestionAnswer.IsEnabled = true;
			}
			else {
				messageLabel.Text = "Username not exist in our database. Please try again!!";
				usernameEntry.Text = "";
			}
		}

		async void OnRecoverPasswordClicked(object sender, EventArgs e)
		{
			var user = new login { userName = usernameEntry.Text,
				Answer = securityQuestionAnswer.Text };
			List<login> items = await manager.checkUserName(user);
			if (items.Count > 0) {
				if (user.Answer == items[0].Answer)
				{
					messageLabel.Text = "Password is : " + items[0].Password;
				}
				else {
					messageLabel.Text = "Answer does not match to given answer. Please try again!!";
					securityQuestionAnswer.Text = "";
				}
			}
		}
	}
}
