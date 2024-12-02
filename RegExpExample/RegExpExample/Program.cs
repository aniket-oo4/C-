using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace RegExpExample
{
    class Program
    {
        static void Main(string[] args)
        {

            Regex regex;
            regex = new Regex("^[0-9]*$");   // checks strictly that every character is beween this renge
           //  regex = new Regex("[0-9]");   // check only startswith   use  start ^ [regex] *$ as end  
            Console.WriteLine("Enter a digit ::");
            string input = Console.ReadLine();
            Console.WriteLine( regex.IsMatch(input));
            /*
             * new Regex("[0-9]");   123132ahshsd True    ashdada232412 True
             * new Regex("[0-9]*"); unlimited digits 
             * new Regex("[0-9]*");   
             * 
             * 
             * 
             * */


            Console.ReadLine();

        }
    }
}
