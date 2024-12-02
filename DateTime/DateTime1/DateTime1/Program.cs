using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
namespace DateTime1
{

    class Person
    {
        public string PersonName { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.PersonName = "Miller";
            person1.DateOfBirth = DateTime.Parse("2000-12-31 11:59:59.999AM");

            Person person2 = new Person() { PersonName = "benjamin", DateOfBirth = DateTime.Parse("2003-03-25") };
            Console.WriteLine("Person ones date of birth ::"+person1.DateOfBirth.ToString());
            Console.WriteLine("Person tws Date of birth  ::" + person2.DateOfBirth.ToString());
            //
            // Shortdate and short time 
            Console.WriteLine("Person ones date of birth ::" + person1.DateOfBirth.ToShortDateString());
            Console.WriteLine("Person tws Date of birth  ::" + person1.DateOfBirth.ToShortTimeString());


            //  LongDAte and Long time 
            Console.WriteLine("Person ones date of birth ::" + person1.DateOfBirth.ToLongDateString());
            Console.WriteLine("Person tws Date of birth  ::" + person1.DateOfBirth.ToLongTimeString());
            //
            Console.WriteLine("Comparison ::"+DateTime.Compare(person2.DateOfBirth,person1.DateOfBirth));

            Console.WriteLine(DateTime.Now);
            Console.WriteLine();
            // DateTime Formating methods 
            Console.WriteLine("Date :" + person1.DateOfBirth.Date);
            Console.WriteLine("Day :"+person1.DateOfBirth.Day);
            Console.WriteLine("Month :" + person1.DateOfBirth.Month);
            Console.WriteLine("Year :" + person1.DateOfBirth.Year);
            Console.WriteLine("Hours :" + person1.DateOfBirth.Hour);
            Console.WriteLine("Minutes :" + person1.DateOfBirth.Minute);
            Console.WriteLine("Milliseconds :" + person1.DateOfBirth.Millisecond);
            Console.WriteLine("Day Of Week  :" + person1.DateOfBirth.DayOfWeek);
            Console.WriteLine("Day Of Year  :" + person1.DateOfBirth.DayOfYear);

            //static methods 
            Console.WriteLine("Day in Month  july 2024 :" + DateTime.DaysInMonth(2024,7));
            Console.WriteLine("IsLeap year  2024 :" + DateTime.IsLeapYear(2024));
/*
            DateTime NewDate = DateTime.ParseExact("31-12-2000 11:59:59 AM", "dd-MM-yyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None);

         Console.WriteLine("\n New Date is ::"+NewDate.ToString());
 * 
 * */
            // Date Substraction ::::
            DateTime today = DateTime.Now;
            DateTime dob = person1.DateOfBirth;  // comparing today with persons date of birth  


            // int CompareTo(DAteTime otherdatetime);  1 0 -1
            int result = today.CompareTo(dob);
            Console.WriteLine("Comparison is ::"+result);

            // time span 
            TimeSpan ts = today.Subtract(dob);
            Console.WriteLine("TOtal days between to dates ::"+ts.TotalDays);
            Console.WriteLine("TOtal hours between to dates ::" + ts.Hours);
            Console.WriteLine("TOtal Minutes between to dates ::" + ts.Minutes);
            Console.WriteLine("TOtal Seconds between to dates ::" + ts.Seconds);
            Console.WriteLine("TOtal Milliseconds between to dates ::" + ts.Milliseconds);
            Console.WriteLine("TOtal Ticks between to dates ::" + ts.Ticks);
            Console.WriteLine("TOtal Years and months  to dates ::" + ts.TotalDays / 365 + "  " +(ts.TotalDays- Convert.ToInt16((ts.TotalDays / 365)*365))/30+"  Months");
           



            Console.ReadKey();
        }
    }
}
