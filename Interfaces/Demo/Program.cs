using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    /*
    abstract class Parent
    {

        public abstract void Display();
    }

    class Child1 : Parent
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
    */
    interface  Parent
    {

          void Display();
    }

    class Child1 : Parent
    {
        public  void Display()
        {

            Console.WriteLine(" display in /child 1 ");
        }
    }

    class Child2 : Parent
    {
        public  void Display()

        {

            Console.WriteLine(" display in /child 2 ");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Parent obj = new Child1();
            obj.Display();
            obj = new Child2();
            obj.Display();
            Console.ReadKey();
        }
    }
}
