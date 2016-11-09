using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListOfStringAdd
{
	class Program
	{
		static void Main(string[] args)
		{

			//string[] arr = { "one", "two", "three" };

			var x = new List<string>() { "one", "two", "three" };


			Console.WriteLine(string.Join("||", x));

			var s = "chesse";
			//var a = "present";
			string a = null;




			var Text = "hello" + " " + (string.IsNullOrEmpty(a) ? "" : (s + ". "));


			Console.WriteLine(Text);
			Console.ReadLine();

		}
	}
}
