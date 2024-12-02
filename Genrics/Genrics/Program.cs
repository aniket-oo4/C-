using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genrics
{

    public class MyGenric<T> where T:class
    {
        T name;

        public T Name
        {
            set
            {
                this.name = value;
            }
            get {
                return this.name;
            }

        }
        public MyGenric() { }
       public MyGenric(T value)
        {
            this.name = value;
           
        }
    }

    public class MyGenric2<T,W> where T:class// Restriction on parameter T
    {
        T name;
        W _id;
        public W ID{
            set
            {
                this._id = value;
            }
            get
            {
                return this._id;
            }

        }
        public T Name
        {
            set
            {
                this.name = value;
            }
            get
            {
                return this.name;
            }

        }
        public MyGenric2() { }
        public MyGenric2(T value,W value2)
        {
            this.name = value;
            this._id = value2;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyGenric2<string,int> obj;//primitive strinng is also allowed  because it bydefault derived froom System.String class
          //  MyGenric2<String, int> obj;
            Console.WriteLine("Enter your name ");
            string demo=Console.ReadLine();
            //obj = new MyGenric<string>(demo);
            obj = new MyGenric2<string, int>(demo, 1);//primitive strinng is not allowed 
            obj = new MyGenric2<String, int>(demo, 1);
            Console.WriteLine("my name is :"+obj.Name+"Id is :"+obj.ID);
            Console.ReadKey();
        }
    }
}
