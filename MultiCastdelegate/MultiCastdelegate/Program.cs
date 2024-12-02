using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
	
namespace MultiCastdelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Sample obj = new Sample();
            MyDelegateType dlg = obj.Add;
           // MyDelegateType dlg = new MyDelegateType(obj.Add);
           // dlg(12, 90);
            dlg += obj.Multiply;
            dlg(12, 90);
            Console.ReadKey();
        }
    }
}
