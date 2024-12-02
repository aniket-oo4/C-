using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Nullable<char> abc = 'z';
            Console.WriteLine(abc??'a');// OtherValues DAtatype mustbe a same Data type
            Console.ReadKey();
        }
    }
}
