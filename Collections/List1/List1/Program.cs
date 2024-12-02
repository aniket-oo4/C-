using System;
using System.Collections.Generic;


namespace List1
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> myList;  // creating reference varibale of list 
         //  myList= new List<int>(); // creaing object of List 
            myList=new List<int>(){12,33,44,22};



            Console.WriteLine("using foreach loop ");// reading out put from list using foreach loop 
            foreach (int item in myList)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine("using for loop ");   //or using for loop 
            for (int i = 0; i < myList.Count; i++)
            {
                Console.WriteLine(myList[i]);
            }

            List<int> myList2 = new List<int>(10) { 11,121,314,2};  //  in brackets we assigned capacity oarameter 
            myList2.Add(0110); // Add metho adds single element to existing list 


            // AddRange(IEnumerable <t> )
            Console.WriteLine("added full rane or another collection into existing one  ");  
            myList.AddRange(myList2);
            for (int i = 0; i < myList.Count; i++)
            {
                Console.WriteLine(i+" :: "+myList[i]);

            }

            // List.Insert (int index ,value);
            myList.Insert(3, 7888);
            Console.WriteLine("AFter inserting   ");  
            for (int i = 0; i < myList.Count; i++)
            {
                Console.WriteLine(i + " :: " + myList[i]);

            }
            // List.InsertRange (int index ,Ienumerable<T> new value );
            myList.InsertRange(4, new List<int>() { 00,001,002,003});
            Console.WriteLine("AFter inserting  Range ");
            for (int i = 0; i < myList.Count; i++)
            {
                Console.WriteLine(i + " :: " + myList[i]);

            }
            Console.ReadKey();
        }
    }
}
