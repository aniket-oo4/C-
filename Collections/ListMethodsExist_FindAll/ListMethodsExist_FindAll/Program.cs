using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListMethodsExist_FindAll
{
    class Program
    {
        static void  DisplayList(List<int> obj)
        {
            for(int i=0;i<obj.Count;i++)
            {
                Console.WriteLine(i + "::" + obj[i]);
            }
        }
        static void Main(string[] args)
        {
            List<int> myList = new List<int>() { 10,20,30,40,50};

            // using Exists(Predicate)
            Console.WriteLine(myList.Exists(n=>n<11)); // True 
            Console.WriteLine(myList.Exists(n => n < 10)); // false 

            List<int> marks = new List<int>() { 56, 38,24,16, 32, 40, 50 };
            DisplayList(marks);
            if(marks.Exists(n=>n<35))
            {
                Console.WriteLine("Student is Failed ");
            }
            else{
                Console.WriteLine("Student is PAssed ");
            }

       //Find(Predicate<T>) it returns first matching element

            Console.WriteLine("first Failed subject marks is :"+marks.Find(n=>n<35));
            Console.WriteLine("which subject has 110+ marks  :" + marks.Find(n => n> 100));

       //FindIndex(Predicate<T>) t return the index of element that matches the condition 
            Console.WriteLine("first Failed subject index is :" + marks.FindIndex(n => n < 35));


      // FindLAst(Predicate<T>) it  same as find but it searches from last to start it return last element that matches the condition 
            Console.WriteLine("Last value smaller than 40  is :" + marks.FindLast(n => n < 40));

      //FindLatIndex(Predicate<T>) t return the Last index of element that matches the condition 
            Console.WriteLine("Last index smaller than 40  is :" + marks.FindLastIndex(n => n < 40));

       // List<T> FindAll(Predicate<T>) it returns new collection which cintains the lements that matches following condition in oredicate 
            List<int> allFailedList = marks.FindAll(n => n < 35);
            Console.WriteLine("\nAll Failed marks are ");
            DisplayList(allFailedList);
         

      // ConvertAll()this method converts all the elements of Collection into other datatypes 
            Console.WriteLine("\n Converted whole ist into strirng ");
            List<string> MyStr = myList.ConvertAll(n => Convert.ToString(n));// converted integer elements into  string 
            for (int i = 0; i < MyStr.Count; i++)
            {
                Console.WriteLine(i + "::" + MyStr[i]);
            }

            Console.ReadKey();
        }
    }
}
