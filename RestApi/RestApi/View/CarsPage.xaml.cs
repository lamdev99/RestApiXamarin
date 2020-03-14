using RestApi.Model;
using RestApi.ViewModels;
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
	public partial class CarsPage : ContentPage
	{
		public CarsPage()
		{
			InitializeComponent();
			BindingContext = new CarsViewModel();
		}

		private void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
		{
			var car = e.SelectedItem as Car;
			Navigation.PushAsync(new DetailCar(car.Id,car.UserId,car.Title,car.Body),true);
		}
	}
}