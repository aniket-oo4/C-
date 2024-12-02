using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo;
namespace Asignment26
{
   
    class Program
    {
        static void Main(string[] args)
        {
            Warriour obj1 = new Warriour();
            Mage obj2 = new Mage();
            Dragon obj3 = new Dragon();

            Console.WriteLine("WAR between "+obj1.name+" VS "+obj2.name);
            while (obj1.defense != 0 & obj2.defense != 0)
            {
                obj1.Attack(obj2);
                obj2.Attack(obj1);
            }
            if (obj1.defense > 0)
            {
                Console.WriteLine(obj1.name + " Wins ");
            }
            else
            {

                Console.WriteLine(obj2.name + " Wins ");
            }
        }
    }
}
