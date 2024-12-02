using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
namespace ConstructorsExample
{
    class Program
    {
        static void Main(string[] args)
        {

            Car obj = new Car(1,"swift",22);
            obj.display();
            Console.ReadKey();
        }
    }
}
