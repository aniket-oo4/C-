using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderBy
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
            //Console.WriteLine(employees.Where(emp=>emp.City=="pune"));   
            // using LinqQuery 
          //  var result = employees.OrderBy(emp => emp.Salary);// order by Employee salary 

            // ThenBy is used when there is same data is compared thn we need to provid option property to comparre in such case  we use ThenBy with Order by
         //   IOrderedEnumerable<Employee> result = employees.OrderBy(emp => emp.Salary).ThenBy(emp=>emp.EmpId); 

            // using OrderByDescending()
            var result = employees.OrderByDescending(emp => emp.Salary).ThenByDescending(emp => emp.EmpId); 
            foreach (var emp in result)
            {
                Console.WriteLine("\n****************************");
                Console.WriteLine("name:;:"+emp.EmpName+"\n empID::"+emp.EmpId+"\n JOB:"+emp.Job+"\n SALARY:::"+emp.Salary);
            }
            Console.ReadKey();
        }
    }
}
