using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListItemCount
{
	class Program
	{
		static void Main(string[] args)
		{

			var randomList = new List<int>(){1,2,3,4,5,6,1,2,8,4,1,2,3,3,3};

			var groupby = randomList.GroupBy(r => r);

			foreach (var i in groupby)
			{
				Console.WriteLine("{0} {1}", i.Key , i.Count() );
			}


		}
	}
}
