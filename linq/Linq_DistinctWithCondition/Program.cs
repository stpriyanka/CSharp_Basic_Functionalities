using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq_DistinctWithCondition
{
	class Program
	{

		//Retrives name with distict value
		// if same name contains twice take one but if any name contains code = [int] or null take the one that has [int]
		//store value somewhere and print
		static void Main(string[] args)
		{

			//*****************          Hard coded value for demo purpose
			var list = new List<Product>();

			var item = new Product()
			{
				Code = 1,
				Name = "hi"
			};

			var q = new Product()
			{
				Code = 1,
				Name = "hello"
			};

			var r = new Product()
			{

				Name = "hi"
			};

			var s = new Product()
			{
				Code = 1,
				Name = "hello"
			};
			var t = new Product()
			{

				Name = "myname"
			};


			list.Add(item);
			list.Add(q);
			list.Add(r);
			list.Add(s);
			list.Add(t);

			//******************************


			var allnames = new List<string>();

			var nameAndodeContainer = new List<Tuple<string, int>>();

			foreach (var product in list)
			{
				allnames.Add(product.Name);

			//To make sure all the items I have in the list has code != null*********
				if (product.Code != null)
				{
					nameAndodeContainer.Add(new Tuple<string, int>(product.Name, product.Code));
				}
			}

			List<string> onlyDistinctName = allnames.Distinct().ToList();

			foreach (var item1 in allnames.Where(item1 => !onlyDistinctName.Contains(item1)))
			{
				onlyDistinctName.Add(item1);
			}



			foreach (var each in onlyDistinctName)
			{
				var code = nameAndodeContainer.Where(x => x.Item1 == each).Select(x => x.Item2).FirstOrDefault();
				Console.WriteLine("code = " + code + ", name = " + each);
			}


		}


	}
	public class Product
	{
		public string Name { get; set; }
		public int Code { get; set; }
	}


}
