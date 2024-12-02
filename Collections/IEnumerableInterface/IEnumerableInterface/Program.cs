using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            // craete collction
            IEnumerable<string> myList = new List<string>() { "anke","tekas"};

         //   myList.Add();// unable to access methods of List  we can only access methods of IEnumerable interface 
            foreach(string item in myList)

            {
                Console.WriteLine(item);
            }

            IEnumerator<string> enumerator = myList.GetEnumerator();
            enumerator.Reset();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
            Console.ReadKey();

        }
    }
}
