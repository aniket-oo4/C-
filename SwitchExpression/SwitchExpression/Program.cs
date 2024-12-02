using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            int operation = 1;
            string result; 
            // allowed only in version c# 8.0
            result=>operation switch
            {
                1=>"customer";
                2=>"salary";
                _=>"no caese";

            };
        }
    }
}
