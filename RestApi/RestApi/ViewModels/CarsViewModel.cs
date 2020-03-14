using RestApi.Model;
using RestApi.Utils;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace RestApi.ViewModels
{
	class CarsViewModel :INotifyPropertyChanged
	{
		private ObservableCollection<Car> items;

		public event PropertyChangedEventHandler PropertyChanged;

		public ObservableCollection<Car> Items
		{
			get => items;
			set
			{
				items = value;
				RaisePropertyChanged("Items");
			}
		}
		public CarsViewModel()
		{
			Items = new ObservableCollection<Car>();
			MyHTTP.GetTaskAsync(list =>
			{
				foreach (Car car in list)
					Items.Add(car);
			});
		}
		void RaisePropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
				PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}
