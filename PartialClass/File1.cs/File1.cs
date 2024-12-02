
using System;
namespace Demo
{
    public partial class Product
    {
        private int _productId;

      partial   void dd()
        {

            Console.WriteLine("Hello");
        }
        public int Productid
        {
            set
            {
                this._productId = value;
            }
            get
            {
                return this._productId;
            }
        }
    }
}

