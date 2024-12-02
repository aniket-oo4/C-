using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashSet2
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> employees21 = new HashSet<string>() {"Amar ","akbar","anthony" };
            HashSet<string> employee22 = new HashSet<string>() { "Scott ", "Robert", "MAhaabli","tatya" };

            Console.WriteLine("Before uion:: ");
            foreach(var item   in employees21)
            {
                Console.WriteLine(item);
            }
            // union of two sets 
            employees21.UnionWith(employee22);
            Console.WriteLine("After uion:: ");
            foreach (var item in employees21)
            {
                Console.WriteLine(item);
            }


            // InterSection 
            HashSet<string> employees2021 = new HashSet<string>() { "Amar ", "akbar", "anthony" };
            HashSet<string> employee2022 = new HashSet<string>() { "Scott ", "Robert", "MAhaabli", "Amar ", "akbar", "tatya" };
            employees2021.IntersectWith(employee2022);
            Console.WriteLine("\nAfter intersection :: ");
            foreach (var item in employees2021)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
