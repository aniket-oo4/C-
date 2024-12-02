﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnerExceptions
{
    class BankAccount
    {
        public int Accountnumber { set; get; }
        public double AccountBalance { set; get; }
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
                sourceAc.AccountBalance -= Amount;
                DestinationAc.AccountBalance += Amount;
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine("inner trycatch of method");
                throw new ArgumentNullException(" you assigned null reference to DestinationAc",e);// passing message with innerException
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            BankAccount bobAc = new BankAccount() { HolderName = "BOB", Accountnumber = 1232, AccountBalance = 1000 };
            BankAccount RobAc = new BankAccount() { HolderName = "Rob", Accountnumber = 1122, AccountBalance = 650 };
            FundTransfer api = new FundTransfer();


            // Console.WriteLine("Before Transferring accounts as follow :");
            // bobAc.display();
            //  RobAc.display();
            // call transfer method 
            api.Transfer(bobAc, RobAc, 350);
            // Console.WriteLine("\nAfter  Transferring accounts as follow :");
            // bobAc.display();
            //RobAc.display();


            // create reference variable of bank with null reference
            BankAccount steve = null;


            //  steve.display(); //A first chance exception of type 'System.NullReferenceException' occurred

            // to handle this excption lets write this code ni try catch
            try
            {
                api.Transfer(bobAc, steve, 900); // throw nullReference Exception
                Console.WriteLine("after Transferring amount to steve as follow :");
                bobAc.display();
                steve.display();
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e.Message + "\n");// you assigned null reference to DestinationAc
                Console.WriteLine(e.InnerException.Message);//Object reference not set to an instance of an object.
            }
            Console.ReadKey();

        }
    }
}