using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListMethodRemoves
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> myList= new List<int>() { 12, 33, 44, 22 };



            Console.WriteLine("using foreach loop  before removing " + myList.Count);// reading out put from list using foreach loop 
            for (int i = 0; i < myList.Count; i++)
            {
                Console.WriteLine(i + " ::" + myList[i]);
            }

            myList.Remove(33);// remove  methods removes specific element from the Collection 

            Console.WriteLine("After  removing "+myList.Count);
            for (int i = 0; i < myList.Count;i++ )
            {
                Console.WriteLine(i+" ::"+myList[i]);
            }
            Console.WriteLine(myList.Remove(33));  // returns false if not found such element 

        // RemoveAt(index);
            myList.RemoveAt(2);
            Console.WriteLine("After  removing using RemoveAt() :" + myList.Count);
            for (int i = 0; i < myList.Count; i++)
            {
                Console.WriteLine(i + " ::" + myList[i]);
            }
  

            //*****************************
            myList.InsertRange(1, new List<int>() { 99, 44, 55, 33 });
            Console.WriteLine("before   removing  range :" + myList.Count);
            for (int i = 0; i < myList.Count; i++)
            {
                Console.WriteLine(i + " ::" + myList[i]);
            }


            // removing whole range using remove range methods
          //  myList.RemoveRange(2, 3);

            // RemoveAll(n=>(boolean expression))
            // RemoveAll(n=>n<30); 
            myList.RemoveAll(n => n < 50);
            Console.WriteLine("After  removing  RemoveAll() which are small than 50 :" + myList.Count);
            for (int i = 0; i < myList.Count; i++)
            {
                Console.WriteLine(i + " ::" + myList[i]);
            }
            

            // list.clear() this method clears all the elements  from the list wthout any condition 
            myList.Clear();
            Console.WriteLine("After  using Clear():" + myList.Count);
            Console.ReadKey();
        }
    }
}
