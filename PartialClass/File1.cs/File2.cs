using System;
namespace Demo
{
    public partial class Product
    {
       public void Display( )
        {
            Console.WriteLine("hello  Product"+this.Productid);
        }
        public void Call(){
            this.dd();
        }
    }
}
