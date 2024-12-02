using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectRelation_Many_to_One
{
    class Employee
    {
        public string emp_name { set; get; }
        public Department dpt;
    }
    class Department
    {
        public string dptName { set; get; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee() { emp_name = "emp1" };
            Employee emp2 = new Employee() { emp_name = "emp2" };
            Employee emp3 = new Employee() { emp_name = "emp3" };

            Department dpt = new Department() { dptName = "Accounting " };

            emp1.dpt = dpt;
            emp2.dpt = dpt;
            emp3.dpt = dpt;

            // many to one 
        }
    }
}
