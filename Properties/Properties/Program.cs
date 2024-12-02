using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{

    class Employee
    {

        private int emp_id;
        string name;
        public string gender {set;get; }
        public int[] arr = new int[] { 1, 2, 3, 4, 5, 5, 6 };

        public int this[int index]{
    set{
        this.arr[index] = value;
    }
            get { return this.arr[index]; }

    }
        public int Emp_id
        {
            set
            {
                
                this.emp_id = value;
            }
        get { return this.emp_id; }
            
       }
       public  string Name {
            
            set { this.name = value; }
            get { return name; }
        }

    }





    class Program
    {



        static void Main(string[] args)
        {

            Employee obj = new Employee() { Name="aniket",Emp_id=1122,gender="male"};// objectinitializers 
            
            Console.WriteLine(obj.Name+"   " +obj.Emp_id+" Gender :"+obj.gender );
            Console.ReadKey();
            Console.ReadKey();
        }
    }
}
