using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
namespace EventEx
{
    class Program
    {
        static void Main(string[] args)
        {
            Subscriber sbc = new Subscriber();
            Publisher pbl = new Publisher();
            pbl.myEvent += sbc.add;
    
            pbl.autoEvent += sbc.add;
            pbl.RaiseEvent(12, 90);
        
            pbl.myEvent +=(a,b) =>{
            Console.WriteLine( a*b);
            };
            pbl.RaiseEvent(7, 8);

            Console.ReadKey();
        }
    }
}
