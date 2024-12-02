using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComparable_Exa
{
    class Employee: IComparable
    {
        public int EmpID { get; set; }
        public string EmpName { get; set; }


        public int CompareTo(object other)
        {
            Employee otherEmp=((Employee)other);
            Console.WriteLine(this.EmpID+"  :::"+ (otherEmp.EmpID));
           return this.EmpID-otherEmp.EmpID; // return negative then interchange  
            return this.EmpName.CompareTo(otherEmp.EmpName);// return negative then interchange  
            /*
      second       first   |||| second-first <0 then second become  first  and first  become second  
            1  :::4
            2  :::4
            2  :::1
            3  :::4
            3  :::2
        this.Id - Other.Id
             * 
             * 
             * */
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
       

    //List of number s
         /*   List<int> numbers = new List<int>() { 1, 23, 12, 54, 20 };
            numbers.Sort();
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }

          * */
     //List of Employees

            List<Employee> empList = new List<Employee>()
                {
                    new Employee(){EmpName="tejas", EmpID=4},
                    new Employee(){EmpName="aniket", EmpID=1},

                    new Employee(){EmpName="sahil", EmpID=2},
                     
                    new Employee(){EmpName="tushar", EmpID=3},
                };
     // try to Sort()
            empList.Sort();
            foreach( Employee item in empList)
            {
                Console.WriteLine("Emp Name::"+item.EmpName+"  Emp ID ::"+ item.EmpID);

            }

            Console.ReadKey();
        }
    }
}
