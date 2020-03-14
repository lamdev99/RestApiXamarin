using RestApi.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestApi.ViewModels
{
	class FruitViewModel
	{
		public List<Fruit> Fruits { get; set; }
		public FruitViewModel()
		{
			Fruits = new Fruit().GetFruit();
		}
	}
}
