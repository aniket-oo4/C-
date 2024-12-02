using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Employee
    {
        private string _emp_name;
        private int _emp_id;
        public string EmpName { set; get; }
       public  int Emp_id {
           set { this._emp_id = value; }
           get{return this._emp_id;} 
           }
      public void display()
       {

           Console.WriteLine("employee name :" + this.EmpName + "\n emp ID: " + this._emp_id);

       }

    }
}
