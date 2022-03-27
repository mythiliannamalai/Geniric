using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
namespace GeniricMethod
{
    public class Program
    {
        public void Calculation<T>(T a, T b, T c)
        {
            a = a;
            b = b;
            c = c;
            List<T> list = new List<T>();
            list.Add(a);
            list.Add(b);
            list.Add(c);
            var Max_value = list.Max();
            Console.WriteLine(Max_value);

        }
        static void Main(string[] args)
        {
            Program program = new Program();
            Console.WriteLine("Max Value of int :");
            List<int> use_int = new List<int>();
            program.Calculation(1, 2, 50);
            Console.WriteLine("\nMax value of flote :");
            List<float> list1 = new List<float>();
            program.Calculation(1.1, 2.2, 3.3);
            Console.WriteLine("\nMax value of string :");
            List<string> list = new List<string>();
            program.Calculation("sam", "naveen", "saranya");

        }
    }
}