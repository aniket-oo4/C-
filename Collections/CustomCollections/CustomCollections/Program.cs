using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomCollections
{

    enum myEnum
    {
        kkaka,amma,cchaha
    }
    class CustomersList : System.Collections.IEnumerable
    {
        public List<Customer> customers = new List<Customer>()
            {
                new Customer(){name="aniket",id=121},
                new Customer(){name="tejas",id=101},
                new Customer(){name="sahil",id=11}

            };
        
        public System.Collections.IEnumerator GetEnumerator()
        {
            
            yield return customers[0].name;
            yield return customers[1];
            yield return customers[2];
        }

    }
    class Customer{
        public string name{set;get;}
        public int id{set;get;}
    }
    class Program
    {
        static void Main(string[] args)
        {
            CustomersList customersList = new CustomersList();
            System.Collections.IEnumerator enumerator = customersList.GetEnumerator();
            enumerator.MoveNext();
            Console.WriteLine(enumerator.Current);
            enumerator.MoveNext();
            Console.WriteLine(enumerator.Current);
            enumerator.MoveNext();
            Console.WriteLine(enumerator.Current);

            // we can write all this into foreach 
            foreach (var cs in customersList)
            {
                Console.WriteLine( cs);
            }


            Console.ReadKey();
        }
    }
}
