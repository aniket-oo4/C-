using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable1
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable employees = new Hashtable()
            {
                {102,"Scott"},{101,"Smith"},{103,"allen"},{"Rita",100},{'a',10.33}
            };

    //Add(key,val)
            employees.Add(104, "demoo");

            Console.WriteLine(employees['a']);

            // Printing
            Console.WriteLine("KEYS::");
            foreach (var item in employees.Keys)
            {
                Console.WriteLine(item);
            }

            // Printing
            Console.WriteLine("\nValues::");
            foreach (var item in employees.Values)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
