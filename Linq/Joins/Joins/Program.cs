using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joins
{
    class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string Job { set; get; }
        public double Salary { set; get; }
        public int DptId { get; set; }

    }

    class Department
    {
        public string DptName { get; set; }
        public int DparmenttId { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {

            List<Employee> employees = new List<Employee>()  // its a data source it can be any type database xml arraylist anything incollection
            {
                new Employee(){EmpName="aniket",EmpId=6,Salary=12000,Job="SE",DptId=1},
                new Employee(){EmpName="tejas",EmpId=2,Salary=9000,Job="SE",DptId=5},
                new Employee(){EmpName="pranesh",EmpId=3,Salary=11900,Job="SE",DptId=1},                
                new Employee(){EmpName="sahil",EmpId=4,Salary=10202,Job="SE",DptId=3},
                new Employee(){EmpName="tushar",EmpId=5,Salary=4555,Job="SE",DptId=4},                
                new Employee(){EmpName="ashish",EmpId=1,Salary=12000,Job="SE",DptId=2},
            };

            // performing Join a
           List< Department> depatments=new List<Department>()
            {
                new Department(){ DptName="Development",DparmenttId=1},
                new Department(){ DptName="engineer",DparmenttId=2},
                new Department(){ DptName="implementation",DparmenttId=30},
                new Department(){ DptName="Support",DparmenttId=40},
            };
           var result = employees.Join(depatments,
               emp => emp.DptId, dpt => dpt.DparmenttId,
               (emp, dpt) => new { Name = emp.EmpName ,department=dpt.DptName,Salary=emp.Salary}
               );

            //or also join will be performed as below 
           var result2 = from emp in employees
                         join dpt in depatments on emp.DptId equals dpt.DparmenttId
                         select new { Name = emp.EmpName, department = dpt.DptName, Salary = emp.Salary };
            // performed join that the employees matche the departments 
           foreach (var item in result2)
           {
               Console.WriteLine("Name::"+item.Name+"\nDepartment::"+item.department+"\n Salary "+item.Salary);
           }
            Console.ReadKey();
        }
    }
}
