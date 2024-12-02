using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APracticeConsole
{
    class Student
    {

      internal  readonly int a ;
      //or    internal  readonly int a
      internal const int b = 90;
      internal  const int c = 190;
      internal int d = 90;
     internal Student() {
          Console.WriteLine("enter value for a :");
          this.a = int.Parse(Console.ReadLine());
      }
    }
    class Program
    {
        static void Main(string[] args)
        {

            //const int a=01;
            //readonly int aaa=00; invalid in method allowed only in class 
            Student obj = new Student();
            Console.WriteLine("a:"+obj.a+"    b:"+Student.b+"   c:"+Student.c+"  d::"+obj.d);

            Console.ReadKey();
        }
    }
}
