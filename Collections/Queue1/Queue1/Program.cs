using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue1
{
    class Program
    {
        static void Main(string[] args)
        {

            Queue<string > myQueue = new Queue<string>() ;

            // adding element 
            myQueue.Enqueue("Task3");  // front 
            myQueue.Enqueue("Task4");
            myQueue.Enqueue("Task2");
            myQueue.Enqueue("Task5");
              myQueue.Enqueue("Task1");
            myQueue.Enqueue("Task6");// rear 
            //foreach
            foreach (string item in myQueue)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Removed ::"+myQueue.Dequeue());
            Console.WriteLine("Removed ::" + myQueue.Dequeue());
            Console.WriteLine("Front ::" + myQueue.Peek());
            Console.ReadKey();
        }
    }
}
