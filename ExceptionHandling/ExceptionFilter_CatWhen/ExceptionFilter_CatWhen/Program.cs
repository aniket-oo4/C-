using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionFilter_CatWhen
{



    class Program
    {

        static void transferMoney(ref int a, ref int b,int amount)
        {

            try
            {
                if (amount < 0 || amount > a)
                    throw new ArgumentOutOfRangeException();
                else
                {
                    a -= amount;
                    b += amount;
                }
            }
            catch(ArgumentOutOfRangeException e) //when  (amount<0) //not supported by this version 
            {
                throw new  ArgumentOutOfRangeException("the amount is negative",e);
            }
        }
        static void Main(string[] args)
        {

            try
            {


                int rok = 900, bob = 123, amount;
                transferMoney(ref rok, ref bob, -12);

            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine((e.Message)+e.InnerException);
            }

            Console.ReadKey();
        }
    }
}
