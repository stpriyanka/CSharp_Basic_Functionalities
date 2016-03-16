using System;
using System.Collections.Generic;
using System.Linq;

namespace linq
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IList<string> list = new List<string>();
            list.Add("Mouse");
            list.Add("Dinner");
            list.Add("House");
            list.Add("Out");
            list.Add("Phone");
            list.Add("Hat");
            list.Add("Ounce");
            
            var result = list.Where(x => x.ToUpperInvariant().Contains("O"))
                        .OrderByDescending(x => x.ToUpperInvariant().StartsWith("O"))
                        .Select(x => x);
            Dump(result);


        }
        
        public static void Dump(IEnumerable<string> input)
        {
            foreach(var item in input)
                Console.WriteLine(item);
        }
    }
}

