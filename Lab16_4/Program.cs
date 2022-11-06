using System;
using System.Collections.Generic;

namespace Lab16_4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Default;
            Dictionary<string, List<string>> sumijn = new Dictionary<string, List<string>>();
            sumijn.Add("a", new List<string>(new string[]{"b", "c", "e"}));
            sumijn.Add("b", new List<string>(new string[]{"a", "e", "d"}));
            sumijn.Add("c", new List<string>(new string[]{"a", "e", "f"}));
            sumijn.Add("d", new List<string>(new string[]{"b", "e", "g"}));
            sumijn.Add("e", new List<string>(new string[]{"a", "b", "d", "g", "h", "f", "c"}));
            sumijn.Add("f", new List<string>(new string[]{"c", "e", "f"}));
            sumijn.Add("h", new List<string>(new string[]{"f", "e", "g"}));
            sumijn.Add("g", new List<string>(new string[]{"h", "e", "d"}));
            Dictionary<string, List<string>> incd = new Dictionary<string, List<string>>();
            incd.Add("a", new List<string>(new string[]{"b", "c", "e"}));
            incd.Add("b", new List<string>(new string[]{"e", "d"}));
            incd.Add("c", new List<string>(new string[]{"e", "f"}));
            incd.Add("d", new List<string>(new string[]{"e"}));
            incd.Add("e", new List<string>(new string[]{"h"}));
            incd.Add("f", new List<string>(new string[]{"e", "f"}));
            incd.Add("h", new List<string>());
            incd.Add("g", new List<string>(
                new string[]{"h", "e", "d"}
            ));
            Dictionary<int, (string,string)> rebra = new Dictionary<int, (string,string)>();
            rebra.Add(1,("a", "b"));
            rebra.Add(2,("a", "e"));
            rebra.Add(3,("a", "c"));
            rebra.Add(4,("c", "e"));
            rebra.Add(5,("b", "d"));
            rebra.Add(6,("b", "e"));
            rebra.Add(7,("d", "e"));
            rebra.Add(8,("c", "f"));
            rebra.Add(9,("f", "e"));
            rebra.Add(10,("f", "h"));
            rebra.Add(11,("e", "h"));
            rebra.Add(12,("g", "h"));
            rebra.Add(13,("g", "e"));
            rebra.Add(14,("g", "d"));
            Console.WriteLine("Суміжності: ");
            foreach (var elem in sumijn)
            {
                Console.Write($"{elem.Key} (");
                foreach (var val in elem.Value)
                {
                    Console.Write($"{val} ");
                }
                Console.WriteLine(")");
            }
            Console.WriteLine("Інцидентності: "); 
            foreach (var elem in incd)
            {
                Console.Write($"{elem.Key} (");
                foreach (var val in elem.Value)
                {
                    Console.Write($"{val} ");
                }
                Console.WriteLine(")");
            }
            Console.WriteLine("Ребрами: ");
            foreach (var elem in rebra)
            {
                Console.WriteLine($"{elem.Key} {elem.Value}");
            }
        }
    }
}