using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuples2
{
    class Customer
    {
        // this version does not support Value tuple 
        public (int c_id,string c_name,string email) GetCustomerDetails()
        {
              return (1,"aniekt","emmail");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //tuple using Tuple class
         //   Tuple<string, int, char> obj = new Tuple<string, int, char>("aniket", 19, 'c');
           // obj.Item1 = "sunny"; // it is read only tuples are immutable 
           // Console.WriteLine(obj.Item1);

            (string ,int) t1=("hello",12); // allowed in this version 
            Console.ReadKey();
        }
    }
}
