using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomC_ICollection
{

  public   class Customer
    {
       public string name
        {
            set;
            get;
        }
    }

    public class CustomersList : ICollection<Customer>// custom collections 
    {

          

        private List<Customer> customers = new List<Customer>();


     

        public void Add(Customer item)
        {
            customers.Add(item);
        }

        public void Clear()
        {
            customers.Clear();
        }

        public bool Contains(Customer item)
        {
            return customers.Contains(item);
        }

        public void CopyTo(Customer[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public int Count
        {
            get { return customers.Count; }
        }

        public bool IsReadOnly
        {
            get { throw new NotImplementedException(); }
        }

        public bool Remove(Customer item)
        {
            return customers.Remove(item);
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            //yield return new Customer();

            for (int i = 0; i < customers.Count; i++)
            {
                yield return customers[i]; // this statement returns and pause 
            }
        }

        IEnumerator<Customer> IEnumerable<Customer>.GetEnumerator()
        {
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
            CustomersList customerList = new CustomersList()
                {
                    new Customer(){name="aniket"},
                     new Customer(){name="tejas"},
                      new Customer(){name="sahil"},
                       new Customer(){name="tushar"},

                };

            Console.WriteLine(customerList.Count+" : Customers found");
            foreach (Customer customer in customerList)
            {
                Console.WriteLine(customer.name + "  ::  ");
            }
            Console.WriteLine(customerList.Contains(new Customer() { name = "aniket" }));
            Console.ReadKey();
        }
    }
}
