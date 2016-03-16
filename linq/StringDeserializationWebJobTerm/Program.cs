using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringDeserializationWebJobTerm
{
	class Program
	{
		static void Main(string[] args)
		{
			var s = "[{\"JobId\":\"ca9c38f2-f119-4e50-aa2c-0e2b144c043d\",\"OrgIdFromClient\":\"4356\"}]";
			var data = (List<Model>)Newtonsoft.Json.JsonConvert.DeserializeObject(s, typeof(List<Model>));
			Console.WriteLine(data.FirstOrDefault().JobId);
			Console.WriteLine(data.FirstOrDefault().OrgIdFromClient);

			Console.ReadLine();


		}
	}

	public class Model
	{
		public Guid JobId { get; set; }
		public string OrgIdFromClient { get; set; }
	}
}
