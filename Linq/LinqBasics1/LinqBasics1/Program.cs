using System;
using System.Collections.Generic;
using System.Linq;


namespace LinqBasics1
{
    class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string Job { set; get; }
        public string City { set; get; }


    }

    class Program
    {
        static void Main(string[] args)
        {

            List<Employee> employees = new List<Employee>()  // its a data source it can be any type database xml arraylist anything incollection
            {
                new Employee(){EmpName="aniket",EmpId=1,City="pune",Job="SE"},
                new Employee(){EmpName="tejas",EmpId=2,City="nasik",Job="SE"},
                new Employee(){EmpName="pranesh",EmpId=3,City="pune",Job="SE"},                
                new Employee(){EmpName="sahil",EmpId=4,City="mumbai",Job="SE"},
                new Employee(){EmpName="tushar",EmpId=5,City="pune",Job="SE"},                
                new Employee(){EmpName="ashish",EmpId=6,City="delhi",Job="SE"},
            };
            //Console.WriteLine(employees.Where(emp=>emp.City=="pune"));   
            // using LinqQuery 
           var result= employees.Where(emp=>emp.City=="pune");
           foreach (var item in result)
           {
               Console.WriteLine("name::"+item.EmpName+"City::"+item.City);
           }
            Console.ReadKey();
        }
    }
}
