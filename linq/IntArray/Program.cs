using System;
using System.Linq;

namespace IntArray
{
	class Program
	{
		static void Main(string[] args)
		{

			int[] structureIds = new[] { 2222, 5555 };

			int[] networkIds = new[] { 7 };


			var strQuery = string.Join("AND" , structureIds.Select(x => "\"" + "id" + x.ToString()).ToArray());


			var ntrwkQuery = string.Join("AND", networkIds.Select(x => x.ToString()).ToArray());


			string fName = "Simon";
			string mName = "Jake";
			string lName = "Harrows";


			Console.WriteLine(" '{0}'AND ", string.Concat(string.Concat(fName, mName), lName));


			string s = "A&B&C";
			//string replaced = "'" + s.Replace("&", "','") + "'";

			string replaced = "\"" + s.Replace("&", "\"AND\"") + "\"";

			Console.WriteLine(s);
			Console.WriteLine(replaced);



			Console.ReadLine();
		}
	}
}
