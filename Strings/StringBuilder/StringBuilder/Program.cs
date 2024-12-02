using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace StringBuilderss
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder str = new StringBuilder("hello");
            Console.WriteLine("Capaciy of string builder is ::"+str.Capacity);
            Console.ReadKey();
        }
    }
}
