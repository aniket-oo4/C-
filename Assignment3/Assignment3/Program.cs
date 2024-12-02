using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {

            int inch,feet,total_inches;
            Console.WriteLine("Enter feets :");
           feet= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter inches :");
           inch= Convert.ToInt32(Console.ReadLine());
            total_inches  = inch+feet*12;
            Console.Write("Total number of centimeters = "+(total_inches*2.54)+"cm");

            Console.ReadKey();
        }
    }
}
