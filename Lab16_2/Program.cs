using System;
using System.IO.Compression;

namespace Lab16_2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var list = new Deque<int>();
            bool flag = true;
            while (flag) {
                Console.WriteLine("Enter required action: \n" +
                                  "1-Push Front\n2-Push Back\n3-Pop Front\n" +
                                  "4-Pop back\n5-Front\n6Back\n7-Size\n8-Clear\n9-Show\n10-Exit");
                string act = Console.ReadLine().Trim();
                switch (act)
                {
                    case "1":
                        list.pushFront(Int32.Parse(Console.ReadLine()));
                        break;
                    case "2":
                        list.pushBack(Int32.Parse(Console.ReadLine()));
                        break;
                    case "3":
                        Console.WriteLine(list.PopFront());
                        break;
                    case "4":
                        Console.WriteLine(list.PopBack());
                        break;
                    case "5":
                        Console.WriteLine(list.Front);
                        break;
                    case "6":
                        Console.WriteLine(list.Back);
                        break;
                    case "7":
                        Console.WriteLine(list.Size);
                        break;
                    case "8":
                        list.Clear();
                        break;
                    case "9":
                        list.Show();
                        break;
                    case "10":
                        flag = false;
                        break;
                }

            }
        }
    }
}