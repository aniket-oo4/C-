using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexOutOFRange
{
    class BankAccount
    {
        public int Accountnumber { set; get; }

        public string HolderName { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount[] accounts = new BankAccount[]

            {
                new BankAccount(){HolderName="aniket",Accountnumber=1232},
                 new BankAccount(){HolderName="tejas",Accountnumber=1122},
            };

            // display all 
            for (int i = 0; i < accounts.Count(); i++)
            {
                Console.WriteLine("name::"+accounts[i].HolderName+ "  :: Number ::"+accounts[i].Accountnumber);
            }

            // the if we want to accept serial number  aka index number then
            try
            {

                Console.WriteLine("Enter index to display ::");
                int index = int.Parse(Console.ReadLine());
                Console.WriteLine("name::" + accounts[index].HolderName + "  :: Number ::" + accounts[index].Accountnumber);

            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
