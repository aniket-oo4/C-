using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String1
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            string str = "hello world";
            int len = str.Length;
            string demo = str;
         
             Console.WriteLine("Original ::"+str);

            // converting string 
            // ToUpper
            str = str.ToUpper(); // internally creates new object of string and assignes it does not change existing string
            Console.WriteLine(str);

            // ToLower
            str = str.ToLower(); // internally creates new object of string and assignes it does not change existing string
            Console.WriteLine(str);

            // returns substrings fron start index to countof ho many characters 
            //substring(int start)
          //  str = str.Substring(5);
          //  Console.WriteLine("Substring ::"+str);
          //  str = str.Substring(5,3);
           // Console.WriteLine("Substring ::" + str);

            // Replace method  subsitute old string to new string 
             str = str.Replace("world","aniket");
             Console.WriteLine("Replaced string  ::" + str);

            // Split (char separator) this method splts the string from the separator character into new string array 
           //  string[] arr = str.Split(' ');
         //    Console.WriteLine("Separated array as folows :");
           //  foreach (var item in arr)
           //  {
            //     Console.WriteLine(item);
          //   }


            //Trim() it removes unneccesary extra spaces from left side and right side  but  removes the spaces at middle of the string 

             string message = "   message   ";
             Console.WriteLine("before triming spaces ::"+message);
             message=message.Trim();
            Console.WriteLine("After triming spaces ::"+message);
            Console.WriteLine( "\nafter converting string into character array ::");
            char[] mycharArray = str.ToCharArray();
           foreach (var item in mycharArray)
            {
               Console.WriteLine(item);
           }

            //string.Join(string separator,string array); this method joins the array of string into a single string  separeded by separator 
           string joinedstring = string.Join("_", mycharArray);
           Console.WriteLine("ARray to string conversion::"+joinedstring);
            
             */

            // Checking methods in string 

            string str="Universe";
            string str2="Universe";
            bool eq = str.Equals(str2);
            // or we can also do as
            eq = str == str2;
            Console.WriteLine("Comparison is ::"+eq);

            // StartsWith(string val) // checks whether string  is starts with value or not 
            bool sw = str.StartsWith("un");
            Console.WriteLine("Does it starts with Un or not ::"+sw);

            // EndsWith(string val) // checks whether string  is EndsWith value or not 
            bool ew = str.EndsWith("e");
            Console.WriteLine("Does it EndsWith Un or not ::" + ew);


            //Contains  // checks whether specific string is found in string or not 
            string demo = "helAlo bhava";
            bool result = demo.Contains("hello");
            Console.WriteLine("Does hello contains in \""+demo+"\" or  not ::"+result);


            //int IndexOf(string value) checks the first index of specified value is found in string or not if not returns -1 
            int index = demo.IndexOf("l");
            Console.WriteLine("Index of l in :"+demo+ " is :: "+index); //3
            Console.WriteLine("Index of 000 in :" + demo + " is :: " + demo.IndexOf("000")); //-1
                                                                    //startIndex   
            Console.WriteLine("Second occurence of l is ::"+demo.IndexOf("l",demo.IndexOf("l")+1));// 4 // second occurence =indexOf(val,previousindex+1);


            Console.WriteLine("\nLAst Index of ::\n");
            //int LastIndexOf(string value) checks the  Last index of specified value is found in string or not if not returns -1 
            int Lastindex = demo.LastIndexOf("l");
            Console.WriteLine(" LAstIndex of l in :" + demo + " is :: " + Lastindex); //3
            Console.WriteLine(" LASt Index of 000 in :" + demo + " is :: " + demo.LastIndexOf("000")); //-1
            //startIndex   
            Console.WriteLine("Second LAst occurence of l is ::" + demo.LastIndexOf("l", demo.LastIndexOf("l") - 1));// 4 // second occurence =indexOf(val,previousindex-1);


            //IsNullOrEmpty(string values)//return true is string is empty/null otherwise false 
            Console.WriteLine("IsNullOrEmpty:::"+string.IsNullOrEmpty(null));
            Console.WriteLine("IsNullOrEmpty:::" + string.IsNullOrEmpty(""));
            Console.WriteLine("IsNullOrEmpty:::" + string.IsNullOrWhiteSpace("    "));




            // string Formatting 

            string director = "rajamouli";
            string movie = "Bauhbali";
            Console.WriteLine(string.Format("The Dirrector of movie {0} is {1}",movie,director  ) );


            // modifying strings 
            //Insert(index,string value)  // inserts the specified string into the string 
            string mystr = "Developer";
            mystr=mystr.Insert(4, "sad");
            Console.WriteLine("Insered string ::"+mystr);


            // remove(int startindex,int count) // this method removes specified  string from string 
            mystr = mystr.Remove(2,2);
            Console.WriteLine("Removed string ::" + mystr);
             Console.ReadKey();


        }
    }
}
