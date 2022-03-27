using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
namespace GeniricMethod
{
    public class Program
    {
        public void Calculation<T>(T a, T b, T c,T d)
        {
            a = a;
            b = b;
            c = c;
            d = d;
            List<T> list = new List<T>();
            list.Add(a);
            list.Add(b);
            list.Add(c);
            list.Add(d);
            var Max_value = list.Max();
            Console.WriteLine(Max_value);
            
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            Console.WriteLine("Max Value of int :");
            List<int> use_int = new List<int>();
            program.Calculation(1, 2, 50,100);
            Console.WriteLine("\nMax value of flote :");
            List<float> list1 = new List<float>();
            program.Calculation(1.1, 2.2, 3.3,4.4);
            Console.WriteLine("\nMax value of string :");
            List<string> list = new List<string>();
            program.Calculation("sam", "naveen", "saranya","mythil");

        }
    }
}