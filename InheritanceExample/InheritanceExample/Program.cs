using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
namespace InheritanceExample
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassLibrary1.Employee obj1 = new Employee();
            obj1.EmpName = "aniket";
            obj1.Emp_id = 1;
            Manager obj2 = new Manager();
            obj2.EmpName = "managerrrr";
            obj2.Emp_id = 12;
            

            Salesmen obj3 = new Salesmen();
            obj3.Emp_id = 3;
            obj3.EmpName = "Salesmen";
            obj1.display();
            obj2.display();
            Console.WriteLine(obj2.TotalSaleofYear());
            obj3.display();
            Console.WriteLine(obj3.GetSaleOfMonth());
            Console.ReadKey();
        }
    }
}
