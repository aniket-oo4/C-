using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StaticClasses;
namespace StaticClasses
{
    static partial class Parent
    {
      public static  int Demo=900;

      public static string Demo2 { get; set; }
    }

    class Program
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine(Parent.Demo);
            Console.WriteLine(Parent.Demo2);
        }
    }
}
