using System;
using Microsoft.WindowsAzure.MobileServices;
using Newtonsoft.Json;
using Xamarin.Forms;


namespace LoginNavigation
{
	public class searchPage

	{
			string program; //string
			string degree; //string
			string state; //string
			string region; //string
			string zipcode;
			string size;
			string name; //string
			string typeofschool; 
			string url; //string
			string costcalculator; //string
			string latitude;
			string longitude;
			string localeofcity; //string
			string cost; 
			string tuitionfee;
			string earning; 
			string no_of_campus;
		    string admission_rate;
			string sat;
			string enrollment;
		    string aid;
		    string facultyfulltime;
			string male;
			string female;
			string debt;
			string completion;
				

			string agriculture;
			string resources;
			string architecture;
			string ethnic_cultural_gender;
			string communication;
			string communications_technology;
			string computer;
			string personal_culinary;
			string education;
			string engineering;
			string engineering_technology;
			string language;
			string family_consumer_science;
			string legal;
			string english;
			string humanities;
			string library;
			string biological;
			string mathematics;
			string military;
			string multidiscipline;
			string parks_recreation_fitness;
			string philosophy_religious;
			string theology_religious_vocation;
			string physical_science;
			string science_technology;
			string psychology;
			string security_law_enforcement;
			string public_administration_social_service;
			string social_science;
			string construction;
			string mechanic_repair_technology;
			string precision_production;
			string transportation;
			string visual_performing;
			string health;
			string business_marketing;
			string history;

		[JsonProperty(PropertyName = "CCUGPROF")]
		public string Program
		{
			get { return program;}
				set { program = value; }
		}

		[JsonProperty(PropertyName = "INSTNM")]
		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		[JsonProperty(PropertyName = "ZIP")]
		public string Zipcode
		{
			get { return zipcode; }
			set { zipcode = value; }
		}

		[JsonProperty(PropertyName = "INSTURL")]
		public string Url
		{
			get { return url; }
			set { url = value; }
		}


		[JsonProperty(PropertyName = "NPCURL")]
		public string Costcalculator
		{
			get { return costcalculator; }
			set { costcalculator = value; }
		}


		[JsonProperty(PropertyName = "MAIN")]
		public string No_of_campus
		{
			get { return no_of_campus; }
			set { no_of_campus = value; }
		}

		[JsonProperty(PropertyName = "ST_FIPS")]
		public string State
		{
			get { return state; }
			set { state = value; }
		}

		[JsonProperty(PropertyName = "REGION")]
		public string Region
		{
			get { return region; }
			set { region = value; }
		}

		[JsonProperty(PropertyName = "C100_4")]
		public string Completion
		{
			get { return completion; }
			set { completion = value; }
		}


		[JsonProperty(PropertyName = "LATITUDE")]
		public string Latitude
		{
			get { return latitude; }
			set { latitude = value; }
		}

		[JsonProperty(PropertyName = "LONGITUDE")]
		public string Longitude
		{
			get { return longitude; }
			set { longitude = value; }
		}


		[JsonProperty(PropertyName = "ADM_RATE")]
		public string Admission_rate
		{
			get { return admission_rate; }
			set { admission_rate = value; }
		}

		[JsonProperty(PropertyName = "SAT_AVG")]
		public string Sat
		{
			get { return sat; }
			set { sat = value; }
		}


		[JsonProperty(PropertyName = "UG")]
		public string Enrollment
		{
			get { return enrollment; }
			set { enrollment = value; }
		}

		[JsonProperty(PropertyName = "COSTT4_A")]
		public string Tuitionfee
		{
			get { return tuitionfee; }
			set { tuitionfee = value; }
		}
		[JsonProperty(PropertyName = "PCTFLOAN")]
		public string Aid
		{
			get { return aid; }
			set { aid = value; }
		}

		[JsonProperty(PropertyName = "MN_EARN_WNE_P6")]
		public string Earning
		{
			get { return earning; }
			set { earning = value; }
		}

		[JsonProperty(PropertyName = "PFTFAC")]
		public string Facultyfulltime
		{
			get { return facultyfulltime; }
			set { facultyfulltime = value; }
		}

		[JsonProperty(PropertyName = "UGDS_MEN")]
		public string Male
		{
			get { return male; }
			set { male = value; }
		}


		[JsonProperty(PropertyName = "UGDS_WOMEN")]
		public string Female
		{
			get { return female; }
			set { female = value; }
		}


		[JsonProperty(PropertyName = "GRAD_DEBT_MDN")]
		public string Debt
		{
			get { return debt; }
			set { debt = value; }
		}


		[JsonProperty(PropertyName = "PCIP01")]
		public string Agriculture
		{
			get { return agriculture ; }
			set { agriculture = value; }
		}

		[JsonProperty(PropertyName = "PCIP03")]
		public string Resources
		{
			get { return resources; }
			set { resources = value; }
		}

