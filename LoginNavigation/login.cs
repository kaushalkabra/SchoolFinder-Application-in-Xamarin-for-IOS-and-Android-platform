using System;
using Microsoft.WindowsAzure.MobileServices;
using Newtonsoft.Json;

namespace LoginNavigation
{
	public class login
	{
		string id;
		string name;
		string password;
		string question;
		string answer;

		[JsonProperty(PropertyName = "id")]
		public string Id
		{
			get { return id; }
			set { id = value; }
		}

		[JsonProperty(PropertyName = "username")]
		public string userName
		{
			get { return name; }
			set { name = value; }
		}

		[JsonProperty(PropertyName = "password")]
		public string Password
		{
			get { return password; }
			set { password = value; }
		}

		[JsonProperty(PropertyName = "securityQuestion")]
		public string SecurityQuestion
		{
			get { return question; }
			set { question = value; }
		}

		[JsonProperty(PropertyName = "answer")]
		public string Answer
		{
			get { return answer; }
			set { answer = value; }
		}
	}
}

