using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuples1
{
    class Person
    {
        public Tuple<int, string> GetDetails()
        {
            Tuple<int, string> myTuple = new Tuple<int, string>(20, "aniket");
            return myTuple;
            // we can also return this as using Tuple.Create<> method 
            return Tuple.Create(12,"anike");
            

        }
    }

    class Program
    {


        static void Main(string[] args)
        {

            // tuppl that stores person details 
            Tuple<string,int,char> obj = new Tuple<string,int,char>("aniket",19,'c');

           //obj.Item1 = "ani";// tuples are  immutable Propperties cannot be changed  



            //accessing values from tuple 
            Console.WriteLine(  "name::"+obj.Item1);
            Console.WriteLine("Age::" + obj.Item2);
            Console.WriteLine("char::" + obj.Item3);
            Console.WriteLine("***************************");
            Person person = new Person();
            Console.WriteLine("Age::" + person.GetDetails().Item1);
            Console.WriteLine("name::" + person.GetDetails().Item2); 
            Console.ReadKey();
        }
    }
}
