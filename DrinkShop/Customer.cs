using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkShop
{
    class Customer
    {
        int beverages;

        public Customer()
        {
            Random rnd = new Random();
            beverages = rnd.Next(1, 10);
        }

        public int Beverages
        {
            get
            {
                return beverages;
            }

            set
            {
                beverages = value;
            }
        }
    }
}
