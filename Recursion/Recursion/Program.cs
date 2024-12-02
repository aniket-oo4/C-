using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    class Program
    {

        static int Factorial(int num)
        {
          if(num>1){
              return num*Factorial(num-1);
            }
          else
	        {
              return 1;
	        }

        return num;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Factorial of 5 :"+Factorial(5));
            Console.ReadKey();
        }
    }
}
