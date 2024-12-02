using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{

    class Vehicle
    {
        protected int average;
        protected string name;
        protected Vehicle(int av, string name)
        {
            this.average = av;
            this.name = name;


        }

    }
    class Car:Vehicle
    {
        private int wheels;
       
        public Car(int av, string name, int wheels): base(av,name)
        {
           
            this.wheels = wheels;
        }

    }

  
}
