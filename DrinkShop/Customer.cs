using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkShop
{
    class Customer
    {        
        public Dictionary<int, int> cart;
        public Customer(int assortment)
        {
            Random rnd = new Random();
            //генерация количества товара который купит покупатель
            int beverages = rnd.Next(0, 9);
            //так как товары генерируются рандомно и могут повторятся хаотично,
            //ассоциативный массив позволит иметь удобный доступ к видам товара и его количеству
            cart = new Dictionary<int, int>();
                    
            for(int i = 0; i<=beverages; i++)
            {
                int product = rnd.Next(0, assortment);
                if(cart.ContainsKey(product))
                {
                    cart[product]++;
                }
                else
                {
                    cart.Add(product, 1);
                }
            }

        }

    }
}
