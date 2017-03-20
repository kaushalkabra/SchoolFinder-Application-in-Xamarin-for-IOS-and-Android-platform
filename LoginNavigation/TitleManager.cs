using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.MobileServices;

namespace LoginNavigation
{
	public partial class TitleManager
	{
		static TitleManager defaultInstance = new TitleManager();
		MobileServiceClient client;

		IMobileServiceTable<Title> titleTable;



		const string offlineDbPath = @"localstore.db";
		private TitleManager()
		{
			this.client = new MobileServiceClient(Constants.ApplicationURL);


			this.titleTable = client.GetTable<Title>();

		}


		public static TitleManager DefaultManager
		{
			get
			{
				return defaultInstance;
			}
			private set
			{
				defaultInstance = value;
			}
		}

		public MobileServiceClient CurrentClient
		{
			get { return client; }
		}

		public async Task<ObservableCollection<Title>> GetTitleItemsAsync(bool syncItems = false)
		{
			try
			{

				IEnumerable<Title> titles = await titleTable
					.ToEnumerableAsync();

				return new ObservableCollection<Title>(titles);
			}
			catch (MobileServiceInvalidOperationException msioe)
			{
				Debug.WriteLine(@"Invalid sync operation: {0}", msioe.Message);
			}
			catch (Exception e)
			{
				Debug.WriteLine(@"Sync error: {0}", e.Message);
			}
			return null;
		}


		public async Task<List<Title>> GetProgramNumber(String programName) {
			List<Title> items = await titleTable.Where(Title => Title.Programs == programName).ToListAsync();
			return items;
		}

		public async Task<List<Title>> GetRegionNumber(String regionName)
		{
			List<Title> items = await titleTable.Where(Title => Title.Region == regionName).ToListAsync();
			return items;
		}

		public async Task<List<Title>> GetTypeNumber(String typeName)
		{
			List<Title> items = await titleTable.Where(Title => Title.Type_of_oraganisation == typeName).ToListAsync();
			return items;
		}

		public async Task<List<Title>> GetSizeNumber(String sizeName)
		{
			List<Title> items = await titleTable.Where(Title => Title.Size == sizeName).ToListAsync();
			return items;
		}
	}
}

