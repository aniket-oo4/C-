using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterators1
{
    class Program
    {
        public IEnumerable<int> myMethod()
        {
            Console.WriteLine("iteratoremthod executes ::");
            yield return 12;
            // paused 
            Console.WriteLine("iteratoremthod continued ::"); // if called movenext method 
            yield return 34;
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            var enumerable1= obj.myMethod();
            var enumerator1 = enumerable1.GetEnumerator();
            enumerator1.MoveNext();// started the execution of iterator 
            Console.WriteLine(enumerator1.Current); // return 12
            // metohdd paused 

            enumerator1.MoveNext();// continued  the execution of iterator 
            Console.WriteLine(enumerator1.Current); // return 34

            foreach(var item in enumerable1)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
