using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComparer
{

   public class Employee 
    {
        public int EmpID { get; set; }
        public string EmpName { get; set; }

    }
   public class CustomeComparer : IComparer<Employee>
    {

 


        public int Compare(Employee x, Employee y)
            {
                return x.EmpID - y.EmpID;
            }
}

   public enum SortBy
   {
       EmpId, EmpName
   }
   public class columnComparer : IComparer<Employee>
   {

       public SortBy sortBy { get; set; }
       public int Compare(Employee x, Employee y)
       {
           int result=0;
           switch (this.sortBy)
           {
               case SortBy.EmpId:
                   result= x.EmpID - y.EmpID;
                   if(result==0)
                   {
                       return x.EmpName.CompareTo(y.EmpName);
                   }
                   break;
               case SortBy.EmpName:
                   result= x.EmpName.CompareTo(y.EmpName);
                   if (result == 0)
                   {
                       return x.EmpID - y.EmpID; ;
                   }
                   break;

           }
           return result;

       }

/*
       public int Compare(Employee x, Employee y)
       {
           int result= x.EmpName .CompareTo(y.EmpName);
           if (result == 0)
           {
               return x.EmpID - y.EmpID; 
           }
           return result;
       }
 * */
   }
    class Program
    {
        static void Main(string[] args)
        {

            List<Employee> empList = new List<Employee>()
                {
                    new Employee(){EmpName="tejas", EmpID=4},
                    new Employee(){EmpName="aniket", EmpID=1},

                    new Employee(){EmpName="sahil", EmpID=2},
                     
                    new Employee(){EmpName="tushar", EmpID=3},
                };
            Console.WriteLine("before Comparer");
            foreach (Employee item in empList)
            {
                Console.WriteLine("Emp Name::" + item.EmpName + "  Emp ID ::" + item.EmpID);

            }


            CustomeComparer comparer = new CustomeComparer();
            empList.Sort(comparer);

            Console.WriteLine("\nAfter Comparer");
            // print 
            foreach (Employee item in empList)
            {
                Console.WriteLine("Emp Name::" + item.EmpName + "  Emp ID ::" + item.EmpID);

            }


            //two column comparer 

            columnComparer comparer2 = new columnComparer();
            comparer2.sortBy = SortBy.EmpName;
            empList.Add(new Employee { EmpName = "sahil", EmpID = 0 });  // 
            Console.WriteLine("\nbefore  Comparer");
            // print 
            foreach (Employee item in empList)
            {
                Console.WriteLine("Emp Name::" + item.EmpName + "  Emp ID ::" + item.EmpID);

            }
            empList.Sort(comparer2);

            Console.WriteLine("\nafter  Comparer");
            // print 
            foreach (Employee item in empList)
            {
                Console.WriteLine("Emp Name::" + item.EmpName + "  Emp ID ::" + item.EmpID);

            }
            Console.ReadKey();
        }
    }
}
