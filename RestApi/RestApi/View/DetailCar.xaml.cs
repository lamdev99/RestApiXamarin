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
	public partial class DetailCar : ContentPage
	{
		public DetailCar(int id,int userId,string title,string body)
		{
			InitializeComponent();
			Id.Text = id + "";
			UserId.Text = userId + "";
			Title.Text = title;
			Body.Text = body;
			BindingContext = this;
		}
	}
}