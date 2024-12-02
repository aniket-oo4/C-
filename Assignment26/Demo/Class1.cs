using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class Character
    {

       public string name;
       public int health, attack, defense;

       public virtual void Defend()
       {
          
       }

        public Character()
        {
   
            this.health = 100;
            Console.WriteLine("Enter attack values : ");
            this.attack = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Defense values : ");
            this.defense = Convert.ToInt32(Console.ReadLine());
        }
        public virtual void Attack(Character target)
        {
            if (target.defense <= 0)
            {
                Console.WriteLine(this.name + "Wins the game ");

            }
            else if ( target.defense>0&&this.attack<=target.defense)
            {
                target.health -= this.attack - target.defense;
                Console.WriteLine(target.name + "cannot defend!! Reduced "+this.attack+"defenses ");

            }
            else
            {
                Console.WriteLine(target.name + "defends and gains " + (target.defense - this.attack) + " defense.");
            }

        }
    }
  public   class Warriour : Character
    {

        public Warriour():base()
        {
           Console.WriteLine("Enter WArriour name :");
           this.name = Console.ReadLine();
        }

        void Charge(Character target)
        {
            this.attack *= 2;

        }
      public override void Defend()
      {
            this.defense += 5;
        }
      public override void Attack(Character target)
        {
            this.Charge(target);
            this.Defend();
            base.Attack(target);
        }

    }
   public  class Mage : Character
    {
        
        public Mage():base()
        {
           Console.WriteLine("Enter MAge name :");
           this.name = Console.ReadLine();
        }
        void CastSpell(Character target)
        {

            this.attack +=this.attack -this.attack/2;
        }


        public sealed override void Defend()
        {
            base.Defend();
        }
        public override void Attack(Character target)
        {
            this.CastSpell(target);
            this.Defend();
            base.Attack(target);
        }

    }
  public   class Dragon : Character
    {
        
        public Dragon():base()
        {
           Console.WriteLine("Enter Dragon name :");
           this.name = Console.ReadLine();
        }
        void BreatheFire(Character target)
        {
            this.attack *= 2;

        }
        public override void Attack(Character target)
        {
            this.BreatheFire(target);
            base.Attack(target);
        }

    }
    public class Class1
    {
    }
}
