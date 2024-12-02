using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a, b;
                Console.WriteLine("enter first number ::");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("enter second number ::");
                b = int.Parse(Console.ReadLine());

                Console.WriteLine(a + " /" + b + "  is::" + a / b);

            }
          //  catch(DivideByZeroException) // or also
           catch(DivideByZeroException ex)// this is used when try bloc throw something or not alo
            {
                Console.WriteLine("CatchBlock :"+ex.Message);
            }
            finally
            {
                Console.WriteLine("Hello Finally");
            }
            Console.ReadKey();
        }
    }
}
