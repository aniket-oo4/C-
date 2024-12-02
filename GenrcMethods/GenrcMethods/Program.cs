using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenrcMethods
{

    public class Employee
    {
        public int salary;

    }
    public class Student
    {
        public int marks;
    }



    class Program
    {


        public void Add<T>(T para1, T para2)
        {
           
             int a=Convert.ToInt16(para1);
                int b=Convert.ToInt16(para2);
               
          
            Console.WriteLine("answer is :" + (a+b));
        }
        static void Main(string[] args)
        {
            Program obj=new Program();
            obj.Add<int>(12, 44);
            Console.ReadKey();
        }
    }
}
