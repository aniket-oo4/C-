using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Employee
    {

        internal string name;
        public Employee() {
            Console.WriteLine("enter name :");
            this.name = Console.ReadLine();
        }
        public void display()
        {
            Console.WriteLine(this.name);
        }
        int display()
        {
            return 3;
        }
    }
}
