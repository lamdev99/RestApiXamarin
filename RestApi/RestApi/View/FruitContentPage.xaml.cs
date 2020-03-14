using RestApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RestApi.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class FruitContentPage : ContentPage
	{
		public FruitContentPage()
		{
			InitializeComponent();
		}

		private void MenuItem_Clicked(object sender, EventArgs e)
		{

		}


		private async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
		{
			

		}

		private void OnItemTapped(object sender, ItemTappedEventArgs e)
		{
			var detail = e.Item as Fruit;
			Navigation.PushAsync(new DetailPage(detail.Name, detail.ImageUrl),true);
		}
	}
}