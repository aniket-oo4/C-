using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomCol_IList
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

 

        public class Customer
        {
            public string name
            {
                set;
                get;
            }
        }

        public class CustomersList : IList<Customer>// custom collections 
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

            public int IndexOf(Customer item)
            {
                return customers.IndexOf(item);
            }

            public void Insert(int index, Customer item)
            {
                customers.Insert(index, item);
            }

            public void RemoveAt(int index)
            {
                customers.RemoveAt(index);
            }

            public Customer this[int index]
            {
                get
                {
                    return customers[index];
                }
                set
                {
                    customers[index] = value;
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

                Console.WriteLine(customerList.Count + " : Customers found");
                foreach (Customer customer in customerList)
                {
                    Console.WriteLine(customer.name + "  ::  ");
                }
                Console.WriteLine(customerList.Contains(new Customer() { name = "aniket" }));
                customerList.RemoveAt(0);

                Console.WriteLine(customerList.Count + " : Customers found"+customerList[0].name);
                foreach (Customer customer in customerList)
                {
                    Console.WriteLine(customer.name + "  ::  ");
                }
                Console.ReadKey();
            }
        }
    }
