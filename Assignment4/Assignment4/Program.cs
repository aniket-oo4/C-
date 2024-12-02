using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class Program
    {
        static void Main(string[] args)
        {

            string input;
            int num,temp=0;
            Console.WriteLine("Enter your number ");
            input = Console.ReadLine();
            if (input.Length > 3)
            {
                 num = Convert.ToInt32(input);

                for(int i=0;i<3;i++){

                    temp = temp *10+num%10;
                    num /= 10;
                    
                }

            }
            Console.WriteLine(temp);
            int rev=0;
            while (temp !=0)
            {
                rev = rev * 10 + temp % 10;
                temp /= 10;
            }
            Console.WriteLine(rev);
            Console.ReadKey();

        }
    }
}
