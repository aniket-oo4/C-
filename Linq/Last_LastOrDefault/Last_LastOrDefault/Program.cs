using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Last_LastOrDefault
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
                new Employee(){EmpName="aniket",EmpId=1,Salary=12000,Job="SE"},
                new Employee(){EmpName="tejas",EmpId=2,Salary=9000,Job="SE"},
                new Employee(){EmpName="pranesh",EmpId=3,Salary=11900,Job="SE"},                
                new Employee(){EmpName="sahil",EmpId=4,Salary=10202,Job="SE"},
                new Employee(){EmpName="tushar",EmpId=5,Salary=4555,Job="SE"},                
                new Employee(){EmpName="ashish",EmpId=6,Salary=12000,Job="SE"},
            };

            // Last ()  used for geting Last element that matches specific condition 
            var result = employees.Last(emp => emp.Job == "SE");
            Console.WriteLine("name:;:" + result.EmpName + "\n empID::" + result.EmpId + "\n JOB:" + result.Job + "\n SALARY:::" + result.Salary);
            // Last method returns exception if there is no matching element for such condition 
            // to overcme such problem we use LastOrDefault () method 
            var result2 = employees.LastOrDefault(emp => emp.Job=="SsE");
            // it return null reference it throws error nul reference exception thats why it does not access the below statements

            if (result2 != null)
            {
                Console.WriteLine("name:;:" + result2.EmpName + "\n empID::" + result2.EmpId + "\n JOB:" + result2.Job + "\n SALARY:::" + result2.Salary);

            }
            else
            {
                Console.WriteLine(" hello developer reference is null");
            }


            Console.ReadKey();
        }
    }
}
