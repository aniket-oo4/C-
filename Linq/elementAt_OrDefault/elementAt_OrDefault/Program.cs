using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elementAt_OrDefault
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
                new Employee(){EmpName="tejas",EmpId=2,Salary=9000,Job="demo"},
                new Employee(){EmpName="pranesh",EmpId=3,Salary=11900,Job="SE"},                
                new Employee(){EmpName="sahil",EmpId=4,Salary=10202,Job="mana"},
                new Employee(){EmpName="tushar",EmpId=5,Salary=4555,Job="Sss"},                
                new Employee(){EmpName="ashish",EmpId=6,Salary=12000,Job="SE"},
            };

            // ElementAt() method returns specific single element at specific index  return exception if does not found any 
            var result = employees.Where(emp => emp.Job == "SE").ElementAt(2);
            Console.WriteLine("name:;:" + result.EmpName + "\n empID::" + result.EmpId + "\n JOB:" + result.Job + "\n SALARY:::" + result.Salary);
            //  
            // to overcme such problem we use ElementAtOrdefault
            var result2 = employees.Where(emp => emp.Job == "SE").ElementAtOrDefault(3); // index starts from 0 thats why it passes null reference 
            // it return null reference then throws error null reference exception thats why it does not access the below statements
            //thats why check before accessing 
            if (result2 != null)
            {
                Console.WriteLine("name:;:" + result2.EmpName + "\n empID::" + result2.EmpId + "\n JOB:" + result2.Job + "\n SALARY:::" + result2.Salary);

            }
            else
            {
                Console.WriteLine(" hello developer reference is null");
            }

           // var result3 = employees.ElementAt(0); // only used with other queries it throws exception 
           // Console.WriteLine("name:;:" + result3.EmpName + "\n empID::" + result2.EmpId + "\n JOB:" + result2.Job + "\n SALARY:::" + result2.Salary);


            Console.ReadKey();
        }
    }
}
