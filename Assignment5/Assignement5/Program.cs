using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignement5
{
    class Student {
       public  int roll_no;
       public  string name;

    
    }

    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter seconds ::");
            int totalSeconds = int.Parse(Console.ReadLine());
            int minutes = totalSeconds / 60;
            int hours = minutes / 60;
            int days = hours / 24;
            int years = days / 365;
            Console.WriteLine(years+"years"+(days-(years*365))+"days"+(hours-(days*24))+"hours"+(minutes-(hours*60))+"minutes"+(totalSeconds-(minutes*60))+"seconds");
            Console.ReadKey();




        }
    }
}
