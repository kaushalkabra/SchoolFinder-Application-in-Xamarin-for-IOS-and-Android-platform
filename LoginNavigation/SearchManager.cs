using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.MobileServices.Query;
using Microsoft.WindowsAzure.MobileServices;

namespace LoginNavigation
{
	public partial class SearchManager
	{
		static SearchManager defaultInstance = new SearchManager();
		MobileServiceClient client;

		IMobileServiceTable<SchoolFind> searchTable;



		const string offlineDbPath = @"localstore.db";
		private SearchManager()
		{
			this.client = new MobileServiceClient(Constants.ApplicationURL);


			this.searchTable = client.GetTable<SchoolFind>();
		}


		public static SearchManager DefaultManager
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

		public async Task<ObservableCollection<SchoolFind>> GetSearchItemsAsync(bool syncItems = false)
		{
			try
			{
				IEnumerable<SchoolFind> schools = await searchTable
					.ToEnumerableAsync();

				return new ObservableCollection<SchoolFind>(schools);
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

		public async Task<List<SchoolFind>> GetSearchData(SchoolFind user) {

			List<SchoolFind> items = new List<SchoolFind>();

			//1
			if (user.Program!= null && user.State != null && user.Region != null && user.Size != null && user.Name !=null)
			{
				items = await searchTable.Where(SchoolFind => SchoolFind.Program == user.Program && SchoolFind.State == user.State
																	   && SchoolFind.Region == user.Region && SchoolFind.Size == user.Size
																	   && SchoolFind.Name == user.Name)
																.ToListAsync();
				return items;
			}//2
			if (user.Program != null && user.State != null && user.Region != null && user.Size != null) {
				items = await searchTable.Where(SchoolFind => SchoolFind.Program == user.Program && SchoolFind.State == user.State
																	   && SchoolFind.Region == user.Region && SchoolFind.Size == user.Size)
																.ToListAsync();
				return items; }
			//3
			if (user.Program != null && user.State != null && user.Region != null && user.Name != null) {
				items = await searchTable.Where(SchoolFind => SchoolFind.Program == user.Program && SchoolFind.State == user.State
																	   && SchoolFind.Region == user.Region && SchoolFind.Name == user.Name)
																.ToListAsync();
				return items;
			}//4
			if (user.Program != null && user.State != null && user.Size != null && user.Name != null) { 
				items = await searchTable.Where(SchoolFind => SchoolFind.Program == user.Program && SchoolFind.State == user.State
													&& SchoolFind.Size == user.Size && SchoolFind.Name == user.Name)
																.ToListAsync();
				return items;
			}//5
			if (user.State != null && user.Region != null && user.Size != null && user.Name != null) { 
				items = await searchTable.Where(SchoolFind => SchoolFind.State == user.State
																	   && SchoolFind.Region == user.Region && SchoolFind.Size == user.Size
																	   && SchoolFind.Name == user.Name)
																.ToListAsync();
				return items;
			}//6
			if (user.Program != null && user.Region != null && user.Size != null && user.Name != null)
			{
				items = await searchTable.Where(SchoolFind => SchoolFind.Program == user.Program && SchoolFind.Region == user.Region 
				                                && SchoolFind.Size == user.Size && SchoolFind.Name == user.Name)
																.ToListAsync();
				return items;
			}//7
			if (user.Program != null && user.State != null && user.Region != null)
			{
				items = await searchTable.Where(SchoolFind => SchoolFind.Program == user.Program && SchoolFind.State == user.State
																	   && SchoolFind.Region == user.Region)
																.ToListAsync();
				return items;
			}//8
			if (user.Program != null && user.State != null && user.Size != null)
			{
				items = await searchTable.Where(SchoolFind => SchoolFind.Program == user.Program && SchoolFind.State == user.State
																	 && SchoolFind.Size == user.Size)
																.ToListAsync();
				return items;
			}//9
			if (user.Program != null && user.State != null && user.Name != null)
			{
				items = await searchTable.Where(SchoolFind => SchoolFind.Program == user.Program && SchoolFind.State == user.State
																	   && SchoolFind.Name == user.Name)
																.ToListAsync();
				return items;
			}//10
			if (user.Program != null && user.Region != null && user.Size != null)
			{
				items = await searchTable.Where(SchoolFind => SchoolFind.Program == user.Program
																	   && SchoolFind.Region == user.Region && SchoolFind.Size == user.Size)
																.ToListAsync();
				return items;
			}//11
			if (user.Program != null && user.Region != null && user.Name != null)
			{
				items = await searchTable.Where(SchoolFind => SchoolFind.Program == user.Program
									&& SchoolFind.Region == user.Region && SchoolFind.Name == user.Name)
																.ToListAsync();
				return items;
			}//12
			if (user.Program != null && user.Size != null && user.Name != null)
			{
				items = await searchTable.Where(SchoolFind => SchoolFind.Program == user.Program && SchoolFind.Size == user.Size
																	   && SchoolFind.Name == user.Name)
																.ToListAsync();
				return items;
			}//13
			if (user.State != null && user.Region != null && user.Size != null)
			{
				items = await searchTable.Where(SchoolFind => SchoolFind.State == user.State
																	   && SchoolFind.Region == user.Region && SchoolFind.Size == user.Size)
																.ToListAsync();
				return items;
			}//14
			if (user.State != null && user.Region != null && user.Name != null)
			{
				items = await searchTable.Where(SchoolFind => SchoolFind.State == user.State
																	   && SchoolFind.Region == user.Region && SchoolFind.Name == user.Name)
																.ToListAsync();
				return items;
			}//15
			if (user.State != null && user.Size != null && user.Name != null)
			{
				items = await searchTable.Where(SchoolFind => SchoolFind.State == user.State && SchoolFind.Size == user.Size
																	   && SchoolFind.Name == user.Name)
																.ToListAsync();
				return items;
			}//16
			if (user.Region != null && user.Size != null && user.Name != null)
			{
				items = await searchTable.Where(SchoolFind => SchoolFind.Region == user.Region && SchoolFind.Size == user.Size
																	   && SchoolFind.Name == user.Name)
																.ToListAsync();
				return items;
			}//17
			if (user.Program != null && user.State != null)
			{
				items = await searchTable.Where(SchoolFind => SchoolFind.Program == user.Program && SchoolFind.State == user.State)
																.ToListAsync();
				return items;
			}//18
			if (user.Program != null && user.Region != null)
			{
				items = await searchTable.Where(SchoolFind => SchoolFind.Program == user.Program && SchoolFind.Region == user.Region)
																.ToListAsync();
				return items;
			}//19
			if (user.Program != null && user.Size != null)
			{
				items = await searchTable.Where(SchoolFind => SchoolFind.Program == user.Program && SchoolFind.Size == user.Size)
																.ToListAsync();
				return items;
			}//20
			if (user.Program != null && user.Name != null)
			{
				items = await searchTable.Where(SchoolFind => SchoolFind.Program == user.Program && SchoolFind.Name == user.Name)
																.ToListAsync();
				return items;
			}//21
			if (user.State != null && user.Region != null)
			{
				items = await searchTable.Where(SchoolFind => SchoolFind.State == user.State && SchoolFind.Region == user.Region)
																.ToListAsync();
				return items;
			}//22
			if (user.State != null && user.Size != null)
			{
				items = await searchTable.Where(SchoolFind => SchoolFind.State == user.State && SchoolFind.Size == user.Size)
																.ToListAsync();
				return items;
			}//23
			if (user.State != null && user.Name != null)
			{
				items = await searchTable.Where(SchoolFind => SchoolFind.State == user.State && SchoolFind.Name == user.Name)
																.ToListAsync();
				return items;
			}//24
			if (user.Region != null && user.Name != null)
			{
				items = await searchTable.Where(SchoolFind => SchoolFind.Region == user.Region && SchoolFind.Name == user.Name)
																.ToListAsync();
				return items;
			}//25
			if (user.Region != null && user.Size != null)
			{
				items = await searchTable.Where(SchoolFind => SchoolFind.Region == user.Region && SchoolFind.Size == user.Size)
																.ToListAsync();
				return items;
			}//26
			if (user.Program != null)
			{
				items = await searchTable.Where(SchoolFind => SchoolFind.Program == user.Program)
																.ToListAsync();
				return items;
			}//27
			if (user.State != null)
			{
				items = await searchTable.Where(SchoolFind => SchoolFind.State == user.State)
																.ToListAsync();
				return items;
			}//28
			if (user.Region != null)
			{
				items = await searchTable.Where(SchoolFind => SchoolFind.Region == user.Region)
																.ToListAsync();
				return items;
			}//29
			if (user.Size != null)
			{
				items = await searchTable.Where(SchoolFind => SchoolFind.Size == user.Size)
																.ToListAsync();
				return items;
			}//30
			if (user.Name != null)
			{
				items = await searchTable.Where(SchoolFind => SchoolFind.Name == user.Name)
																.ToListAsync();
				return items;
			}
			return items = await searchTable.ToListAsync();
		}
	}
}

