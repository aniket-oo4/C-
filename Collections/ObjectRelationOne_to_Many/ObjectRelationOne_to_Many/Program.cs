using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 1 to Many  
namespace ObjectRelationOne_to_Many
{
    class Program
    {

        class Student
        {
            public string name { set; get; }
            public List<Exam> exams;
        }
        class Exam
        {
            public string month { set; get; }
            public int marks { set; get; }

        }
        static void Main(string[] args)
        {
            Student student = new Student() { name = "aniekt" };
            student.exams = new List<Exam>();
            student.exams.Add(new Exam() { marks=199,month="january"});
            student.exams.Add(new Exam() { marks = 100, month = "feb" });
            student.exams.Add(new Exam() { marks = 400, month = "june" });

            Console.WriteLine("name::" + student.name);
            foreach (Exam item in student.exams)
            {
                Console.WriteLine("Month of exams ::" + item.month+ "  marks ::"+item.marks);
            }

            Console.ReadKey();
        }
    }
}
