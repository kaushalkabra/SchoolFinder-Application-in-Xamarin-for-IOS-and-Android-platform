using System;
using Microsoft.WindowsAzure.MobileServices;
using Newtonsoft.Json;
using Xamarin.Forms;



namespace LoginNavigation
{
	public class Title : ContentPage
	{
			string id;
			string programs;
			string degrees;
			string size;
			string region;
			string type_of_org;
		int number;

		[JsonProperty(PropertyName = "id")]
		public string tid
		{
			get { return id; }
			set { id = value; }
		}

		[JsonProperty(PropertyName = "Columnid")]
		public int cid
		{
			get { return number; }
			set { number = value; }
		}


		[JsonProperty(PropertyName = "Programs")]
		public string Programs
		{
			get { return programs; }
			set { programs = value; }
		}


		[JsonProperty(PropertyName = "Degrees")]
		public string Degrees
		{
			get { return degrees; }
			set { degrees = value; }
		}


		[JsonProperty(PropertyName = "Size")]
		public string Size
		{
			get { return size; }
			set { size = value; }
		}


		[JsonProperty(PropertyName = "Region")]
		public string Region
		{
			get { return region; }
			set { region = value; }
		}


		[JsonProperty(PropertyName = "type_of_organization")]
		public string Type_of_oraganisation
		{
			get { return type_of_org; }
			set { type_of_org = value; }
		}

	}
}



