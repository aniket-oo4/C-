using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack1
{
    class Student
    {
        public String name { set; get; }
        public int roll_no{set;get;}
    }
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> myStack = new Stack<int>();
            myStack.Push(110);// Bottom
            myStack.Push(200);
            myStack.Push(245);  // Top
            foreach (var item in myStack)
                // returns top to bottom approach 
            {
                Console.WriteLine(item);
            }
            //  removing last // top element using pop
           Console.WriteLine("TOP ::"+myStack.Peek());
            // creating a stack of Student object s
            Stack<Student> marks = new Stack<Student>();
            marks.Push(new Student(){name="aniket",roll_no=122});
            marks.Push(new Student() { name = "tejas", roll_no = 12 });

            foreach (var item in marks)
            // returns top to bottom approach 
            {
             
                Console.WriteLine(item+"  ::"+item.name+"    :"+item.roll_no );
            }

            Console.ReadKey();
        }
    }
}
