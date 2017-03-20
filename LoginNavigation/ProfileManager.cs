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
	public partial class ProfileManager
	{
		static ProfileManager defaultInstance = new ProfileManager();
		MobileServiceClient client;

		IMobileServiceTable<profile> profileTable;


		const string offlineDbPath = @"localstore.db";
		private ProfileManager()
		{
			this.client = new MobileServiceClient(Constants.ApplicationURL);


			this.profileTable = client.GetTable<profile>();

		}


		public static ProfileManager DefaultManager
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

		public async Task<ObservableCollection<profile>> GetTodoItemsAsync(bool syncItems = false)
		{
			try
			{

				IEnumerable<profile> items = await profileTable
					.ToEnumerableAsync();

				return new ObservableCollection<profile>(items);
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

		public async Task<Boolean> SaveTaskAsync(profile item)
		{
			List<profile> items = await profileTable.Where(profile => profile.Name == item.Name && profile.EmailId == item.EmailId).ToListAsync();
			if (items.Count <= 0)
			{
				if (item.Id == null)
				{
					await profileTable.InsertAsync(item);
				}
				else
				{
					await profileTable.UpdateAsync(item);
				}
				return true;
			}
			else
			{
				return false;
			}

		}

		public async Task<ObservableCollection<profile>> GetFriends(String username)
		{
			try
			{

				IEnumerable<profile> items = await profileTable
					.Where(profile => username != profile.Name).ToListAsync();

				return new ObservableCollection<profile>(items);
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

	}
}

