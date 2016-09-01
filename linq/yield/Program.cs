using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yield
{
	class Program
	{
		Program p = new Program();
		static void Main(string[] args)
		{
			foreach (int i in Integers())
			{
				Console.WriteLine(i.ToString());
			}
			foreach (var i in RetunDate())
			{
				Console.WriteLine(i.ToString());
			}
		
		}


		public void Consumer()
		{
		}

		public  static IEnumerable<int> Integers()
		{
			yield return 1;
			yield return 2;
			yield return 4;
			yield return 8;
			yield return 16;
			yield return 16777216;
		}

		public static IEnumerable<DateTime> RetunDate()
		{
			DateTime d = DateTime.Now.AddDays(10);
			DateTime d2 = DateTime.Now.AddDays(5);
			DateTime d3 = DateTime.Now.AddDays(6);

			yield return d;
			yield return d2;
			yield return d3;
		}

	}
}
