using RestApi.Model;
using RestApi.Utils;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace RestApi.ViewModels
{
	class PostsViewModel : INotifyPropertyChanged
	{
		private ObservableCollection<Post> items;
		public ObservableCollection<Post> Items
		{
			get => items;
			set
			{
				items = value;
				OnPropertyChanged("Items");
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;
		public PostsViewModel()
		{
			
		}
		private void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}
