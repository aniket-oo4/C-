using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectRelationOone_to_One
{
    class Student
    {
        public string name { set; get; }
        public int roll_no { get; set; }
        public int age { set; get; }
        public Branch branch;
    }
    class Branch
    {
        public string Branch_name { set; get; }
        public string department { set; get; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student() { name = "aniekt", roll_no = 1 };
            Branch branch = new Branch() { Branch_name = "computer ", department = "progrramming" };

            student.branch = branch;

            Console.WriteLine("Name:" + student.name + "  roll no+" + student.roll_no + "BRanch :" + student.branch.Branch_name + "Departments ::"+student.branch.department);

            Console.ReadKey();
        }
    }
}
