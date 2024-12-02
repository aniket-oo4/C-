using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
   public class Manager : Employee
    {
       private string _department;
       string Department { set; get; }
       public long TotalSaleofYear()
       {

           return 1000;
       }
    }
}
