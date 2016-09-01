using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavaScriptTest
{
	class Program
	{
		static void Main(string[] args)
		{
			var hello = 0;
			int[] values = new[] { 1, 2, 3, 4 };


			for (int i = 0; i < values.Length; i++)
			{
				hello += values[i];
			}
			Console.WriteLine((hello));
		}
	}
}
