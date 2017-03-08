using System;
using System.Collections.Generic;
using System.Threading;
using Newtonsoft.Json;

namespace JsonextensionSerialize
{
	class Program
	{
		static void Main(string[] args)
		{
			var p = new PersonContainer()
			{
				Age = 12,
				Name = "A name",
				Gender = "Female",
				DOB = DateTime.UtcNow,
				WorkStatus = new WorkStatus()
				{
					Address = "Regeringsgatan ",
					EmployerName = "Test AB",
					WorkingExperienceInYears = 2
				}
			};


			var personS = JsonConvert.SerializeObject(p);
			Console.WriteLine("Serialized data: " + personS + "\n\n\n");

			Console.WriteLine("Attempting to deserialize data.....");
			Thread.Sleep(1000);

			var resultUsingJsonExtension = JsonConvert.DeserializeObject<CustomizedPerson>(personS);
			
			Console.WriteLine("Age :" + resultUsingJsonExtension.Age);
			if (resultUsingJsonExtension.Other != null)
			{
				Console.WriteLine("Other :");
				foreach (var x in resultUsingJsonExtension.Other)
				{
					Console.WriteLine(x);

				}
			}
			Console.WriteLine("Finish !");
			Console.ReadLine();
		}
	}
	class CustomizedPerson
	{
		public int Age { get; set; }

		[JsonExtensionData]
		public IDictionary<string, object> Other { get; set; }

	}

	public class PersonContainer
	{
		public string Name { get; set; }

		public int Age { get; set; }

		public DateTime DOB { get; set; }

		public string Gender { get; set; }

		public WorkStatus WorkStatus { get; set; }

	}

	public class WorkStatus
	{

		public string EmployerName { get; set; }
		public string Address { get; set; }
		public int WorkingExperienceInYears { get; set; }
	}

}
