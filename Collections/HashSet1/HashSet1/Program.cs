using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashSet1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating object of HashSet Class
            HashSet<string> Messages=new HashSet<string>();// empty hashset
            Messages=new HashSet<string>()
            {
                "good mornign ",
                "Hello world ",
                "Ram Ram"
            };

            Messages.Add("GoodLuck");
           // Messages.Remove("good mornign ");
            Messages.RemoveWhere(n => n.StartsWith("good")); // condition is true then  remove 
            Console.WriteLine("cCount:: " + Messages.Count);
            foreach(var msg in Messages)
            {
                Console.WriteLine(msg);
            }


            Console.WriteLine("  has set contains r not ::"+Messages.Contains("Ram Ram"));
            Console.ReadKey();
        }
    }

}

