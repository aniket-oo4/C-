using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceIneritance
{
   public interface Interface1
    {

         void Show();
    }
   public interface Interface2 : Interface1
    {
         void Show();
    }
    class ChildClass : Interface1, Interface2
    {
         void Interface1.Show()
        {
            Console.WriteLine("hello world // Interface 1 Show method this ethod is not accessiobe by class reference ");
        }
         void Interface2.Show()
        {

            Console.WriteLine("Show method of Interface2 accessible from object of class ");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Interface1 obj = new ChildClass();
          //  obj.Display();
            obj.Show();
            ChildClass obj1 = new ChildClass();
            //obj1.Show(); gives error because interface is explicitly imlememnted 
            Interface2 obj3 = new ChildClass();
            obj3.Show();
            Console.ReadKey();
        }
    }
}
