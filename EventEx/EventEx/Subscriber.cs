using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
namespace EventEx
{
    class Subscriber
    {
        //target method for storing itno delegate 
        public void add(int a, int b)
        {
            Console.WriteLine("Addiitjiion:" + (a + b));
        }
    }
}
