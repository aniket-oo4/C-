using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
namespace ExtensionMethods
{
    static class Demo
    {
        public static void AcceptDetails(this Student obj)
        {
            Console.WriteLine("Enter Id Of Student :");
            obj.id = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter NAme Of Student :");
            obj.Name = Console.ReadLine();

        }
        public static void DisplayDetails(this Student obj,int a)
        {
            
            Console.WriteLine(" Id Of Student :"+a);
       
            Console.WriteLine("Enter Name Of Student :"+obj.Name);

        }
    }
}
