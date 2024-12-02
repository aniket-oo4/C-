using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implicit_Explicit_yped_Vars
{
    class Program
    {
        static void Main(string[] args)
        {
            var demo =11.89;
            demo = 13.23;
            dynamic demo2 = "hello";
          demo2 = 12;
                Type obj = demo.GetType();
                Console.WriteLine(demo2==12);
                Console.ReadKey();
            
        }
    }
}
