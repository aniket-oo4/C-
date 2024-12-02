using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListMethodsToArrayForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> myList = new List<string>() {"a","B","C","D" };
            
            // ToArrayConveting list into ARray
            string[] myArray = myList.ToArray();
            foreach(var item in myArray)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("index of c::"+ myList.IndexOf("C"));
            Console.WriteLine("using ForEach method printing :");
            myList.ForEach(n => { Console.WriteLine(n); });

            List<int> Demo = new List<int>() { 1, 3, 3, 3, 3, 6, 7, 8, 9 };
            int i = 0;
            foreach (var item in Demo)
            {
                Console.WriteLine(i+":"+item);
                i++;
            }
            Console.WriteLine("Binary Search 3 :"+Demo.BinarySearch(3));
            Console.ReadKey();
        }
    }
}
