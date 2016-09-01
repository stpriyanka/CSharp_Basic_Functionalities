using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAndSubArray
{
	public class Program
	{
		static void Main(string[] args)
		{
			// Two-dimensional array.
			int[,] array2D = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };
			System.Console.WriteLine(array2D[0, 1]);

			string[,] array2Db = new string[3, 2] { { "one", "two" }, { "three", "four" },
                                        { "five", "six" } };
			System.Console.WriteLine(array2Db[1,0]);
		}
	}
}
