using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace StactTrace
{

    class BankAccount
    {
        public int Accountnumber { set; get; }
        private double _accountBalance;

        public double AccountBalance
        {
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("the value is in negative ${value}", "CurrentBalance ");
                }
                _accountBalance = value;

            }
            get { return _accountBalance; }

        }

        public string HolderName { get; set; }

        public void display()
        {
            Console.WriteLine("holder name ::" + this.HolderName + "\n Account number ::" + this.Accountnumber + "\n Account Balance ::" + this.AccountBalance);
        }
    }
    class FundTransfer
    {
        public void Transfer(BankAccount sourceAc, BankAccount DestinationAc, double Amount)
        {
            try
            {
                // if (Amount > sourceAc.AccountBalance)
                //     throw new InvalidOperationException(message: "Your  transfer amount is greater than current account balance");
                if (Amount > sourceAc.AccountBalance)
                    throw new InsufficientBalanceException(message: "Your  transfer amount is greater than current account balance");
                if (Amount < 0 || Amount > 10000)
                    throw new ArgumentOutOfRangeException(paramName: "Amount", actualValue: Amount, message: "value amoutn should be < 10000 and >0");

                sourceAc.AccountBalance -= Amount;
                DestinationAc.AccountBalance += Amount;
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine("inner trycatch of method");
                throw new ArgumentNullException(" you assigned null reference to DestinationAc", e);// passing message with innerException
            }
        }
    }


    // Creating ExceptionLogger class to store te exceptions that are occured during the execution 
    class ExcpetionLogger
    {
        public static void AddException(Exception ex)
        {
            string filePath = @"c:practice\Error.txt";// the path where the log can be store for developer 
            StreamWriter streamWriter = File.AppendText(filePath); //  first import System.IO  // opened filein append mode 
            streamWriter.WriteLine("Exception On :" + DateTime.Now);
            streamWriter.WriteLine(ex.GetType().ToString());// it writes the ExceptionClass name s
            streamWriter.WriteLine("\n StackTrace ::\n" + ex.StackTrace);
            streamWriter.WriteLine("\n Message::\n" + ex.Message);

            streamWriter.Close();
        }

    }

    // Custom Exception classs to handle the  excpetion 
    class InsufficientBalanceException : InvalidOperationException
    {
        public InsufficientBalanceException()
        {
        }
        public InsufficientBalanceException(string message)
            : base(message)  // passing message argument to parentclass constructor InvalidOperationExcpetion(stribg message )
        {
        }
    }

    class Program
    {
        static void Main(string[] args)
        {


            // BankAccount RobAc = new BankAccount() { HolderName = "Rob", Accountnumber = 1122, AccountBalance = 650 };

            FundTransfer api = new FundTransfer();

            // create reference variable of bank with null reference
            BankAccount steve = null;

            //  steve.display(); //A first chance exception of type 'System.NullReferenceException' occurred

            // to handle this excption lets write this code ni try catch
            try
            {
                BankAccount bobAc = new BankAccount() { HolderName = "BOB", Accountnumber = 1232, AccountBalance = 1000 };
                api.Transfer(bobAc, steve, 15000); // throw insufficient fund  Exception
                Console.WriteLine("after Transferring amount to steve as follow :");
                bobAc.display();
                steve.display();
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e.Message + "\n");// you assigned null reference to DestinationAc
                if (e != null)
                    Console.WriteLine(e.InnerException.Message);//Object reference not set to an instance of an object.                
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }

            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (InsufficientBalanceException ex)  // custom Exception 
            {
                Console.WriteLine("executing Insuffiecientt");
                Console.WriteLine(ex.Message);

                Console.WriteLine("\n\n the stacktrace  was ");
                Console.WriteLine(ex.StackTrace);
            }
            catch (InvalidOperationException ex) // it can catch any this type of exception  and its child types exceptions also 
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();

        }
    }
}
