using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListMethodsSORTREVERSE
{
    class Program
    {
        static void DisplayList(List<int> myList)
        {
            for (int i = 0; i < myList.Count; i++)
            {
                Console.WriteLine(i + "::" + myList[i]);
            }
        }
        static void Main(string[] args)
        {
            List<int> myList = new List<int>() { 11, 32, 44, 2, 8, 26 };
            DisplayList(myList);
            
            //List.Sort();  Sorting the current 
            Console.WriteLine("After sorting list :");
            myList.Sort();
            DisplayList(myList);

            // List.Reverse() it reverse all the list 
            Console.WriteLine("After Reversing  list :");
            myList.Reverse();
            DisplayList(myList);

            Console.ReadKey();
        }
    }
}
