using System;
using System.IO;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Text;
using System.Xml;

namespace Lab16
{
    internal class Program
    {
        public static void InputFunc()
        {
            string path = "task1.txt";
            var writer = new StreamWriter(path, false, Encoding.UTF8);
            string expression = "(2*b)/(5*a)-(4-a)*(a+b)";
            writer.WriteLine(expression);
            writer.Close();
        }
        
        public static string Read()
        {
            string path = "task1.txt";
            var reader = new StreamReader(path);
            string content = reader.ReadToEnd();
            reader.Close();
            return content;
        }
        public static void Main(string[] args)
        {
            InputFunc();
            string content = Read();
            var stack = new CustomStack();
            foreach (var c in content)
            {
                if (c == '(')
                {
                    stack.Append(c);
                }
                else if (c == ')')
                {
                    stack.Pop();
                }
            }

            string res = stack.Size == 0? "There is the same quantity of '(' and ')'":
                "There is NOT the same quantity of '(' and ')'";
            Console.WriteLine(res);

        }
    }
}