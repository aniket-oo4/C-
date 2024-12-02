using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
   public class Vehicle
    {
       public Vehicle() { }
        protected int average;
        protected string name;
        protected Vehicle(int av, string name)
        {
            this.average = av;
            this.name = name;


        }

    }
   public class Car : Vehicle
    {
        private int wheels;

        public Car(int av, string name, int wheels):base(av,name)
        {
       
            this.wheels = wheels;

        }
        /*  orr we can also do that 
         public Car(int av, string name, int wheels)
            
         {
             base.average = av;
             base.name = name;
             this.wheels = wheels;
          
         }
        */
        public void display()
        {
            Console.WriteLine("name"+base.name+" av"+this.average+"wheels "+this.wheels);

        }

    }


}
