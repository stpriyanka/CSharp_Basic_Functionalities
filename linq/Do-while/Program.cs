using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_while
{
	class Program
	{
		static void Main()
		{
			int[] ids = new int[] { 1, 2, 3, 4 };

			//
			// Use do-while loop to sum numbers in 4-element array.
			//
			int sum = 0;
			int i = 0;
			do
			{
				sum += ids[i];
				i++;
			} while (i < 4);

			System.Console.WriteLine(sum);
			Console.ReadLine();
		}
	}
}
