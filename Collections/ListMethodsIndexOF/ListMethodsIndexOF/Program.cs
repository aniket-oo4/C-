using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListMethodsIndexOF
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> myList = new List<int>() { 12, 34, 55, 22, 55 };


            //IndexOf(T, int startIndex 
            Console.WriteLine("index of 22 is::"+myList.IndexOf(22));
            Console.WriteLine("index of 44 is::" + myList.IndexOf(44)); // not found return -1

            Console.WriteLine("index of 22 is::" + myList.IndexOf(55,3)); // searching using index of with starting index finding second occurence s

            // BinarySearch(T Vlaue);
            myList.Clear();
            myList = new List<int>() {1,2,3,4,5,6,7,8,12,22,33,44,55,56};
            Console.WriteLine("index of 55  usinf BinarySearch is::" + myList.BinarySearch(55));

            //Contains() method
            if (myList.Contains(11))
                Console.WriteLine("Vaues is found" + myList.Contains(11));
            else
                Console.WriteLine("Vaues is  Not found ::" + myList.Contains(11));

            Console.ReadKey();
        }
    }
}
