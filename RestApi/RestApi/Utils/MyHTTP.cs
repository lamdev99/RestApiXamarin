using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestApi.Model;

namespace RestApi.Utils
{
	class MyHTTP
	{
		private static string url = "https://api.myjson.com/bins/jly7p";
		private static string url1 = "https://jsonplaceholder.typicode.com/posts";
		public static async Task GetTaskAsync(Action<IEnumerable<Car>> action)
		{
			HttpClient httpClient = new HttpClient();
			HttpResponseMessage response = await httpClient.GetAsync(url1);
			if(response.StatusCode == System.Net.HttpStatusCode.OK)
			{
				var list = JsonConvert.DeserializeObject<IEnumerable<Car>>(await response.Content.ReadAsStringAsync());
				action(list);
			}
		}
	}
}
