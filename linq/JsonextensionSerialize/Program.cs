using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JsonextensionSerialize
{
	class Program
	{
		static void Main(string[] args)
		{
			var other2 = new Dictionary<string, object> { { "key1", 1 }, { "key2", 2 }, { "key3", 3 } };

			var p = new Person()
			{
				age = 12,
				name = "somename",
				other = other2
			};


			var personS = JsonConvert.SerializeObject(p);

			Console.WriteLine(personS);
			Console.ReadLine();
		}
	}
	class Person : Base
	{
		public int age;

		[JsonExtensionData]
		public IDictionary<string, object> other;
	}

	abstract class Base
	{
		public string name;

	}

}
