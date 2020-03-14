using FormsControls.Base;
using RestApi.View;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RestApi
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			MainPage = new AnimationNavigationPage(new FruitContentPage());
		}

		protected override void OnStart()
		{
		}

		protected override void OnSleep()
		{
		}

		protected override void OnResume()
		{
		}
	}
}
