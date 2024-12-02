using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternMatchin
{
    class Parent
    {
        string Name { set; get; }
    }
    class Child : Parent
    {
        int id { set; get; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Child obj=new Child();
            if (obj is Child)
            {
                Child demo = (Child)obj;
                Console.WriteLine(demo.GetType());
            }
            /*if (obj is Child dd) //not supported 
            {
              
                Console.WriteLine(dd.GetType());
            }
             * */
        }
    }
}
