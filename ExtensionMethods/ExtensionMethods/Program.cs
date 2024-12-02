using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Student obj=new Student();
            obj.AcceptDetails();
            obj.DisplayDetails(obj.id);
            Console.ReadKey();

        }
    }
}
