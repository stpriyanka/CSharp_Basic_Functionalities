using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace AccessArrayOBj
{
	public class Program
	{
		static void Main(string[] args)
		{
			string json = "[{\"id\":4356,\"UserId\":1143},{\"id\":4356,\"UserId\":1144}]";
			var data = (List<Model>)Newtonsoft.Json.JsonConvert.DeserializeObject(json, typeof(List<Model>));

			foreach (var item in data)
			{
				Console.WriteLine(item.UserId);
			}

	
			
		}
	}
	public class Model
	{
		public int? id { get; set; }
		public int? UserId { get; set; }
	}
}
