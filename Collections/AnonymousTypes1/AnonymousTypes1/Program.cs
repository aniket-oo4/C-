using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousTypes1
{
    class Person
    {

        public string GetPersonName()
        {
            return "scott";
        }
        public int GetPersonAge()
        {
            return 19;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // creating  object of PErson 
            Person p=new Person();

            // calls method of Person 
            // used Anonumous type  to create a anonymous class with properties Person name and person Age
           
            //var person =new { PersonName = p.GetPersonName(), PersonAge = p.GetPersonAge() };
            var person = new { PersonName = "hello", PersonAge = 144 }; // another way to create anonymous type 
            Console.WriteLine("Person Name ::"+person.PersonName+"Person Age::"+person.PersonAge);
            Console.WriteLine(person.GetType());


// Nested anonymous type 
            var var2 = new { PersonName = "hello", PersonAge = 144, nestedAnonymous = new {city="pune",pin=414443 } }; // anonymous class within anonymous type

            Console.WriteLine("Person Name ::" + var2.PersonName + "Person Age::" + var2.PersonAge 
                +"City" +var2.nestedAnonymous.city);

//Anonymous Arrays

            var myArray = new[]
                {
                    new {name="hello",age=12},
                    new {name="ani",age=22},
                    new {name="abb",age=34},
                };
            foreach (var item in myArray)
            {
                Console.WriteLine(item.name +"::::"+item.age);
            }
            int[] a = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine("numbers whch greater than 4 is ::" + a.Count(n => n > 4));
            Console.ReadKey();

        }
    }
}
