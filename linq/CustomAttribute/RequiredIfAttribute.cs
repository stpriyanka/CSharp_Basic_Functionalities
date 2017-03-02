using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Build.Framework;

namespace CustomAttribute
{
	//public class Program1
	//{
	//	private static void Main1(string[] args)
	//	{
	//		var test = new TestObj()
	//		{
	//			Name = "foo!",
	//			Gender = new object()
	//		};
	//		Required.PerformCheck(test);
	//	}
	//}

	public class TestObj
	{
		public string Name { get; set; }

		[IfSpecified]
		public object PersonalNumber { get; set; }

		[RequiredIf(When = "PersonalNumber != null")]
		public object Gender { get; set; }
	}

	[AttributeUsage(AttributeTargets.Property)]
	public class RequiredIf : Attribute
	{
		public string When { get; set; }
	}



	[AttributeUsage(AttributeTargets.Property)]
	public class IfSpecified : Attribute
	{
		//public string Condition { get; set; }

		public static void PerformCheck(object objectToCheck)
		{
			var properties = new List<PropertyInfo>();
			var type = objectToCheck.GetType();

			foreach (var prop in type.GetProperties())
				if (prop.GetCustomAttributes(typeof(IfSpecified), true).Any())
					properties.Add(prop);

			foreach (var prop in properties)
			{
				object value = prop.GetValue(objectToCheck, null);

				//Validation logic here
				if (!String.IsNullOrEmpty(value as string))
				{
					var props = type.GetProperties().Where(p => IsDefined(p, typeof(RequiredIf)));

					foreach (var propertyInfo in props.Where(propertyInfo => propertyInfo.GetValue(objectToCheck, null) == null))
					{
						throw new Exception(string.Format("Property value '{0}' of type '{1}' is required to be null if {2} is specified",
							propertyInfo.Name, objectToCheck.GetType().FullName, prop.Name));
					}
				}
			}
		}
	}
}

