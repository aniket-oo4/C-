using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    abstract class Parent
    {
        int age;
        string name;
       public static string msg = "hello";

    }
    class Program
    {
        static void Main(string[] args)
        {
            string demo=Parent.msg;
        }
    }
}
