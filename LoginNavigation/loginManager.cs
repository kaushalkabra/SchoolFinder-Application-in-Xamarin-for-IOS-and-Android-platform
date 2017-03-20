using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.MobileServices;

using Xamarin.Forms;

namespace LoginNavigation
{
	public partial class loginManager
	{
		static loginManager defaultInstance = new loginManager();
		MobileServiceClient client;

		IMobileServiceTable<login> loginTable;

		const string offlineDbPath = @"localstore.db";

		private loginManager()
		{
			this.client = new MobileServiceClient(Constants.ApplicationURL);


			this.loginTable = client.GetTable<login>();
		}


		public static loginManager DefaultManager
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


		public async Task<ObservableCollection<login>> GetTodoItemsAsync(bool syncItems = false)
		{
			try
			{

				IEnumerable<login> items = await loginTable
					.ToEnumerableAsync();

				return new ObservableCollection<login>(items);
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


		public async Task<Boolean> SaveTaskAsync(login item)
		{
			List<login> items = await loginTable.Where(login => login.userName == item.userName).ToListAsync();
			if (items.Count <= 0)
			{
				if (item.Id == null)
				{
					await loginTable.InsertAsync(item);
				}
				else
				{
					await loginTable.UpdateAsync(item);
				}
				return true;
			}
			else {
				return false;
			}

		}

		public async Task<Boolean> CheckTaskAsync(login item)
		{
			List<login> items = await loginTable.Where(login => login.userName == item.userName && login.Password == item.Password).ToListAsync();
			if (items.Count == 1) {
				return true;
			}
			return false;
		}

		public async Task<List<login>> checkUserName(login item) {
			List<login> items = await loginTable.Where(login => login.userName == item.userName).ToListAsync();
			return items;
		}
	}
}
