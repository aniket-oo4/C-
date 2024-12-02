using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo;
namespace PartialClass
{

    static class MyStatic
    {

       public static int a = 90;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Product obj = new Product();
            obj.Productid=90;
            obj.Display();
            obj.Call();
            MyStatic.a = 00;
            Console.ReadKey();

        }
    }
}
