using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace AccessArrayFromJsonObject
{
	class Program
	{
		static void Main(string[] args)
		{
		 string json = "[{\"OrgId\":4356,\"UserId\":1143},{\"OrgId\":4356,\"UserId\":1144}]";

			//var objects = JArray.Parse(json); 
			//Console.WriteLine(json);
			
		
		
			//foreach (JObject root in objects)
			//{
			//	foreach (KeyValuePair<String, JToken> app in root)
			//	{
			//		var appName = app.Key;
			//		var description = (String)app.Value["Description"];
			//		var value = (String)app.Value["Value"];

			//		Console.WriteLine(appName);
			//		Console.WriteLine(description);
			//		Console.WriteLine(value);
			//		Console.WriteLine("\n");
			//	}
			//}
		}
	}
}
