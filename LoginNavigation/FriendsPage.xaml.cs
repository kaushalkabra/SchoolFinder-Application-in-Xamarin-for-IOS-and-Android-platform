using System;
using System.Threading.Tasks;
using System.Linq;
using Xamarin.Forms;

namespace LoginNavigation
{
	public partial class FriendsPage : ContentPage
	{
		ProfileManager manager;
		public FriendsPage()
		{
			InitializeComponent();
			manager = ProfileManager.DefaultManager;
			//getItems();
		
	  }
		public FriendsPage(String name)
		{
			InitializeComponent();
			manager = ProfileManager.DefaultManager;
			getItems(name);

		}

		private async Task getItems(String username)
		{
			listView.ItemsSource = await manager.GetFriends(username);
		}
	}

}


