using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            object obj = 10;
            string str = (string)obj; //An unhandled exception of type 'System.InvalidCastException' occurred in Unboxing.exe

//Additional information: Unable to cast object of type 'System.Int32' to type 'System.String'.
            Console.ReadKey();
        }
    }
}
