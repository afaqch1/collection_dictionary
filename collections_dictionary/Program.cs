using System;
using System.Collections.Generic;


namespace collections_dictionary
{
    class Program
    {
        static void display(IDictionary<int,string> dic)
        {
            System.Console.WriteLine("---------------------------------------");
            System.Console.WriteLine("Population\t\tCities");
            System.Console.WriteLine("---------------------------------------");
            foreach (var i in dic)
            {
                System.Console.WriteLine(i.Key+"\t\t"+i.Value);

            }
            System.Console.WriteLine("---------------------------------------");

        }
        static void Main(string[] args)
        {
            IDictionary<int, string> d = new Dictionary<int, string>();
            d.Add(12642000, "Lahore");
            d.Add(16094000, "Karachi");
            d.Add(11290000, "Islamabad");
            d.Add(10090000, "Quetta");
            d.Add(21190000, "Peshawar");
            d.Add(10290000, "Multan");
            display(d);

            System.Console.WriteLine("////////////Try to get value against key////////////////");
            if (d.TryGetValue(12642000, out string name))
                System.Console.WriteLine("The city is: " + name);

            d.Remove(11290000);
            display(d);

            System.Console.WriteLine("Total count of entities" + d.Count);


        }
    }
}
