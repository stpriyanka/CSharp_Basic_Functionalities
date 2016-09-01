using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Itenso.TimePeriod;

namespace Tuple_LinqSearch_Ienumerable
{
	class Program
	{
		static void Main(string[] args)
		{
			var itemOne = new List<string>();

			var tupleCollectionOptionalClasses = new List<Tuple<string, string>>();

			tupleCollectionOptionalClasses.Add(new Tuple<string, string>("Hank", "Hank_First"));
			tupleCollectionOptionalClasses.Add(new Tuple<string, string>("Joe", "Joe_First"));
			tupleCollectionOptionalClasses.Add(new Tuple<string, string>("Mary", "Mary_First"));
			tupleCollectionOptionalClasses.Add(new Tuple<string, string>("Joe", "Joe_Second"));
			tupleCollectionOptionalClasses.Add(new Tuple<string, string>("Hank", "Hank_Second"));

			IEnumerable<Tuple<string, string>> tuple_JustJoe = tupleCollectionOptionalClasses.Where(
				  delegate(Tuple<string, string> mapNowFinder)
				  {
					  return true;  // case sensitive
				  }
				  );

			foreach (Tuple<string, string> joe_Now in tuple_JustJoe)
			{
				//   Console.WriteLine("joe_Now.Item1 = {0} joe_Now.Item2 = {1}", joe_Now.Item1, joe_Now.Item2);
				itemOne.Add(joe_Now.Item1);
			}
			foreach (var x in itemOne)
			{
				Console.WriteLine(x);
			}

			Console.WriteLine();
			Console.WriteLine("press enter to finish");
			Console.ReadLine();


		}

	}
}

