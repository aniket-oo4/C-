using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary1
{
    class Program
    {
        static void Main(string[] args)
        {
            // creating Dictionary 
            Dictionary<int, string>employees = new Dictionary<int, string>() {
            {101,"Scott"},
            {102,"Smith"},
            {103,"Allen"},
            };

            foreach (KeyValuePair<int,string> item in employees) //  foreach (var item in employees)
            {
                Console.WriteLine(item.Key + " :" + item.Value);  // using properties of
            }

     // Dict.Keys // returns all the keys within dictionary 
            Dictionary<int, string>.KeyCollection key = employees.Keys;
            foreach (var item in key)
            {
                Console.WriteLine(item);
            }

    // Dict.Remove(Key) this method deletes the specified key and also its  value pair from dictionary 
          Console.WriteLine( "After removing employee 102:"+ employees.Remove(102));
          foreach (KeyValuePair<int, string> item in employees) //  foreach (var item in employees)
          {
              Console.WriteLine(item.Key + " :" + item.Value);  // using properties of
          }

   // Dict.Add(key,Value)
          Console.WriteLine("\nafter adding the new pair ");
          employees.Add(104, "gotya");
          foreach (KeyValuePair<int, string> item in employees)
          {
              Console.WriteLine(item.Key + " :" + item.Value);  // using properties of
          }
   // Dict.ContainsKey(Key) it checks for does the specific key is present or not in dictionary 
          Console.WriteLine("\nContains Key 102:" + employees.ContainsKey(102)); // it return false because we already removed this pair


            Console.ReadKey();
        }
    }
}
