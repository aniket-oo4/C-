using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
namespace Assignment12
{
    
    class Program :ClassLibrary1.Employee
    {


        static void Main(string[] args)
        {

            Employee [] obj = new Employee[10];
           // obj[0].display(); // it throws null reference occur exception 
            obj[0] = new Employee();
            obj[0].display();
            Console.ReadKey();
        }
    }
}
