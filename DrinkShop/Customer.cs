using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkShop
{
    class Customer
    {        
        public int[] cart;
        public Customer(int assortment)
        {
            Random rnd = new Random();
            //генерация количества товара который купит покупатель
            int beverages = rnd.Next(0, 9);
            cart = new int[beverages];
                    
            for(int i = 0; i<beverages; i++)
            {
                cart[i] = rnd.Next(0, assortment);
            }

        }

    }
}
