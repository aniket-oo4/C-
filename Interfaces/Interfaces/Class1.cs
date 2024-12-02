using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{

    abstract class Parent {

      public   abstract void Display();
    }

    class Child1:Parent
    {
        public override void Display()
        {

            Console.WriteLine(" display in /child 1 ");
        }
    }

    class Child2 : Parent
    {
        public override void Display()
        {

            Console.WriteLine(" display in /child 2 ");
        }
    }
    
    public class Class1
    {
        static void Main()
        {

            Parent obj = new Child1();
            obj.Display();
            obj = new Child2();
            obj.Display();
        }

    }
}
