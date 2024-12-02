using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aggregations
{
    class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string Job { set; get; }
        public double Salary { set; get; }


    }
  

    class Program
    {
        static void Main(string[] args)
        {

            List<Employee> employees = new List<Employee>()  // its a data source it can be any type database xml arraylist anything incollection
            {
                new Employee(){EmpName="aniket",EmpId=6,Salary=12000,Job="SE"},
                new Employee(){EmpName="tejas",EmpId=2,Salary=9000,Job="SE"},
                new Employee(){EmpName="pranesh",EmpId=3,Salary=11900,Job="SE"},                
                new Employee(){EmpName="sahil",EmpId=4,Salary=10202,Job="SE"},
                new Employee(){EmpName="tushar",EmpId=5,Salary=4555,Job="SE"},                
                new Employee(){EmpName="ashish",EmpId=1,Salary=12000,Job="SE"},
            };


           // Min,Max,Sum,Average ,Count

            double Maximumsalary = employees.Max(n => n.Salary);
            Console.WriteLine(" Maximum  of Salary ::" + Maximumsalary);

            double Minimumsalary = employees.Min(n => n.Salary);
            Console.WriteLine(" Minimum  of Salary ::" + Minimumsalary);

            double SumOfSalarie = employees.Sum(n => n.Salary);
            Console.WriteLine(" Sum  of Salary ::" + SumOfSalarie);

            double AverageOrSalaries = employees.Average(n => n.Salary);
            Console.WriteLine("Average of Salary ::" + AverageOrSalaries);

            double cnt = employees.Count(n => n.Salary > 10000);
            Console.WriteLine("Count of employees having salary greater than 10000 :::" + cnt);

            double cntObj = employees.Count();
            Console.WriteLine("Count of objects :::" + cntObj);
            Console.ReadKey();
        }
    }
}
