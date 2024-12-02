using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DestructorsUsing
{
    class demo:IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine("hekoo ");
        }
        public void Display()
        {
            Console.WriteLine("Display  ");
        }

    }
    class Program
    {
        static void DoWork()
        {
            demo obj = new demo();
                obj.Display();
                Console.WriteLine("Display  ");
            }
        

        static void Main(string[] args)
        {
          DoWork();
            Console.ReadKey();
        }
    }
}
