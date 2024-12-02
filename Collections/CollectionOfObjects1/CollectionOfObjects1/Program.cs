using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionOfObjects1
{
    /// <summary>
    /// this class is used for other purpose
    /// </summary>
    class Product 
    {
        
        public int P_id { set; get; }
        public String name { set; get; }
        public int price { set; get; }
        public void Dispaly()
        {
            Console.WriteLine("  Product  Id  ::"+P_id);
            Console.WriteLine("  Product  Name  ::"+name);
            Console.WriteLine("  Product  Price  ::"+price);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Empty collection
            List<Product> myList = new List<Product>();
           string choice;
           do
           {
               Console.WriteLine("Enter  Product  Id  ::");
               int id =int.Parse(Console.ReadLine());
               Console.WriteLine("Enter  Product  Name  ::");
               string  p_name= Console.ReadLine();
               Console.WriteLine("Enter  Product  Price  ::");
               int p_price = int.Parse(Console.ReadLine());
               
               Product product = new Product() { P_id = id, name = p_name, price = p_price };
               myList.Add(product);

               Console.WriteLine("\nDo you wan to Continue ::Y/N");
               choice = Console.ReadLine();
           } while (choice != "no" && choice != "No" && choice != "n" && choice != "N");

           Console.WriteLine("Products ::");
            foreach(var item in myList)
            {
                item.Dispaly();
            }
            Console.ReadKey();
        }
    }
}
