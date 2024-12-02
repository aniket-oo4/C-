using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Salesmen : Employee
    {
        private string _region;
        public string Region { set; get; }
        public long GetSaleOfMonth()
        {
            return 1132;
        }   

    }
}
