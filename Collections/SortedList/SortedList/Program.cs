using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedList
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList<int, string> employees = new SortedList<int, string>()
            {
                {102,"Scott"},
                {101,"smith"},
                {103,"allen"}
            };
            employees.Add(100, "rita");
            foreach (KeyValuePair<int, string> item in employees)
            {
                Console.WriteLine(item.Key + "  " + item.Value);

            }
            Console.WriteLine(employees[102]);
       // containsKey(key) if contains then true /false
            Console.WriteLine("Contains key 102 :"+employees.ContainsKey(102));
      // containsValue(Value) if contains then true /false
            Console.WriteLine("Contains Value Rita :" + employees.ContainsValue("Rita"));
 
      // IndexOfKey(Key) it returns the index of specified key otherwise -1
            Console.WriteLine("Index of  102 :" + employees.IndexOfKey(102));

           // employees.Remove(103);
            employees.RemoveAt(3);
   // IndexOfValue(Value) it returns the index of specified Value otherwise -1
            Console.WriteLine("Index of  Allen :" + employees.IndexOfValue("allen"));

    // Keys Property retuns all the keys without value
            Console.WriteLine("KEYS :");
            foreach (int items in employees.Keys)
            {
                Console.WriteLine(items);
            }
   // Values Property retuns all the Values without Keys
            Console.WriteLine("Values :");
            foreach (string items in employees.Values)
            {
                Console.WriteLine(items);
            }
            Console.ReadKey();
        }
    }
}
