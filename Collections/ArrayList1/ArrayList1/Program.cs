using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList1
{

    class Sample
    {

        public string GetMessage()
        {
            return "HEllo ";
        }
        public int GetInt()
        {
            return 112;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrrayList = new ArrayList() { 11, 'A', "jheleo", 11.23 }; //  initializing with  different types 
            arrrayList.Add(new Sample());//adding object 
            Console.WriteLine();

            //for each
            foreach(var  item in arrrayList)
            {

                Console.WriteLine(item);// it calls the ToString Method internaly for each element 
            }

            Console.ReadKey();
        }
    }
}
