using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormatException1
{
    class BankAccounts
    {
        public string AccountHolderName { get; set; }
        public int AccountNumber { get; set; }
        public double CurrenBalance { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            BankAccounts obj = new BankAccounts();

            try
            {


                Console.WriteLine("Enter account holder name ::");
                obj.AccountHolderName = Console.ReadLine();
                Console.WriteLine("Enter account Number::");
                obj.AccountNumber = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Curent Balance ::");
                obj.CurrenBalance = double.Parse(Console.ReadLine());
               
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            // display 
            Console.WriteLine("name ::"+obj.AccountHolderName);

            Console.WriteLine("AccountNumber ::" + obj.AccountNumber);
            Console.WriteLine("CurrenBalance ::" + obj.CurrenBalance);
            Console.ReadLine();
        }
    }
}
