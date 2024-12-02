using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covariance
{
    class LivingThing
    {
        public int no_of_legs
        {
            get;
            set;

        }
    }
        class Parrot : LivingThing
        {
        }
        class Dog : LivingThing
        {
        }

        interface IMover<out T>
        {
            T Move();
        }
        class Mover<T> : IMover<T>
        {
            public T Things { get; set; }
            public T Move()
            {
                return Things;
            }

        }
        class Program
        {
            static void Main(string[] args)
            {
                LivingThing livingThing = new Parrot();
                livingThing = new Dog();
                Parrot parrot = new Parrot() { no_of_legs = 2 };
                IMover<LivingThing> mover = new Mover<Parrot>() { Things = parrot };  // covariance happened 
                Console.WriteLine("Moving with "+mover.Move().no_of_legs+"  Legs ");
                mover.Move();

                Console.ReadKey();
            }
        }
  
}
