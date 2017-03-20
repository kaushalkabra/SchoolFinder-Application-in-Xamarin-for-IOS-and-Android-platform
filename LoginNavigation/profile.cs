using System;
using Microsoft.WindowsAzure.MobileServices;
using Newtonsoft.Json;

namespace LoginNavigation
{
	public class profile
	{
		string id;
		string name;
		int marks;
		string program;
		string emailId;

		[JsonProperty(PropertyName = "id")]
		public string Id
		{
			get { return id; }
			set { id = value; }
		}

		[JsonProperty(PropertyName = "name")]
		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		[JsonProperty(PropertyName = "marks")]
		public int Marks
		{
			get { return marks; }
			set { marks = value; }
		}

		[JsonProperty(PropertyName = "program")]
		public string Program
		{
			get { return program; }
			set { program = value; }
		}

		[JsonProperty(PropertyName = "emailId")]
		public string EmailId
		{
			get { return emailId; }
			set { emailId = value; }
		}
	}
}

