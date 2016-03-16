using System;
using System.Collections.Generic;


namespace Dictionary
{
	class Program
	{
		readonly Dictionary<string, int> _dictionary =
			new Dictionary<string, int>();

		static void Main()
		{
			var p = new Program();
			p.AddItemInDictioanry();

		
		}
		public void AddItemInDictioanry()
		{

			_dictionary.Add("cat", 2);
			_dictionary.Add("dog", 1);
			_dictionary.Add("llama", 0);
			_dictionary.Add("iguana", -1);

			if (_dictionary != null)
			{

				foreach (KeyValuePair<string, int> keyValuePair in _dictionary)
				{
					Console.WriteLine(keyValuePair);
				}
			}
		}

	}
}
