using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadFromFile
{
	public class Program
	{
		static void Main(string[] args)
		{
			var myFile = new StreamReader("C:\\worldfavor\\Read.txt");

			string myString = myFile.ReadToEnd();

			myFile.Close();

			List<int> influenceIDs = myString.Split(',').Select(s => Convert.ToInt32(s)).ToList();



		}
	}
}
