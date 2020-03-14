using System;
using System.Collections.Generic;
using System.Text;

namespace RestApi.Model
{
	class Fruit
	{
		public string Name { get; set; }
		public string ImageUrl { get; set; }
		public Fruit(string Name,string ImageUrl)
		{
			this.Name = Name;
			this.ImageUrl = ImageUrl;
		}

		public Fruit()
		{
		}

		public List<Fruit> GetFruit()
		{
			List<Fruit> fruits = new List<Fruit>();
			fruits.Add(new Fruit("Xoai", "https://www.vietnamonline.com/js/ckfinder/userfiles/images/Vietnamese%20mango.jpg"));
			fruits.Add(new Fruit("Mang cut", "https://www.vietnamonline.com/js/ckfinder/userfiles/images/Vietnamese%20mango%20steen.jpg"));
			fruits.Add(new Fruit("Chom Chom", "https://www.vietnamonline.com/js/ckfinder/userfiles/images/Vietnam%20rambutan.jpg"));
			fruits.Add(new Fruit("Sau rieng", "https://www.vietnamonline.com/js/ckfinder/userfiles/images/vietnam%20durian.jpg"));
			fruits.Add(new Fruit("Dua", "https://www.vietnamonline.com/js/ckfinder/userfiles/images/Vietnam%20pineapple.jpg"));
			fruits.Add(new Fruit("Thanh Long", "https://www.vietnamonline.com/js/ckfinder/userfiles/images/Vietnam%20dragon%20fruit.jpg"));
			fruits.Add(new Fruit("Vu sua", "https://www.vietnamonline.com/js/ckfinder/userfiles/images/Vietnam%20star%20apple.jpg"));
			fruits.Add(new Fruit("Du du", "https://www.vietnamonline.com/js/ckfinder/userfiles/images/Vietnam%20papaya.jpg"));
			return fruits;
		}
	}
}
