using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Newtonsoft.Json.Linq;

namespace Web_Api_Metadata
{
	class Program
	{
		static void Main(string[] args)
		{
			RunAsync_get_billograms_list_by_customerNo().Wait();
		}

		private static async Task RunAsync_get_billograms_list_by_customerNo()
		{
			const string authUser = "3331-0lgWtglW";
			const string authKey = "761b54eb59aeca57e1a8cfa16fe67693";

			var client = new HttpClient();

			var byteArray = Encoding.ASCII.GetBytes(authUser + ":" + authKey);
			client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));

			client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

			const string baseUrl = "https://sandbox.billogram.com/api/v2/billogram/";

			var query = HttpUtility.ParseQueryString(string.Empty);
			query["page"] = "1";
			query["page_size"] = "50";
			query["filter_type"] = "field";
			query["filter_field"] = "state";
			query["filter_value"] = "unpaid";
			string queryString = query.ToString();

			HttpResponseMessage response = await client.GetAsync(baseUrl + "?" + queryString);
			response.EnsureSuccessStatusCode();
			
			response.Headers.Add("Developer", "sss");


			var responseBody = await response.Content.ReadAsStringAsync();
			JObject json = JObject.Parse(responseBody);

			Console.WriteLine(json);

			Console.ReadLine();

		}
	}
}
