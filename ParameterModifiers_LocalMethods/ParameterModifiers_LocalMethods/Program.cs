using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParameterModifiers_LocalMethods
{
    class Program
    {
        int a;
        int add2( ref int x) {
            x = 90;
        return x+11;
        }


   
        static void Main(string[] args)
        {
            Console.WriteLine("hello ");
            Program obj = new Program();
            obj.add2(ref obj.a);
            Console.WriteLine( obj.a);
            Console.ReadKey();
        }
    }
}
