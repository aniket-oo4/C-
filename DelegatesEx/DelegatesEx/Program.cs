using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
namespace DelegatesEx
{
    class Program
    {
        static void Main(string[] args)
        {
            Sample obj=new Sample(); // object of Sample ckass for acccsseing Method of that class 
            MyDelegateType dlg;//created  delegate     object for storing refrence of method
            dlg = obj.Add;//asigning method reference to delegate 
            // we can also do same as below 
            dlg = new MyDelegateType(obj.Add); // assigning reference of method into delagatre object 
            //*********** Invoking the method // calling the method usig deleGate
            int ans = dlg.Invoke(1, 23);
            Console.WriteLine(ans);
            // we can also call method by following way 
            Console.WriteLine(dlg(2, 34));
            Console.ReadKey();
            
        }
    }
}
