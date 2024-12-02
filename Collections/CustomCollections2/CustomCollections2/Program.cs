using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomCollections2
{

    class Customer
    {
        string name{set;get;
        }
    }

    public class CustomersList :IEnumerable<Customer>// custom collections 
    {

        private List<Customer> customers = new List<Customer>();

 
        public IEnumerator<Customer> GetEnumerator()
        {
            //yield return new Customer();

            for (int i = 0; i < customers.Count; i++)
            {
                yield return customers[i]; // this statement returns and pause 
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {


        }
    }
}
