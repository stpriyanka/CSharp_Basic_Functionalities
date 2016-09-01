using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeEnumCheck
{
	class Program
	{
		static void Main(string[] args)
		{
			Program p = new Program();

			int result = p.DateTime1(1);
			Console.WriteLine("Test1 - " + result);

			var s = p.GetDayOfWeek();
			Console.WriteLine("Test2 - " + s);

			p.DaysBetween(DateTime.Today.Date, DateTime.Today.AddDays(6));

		}

		public string GetDayOfWeek()
		{
		
			var t = string.Join(",",
				 from g in "2,4,5".Split(new char[] { ',' })
				 select Enum.GetName(typeof(DayOfWeek), Convert.ToInt32(g)));

			return t;
		}

		public int DateTime1(int day)
		{
			day = (int)DateTime.Now.DayOfWeek;
			return day;
		}


		public int DaysBetween(DateTime d1, DateTime d2)
		{
			TimeSpan span = d2.Subtract(d1);

			var days = (int)span.TotalDays;

			if (days < 7)
			{
				Console.WriteLine("Number of reminded days" + days);
			}

			int numberOfWeeks = (days / 7);
			int mod = (days % 7);


			Console.WriteLine("Number of days" + numberOfWeeks + "weeks" + mod + "day");
			return days;
		}

	}
}
