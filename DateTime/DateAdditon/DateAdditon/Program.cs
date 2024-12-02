using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateAdditon
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime today = DateTime.Now;

            DateTime demo = today.AddDays(10);
            Console.WriteLine("DAys Before adding :" + today.ToString()); //05-07-2024 17:53:46
            Console.WriteLine("DAys after adding :" + demo.ToString());   // 15-07-2024 17:53:46
            demo = today.AddDays(-5);
            Console.WriteLine("DAys after adding :" + demo.ToString());   // 15-07-2024 17:53:46
            Console.ReadKey();

        }
    }
}
