using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CustomAttribute
{
	class Program
	{
		static void Main(string[] args)
		{
			var test = new TestObj()
			{
				Name = "foo!",
				PersonalNumber = "910112-2449",
				Gender = null,
			};
			
			IfSpecified.PerformCheck(test);

			//var obj = new Customer();
			//obj.CustomerCode = "12345678901";

			//if (obj.CustomerCode != null)
			//{
			//	CheckFirst(obj);

			//	Console.WriteLine("done");
			//}
		}


		private static void CheckFirst(Customer obj)
		{
			Type objtype = obj.GetType();

			// Loop through all properties                           //props  of Customer
			foreach (PropertyInfo p in objtype.GetProperties())
			{
				// for every property loop through all attributes    // attributes of each prop 
				foreach (Attribute a in p.GetCustomAttributes(false))
				{
					Check c = (Check)a;
					if (p.Name == "CustomerCode")
					{
						// Do the length check and and raise exception accordingly
						if (obj.CustomerCode.Length > c.MaxLength)
						{
							throw new Exception(" Max length issues ");
						}

					}
				}
			}
		}
	}


	[AttributeUsage(AttributeTargets.Property)]
	public class Check : Attribute
	{
		public int MaxLength { get; set; }
		//public string CompareLength { get; set; }
	}


	public class Customer
	{
		[Check(MaxLength = 5)]
		public string CustomerCode { get; set; }
		public string Title { get; set; }
	}
}
