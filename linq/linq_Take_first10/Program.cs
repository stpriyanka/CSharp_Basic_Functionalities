using System;
using System.Collections.Generic;
using System.Linq;

namespace linq_Take_first10
{
	class Program
	{
		static void Main()
		{
			var list = new List<string>();
			list.Add("cat1");
			list.Add("dog2");
			list.Add("programmer3");
			list.Add("programmer4");
			list.Add("programmer5");
			list.Add("programmer6");
			list.Add("programmer7");
			list.Add("programmer8");
			list.Add("programmer9");
			list.Add("programmer10");


			for (int i = 0; i < list.Count; i = i + 2)
			{


				var y = list.Skip(i).Take(2).ToArray();

				foreach (string s in y)
				{
					Console.WriteLine(s);
				}
			}

		}
	}
}
