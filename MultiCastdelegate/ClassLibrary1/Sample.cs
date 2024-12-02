using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Sample
    {

        public void Add(int a,int b)
        {

            Console.WriteLine("Addition is  is :" + (a +b));
        }
        // tsrgeted Methods  to store into a delegate 
        public void Multiply(int a ,int b)
        {
            Console.WriteLine("Multiplication is :"+(a*b));
        }




    }
}
