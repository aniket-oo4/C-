using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Select_
{
    class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string Job { set; get; }
        public double Salary { set; get; }


    }
    class RegisteredEmployee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
       
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


       //     IEnumerable<RegisteredEmployee> result = employees.Select(emp => new RegisteredEmployee() {EmpName=emp.EmpName,EmpId=emp.EmpId,Salary=emp.Salary }
       //         ).ToList();
  // or 
            List<RegisteredEmployee> result = employees.Select(emp => new RegisteredEmployee() { EmpName = emp.EmpName, EmpId = emp.EmpId, Salary = emp.Salary }
       ).OrderBy(n => n.EmpId).ToList();

            foreach (var item in result)
            {
                Console.WriteLine("name:;:" + item.EmpName + "\n empID::" + item.EmpId +  "\n SALARY:::" + item.Salary);
            }
         
           
           


            Console.ReadKey();
        }
    }
}
