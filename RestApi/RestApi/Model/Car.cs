using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestApi.Model
{
	class Car
	{

		//public int CarID { get; set; }
		//public string Make { get; set; }
		//public int YearOfModel { get; set; }
		[JsonProperty("id")]
		public int Id { get; set; }
		[JsonProperty("userId")]
		public int UserId { get; set; }
		[JsonProperty("title")]
		public string Title { get; set; }
		[JsonProperty("body")]
		public string Body { get; set; }

	}
}