		[JsonProperty(PropertyName = "PCIP04")]
		public string Architecture
		{
			get { return architecture; }
			set { architecture = value; }
		}
		[JsonProperty(PropertyName = "PCIP05")]
		public string Ethnic_cultural_gender
		{
			get { return ethnic_cultural_gender; }
			set { ethnic_cultural_gender = value; }
		}
		[JsonProperty(PropertyName = "PCIP09")]
		public string Communication
		{
			get { return communication; }
			set { communication = value; }
		}
		[JsonProperty(PropertyName = "PCIP10")]
		public string Communications_technology
		{
			get { return communications_technology; }
			set { communications_technology = value; }
		}
		[JsonProperty(PropertyName = "PCIP11")]
		public string Computer
		{
			get { return computer; }
			set { computer = value; }
		}
		[JsonProperty(PropertyName = "PCIP12")]
		public string Personal_culinary
		{
			get { return personal_culinary; }
			set { personal_culinary = value; }
		}
		[JsonProperty(PropertyName = "PCIP13")]
		public string Education
		{
			get { return education; }
			set { education = value; }
		}
		[JsonProperty(PropertyName = "PCIP14")]
		public string Engineering
		{
			get { return engineering; }
			set { engineering = value; }
		}
		[JsonProperty(PropertyName = "PCIP015")]
		public string Engineering_technology
		{
			get { return engineering_technology; }
			set { engineering_technology = value; }
		}
		[JsonProperty(PropertyName = "PCIP16")]
		public string Language
		{
			get { return language; }
			set { language = value; }
		}
		[JsonProperty(PropertyName = "PCIP19")]
		public string Family_consumer_science
		{
			get { return family_consumer_science; }
			set { family_consumer_science = value; }
		}

		[JsonProperty(PropertyName = "PCIP22")]
		public string Legal
		{
			get { return legal; }
			set { legal = value; }
		}

		[JsonProperty(PropertyName = "PCIP23")]
		public string English
		{
			get { return english; }
			set { english = value; }
		}
		[JsonProperty(PropertyName = "PCIP24")]
		public string Humanities
		{
			get { return humanities; }
			set { humanities = value; }
		}
		[JsonProperty(PropertyName = "PCIP25")]
		public string Library
		{
			get { return library; }
			set { library = value; }
		}
		[JsonProperty(PropertyName = "PCIP26")]
		public string Biological
		{
			get { return biological; }
			set { biological = value; }
		}
		[JsonProperty(PropertyName = "PCIP27")]
		public string Mathematics
		{
			get { return mathematics; }
			set { mathematics = value; }
		}
		[JsonProperty(PropertyName = "PCIP29")]
		public string Military
		{
			get { return military; }
			set { military = value; }
		}
		[JsonProperty(PropertyName = "PCIP30")]
		public string Multidiscipline
		{
			get { return multidiscipline; }
			set { multidiscipline = value; }
		}

		[JsonProperty(PropertyName = "PCIP31")]
		public string Parks_recreation_fitness
		{
			get { return parks_recreation_fitness; }
			set { parks_recreation_fitness = value; }
		}
		[JsonProperty(PropertyName = "PCIP38")]
		public string Philosophy_religious
		{
			get { return philosophy_religious; }
			set { philosophy_religious = value; }
		}
		[JsonProperty(PropertyName = "PCIP39")]
		public string Theology_religious_vocation
		{
			get { return theology_religious_vocation; }
			set { theology_religious_vocation = value; }
		}
		[JsonProperty(PropertyName = "PCIP40")]
		public string Physical_science
		{
			get { return physical_science; }
			set { physical_science = value; }
		}

		[JsonProperty(PropertyName = "PCIP41")]
		public string Science_technology
		{
			get { return science_technology; }
			set { science_technology = value; }
		}

		[JsonProperty(PropertyName = "PCIP42")]
		public string Psychology
		{
			get { return psychology; }
			set { psychology = value; }
		}

		[JsonProperty(PropertyName = "PCIP43")]
		public string Security_law_enforcement
		{
			get { return security_law_enforcement; }
			set { security_law_enforcement = value; }
		}

		[JsonProperty(PropertyName = "PCIP44")]
		public string Public_administration_social_service
		{
			get { return public_administration_social_service; }
			set { public_administration_social_service = value; }
		}

		[JsonProperty(PropertyName = "PCIP45")]
		public string Social_science
		{
			get { return social_science; }
			set { social_science = value; }
		}

		[JsonProperty(PropertyName = "PCIP46")]
		public string Construction
		{
			get { return construction; }
			set { construction = value; }
		}

		[JsonProperty(PropertyName = "PCIP47")]
		public string Mechanic_repair_technology
		{
			get { return mechanic_repair_technology; }
			set { mechanic_repair_technology = value; }
		}

		[JsonProperty(PropertyName = "PCIP48")]
		public string Precision_production
		{
			get { return precision_production; }
			set { precision_production = value; }
		}

		[JsonProperty(PropertyName = "PCIP49")]
		public string Transportation
		{
			get { return transportation; }
			set { transportation = value; }
		}

		[JsonProperty(PropertyName = "PCIP50")]
		public string Visual_performing
		{
			get { return visual_performing; }
			set { visual_performing = value; }
		}

		[JsonProperty(PropertyName = "PCIP51")]
		public string Health
		{
			get { return health; }
			set { health = value; }
		}

		[JsonProperty(PropertyName = "PCIP52")]
		public string Business_marketing
		{
			get { return business_marketing; }
			set { business_marketing = value; }
		}

		[JsonProperty(PropertyName = "PCIP54")]
		public string History
		{
			get { return history; }
			set { history = value; }
		}




		}
	
}

