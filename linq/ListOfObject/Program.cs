using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ListOfObject
{

	class Program
	{
		static void Main(string[] args)
		{
			desirialize sDesirialize = new desirialize();
			var s = sDesirialize.jsondeserializer("{\"JobId\":\"ca9c38f2-f119-4e50-aa2c-0e2b144c043d\",\"OrgIdFromClient\":\"4356\"}");

			Console.WriteLine(s.JobId);
			Console.WriteLine(s.OrgIdFromClient);

			Console.ReadLine();

		}
	}

	public class Model
	{
		public Guid JobId { get; set; }
		public string OrgIdFromClient { get; set; }
	}

	public class desirialize
	{
		public Model jsondeserializer(string x)
		{
			return JsonConvert.DeserializeObject<Model>(x);
		}

	}
}


