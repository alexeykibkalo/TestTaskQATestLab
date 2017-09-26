using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Timers;


namespace DrinkShop
{
    class Program
    { 
              
        static void Main(string[] args)
        {

            string[] drinks = File.ReadAllLines(@"base.csv", Encoding.Default);
            // количество позиций товара в магазине
            int assortment = drinks.Length;
            var goods = new List<Good>();
            //Заполняется ассортимент магазина
            foreach(string drink in drinks)
            {
                Good good = new Good(drink);
                goods.Add(good);
            }
            markup markup = new markup();
            for (int i = 0; i < 7; i++)
            {
                //Заяка на дозакупку товара
                List<int> clime= new List<int>();
                for (int j = 0; j < 13; j++)
                {
                    Random rnd = new Random();
                    int count = rnd.Next(1, 10);
                    //Количество поситителей за час
                    Customer[] customers = new Customer[count];
                    //рассчет скидки
                    if (j % 2 == 0)
                        markup.calc(i, j);
                    for (int n = 0; n < count; n++ )
                    {
                       Customer customer = new Customer(assortment-1);
                        for(int m = 0; m < customer.cart.Length; m++)
                        {
                            singleSale(goods, markup, clime, customer, m);
                        }
                    }
                    System.Threading.Thread.Sleep(300);
                }
                Order(goods, clime);
            }

        }

        private static void singleSale(List<Good> goods, markup markup, List<int> clime, Customer customer, int m)
        {
            if (goods[customer.cart[m]].Count > 0)
            {
                goods[customer.cart[m]].Count--;
                Console.Write(goods[customer.cart[m]].Name + " " + (goods[customer.cart[m]].Price + goods[customer.cart[m]].Price * markup.Procent) + " " + goods[customer.cart[m]].Count + "\n");
                //Добавления товара в заявку на закупку товара
                createClime(goods, clime, customer, m);
            }
            else
            {
                Console.Write(goods[customer.cart[m]].Name + "Продано!\n");
                //Добавления товара в заявку на закупку товара

            }
        }

        private static void createClime(List<Good> goods, List<int> clime, Customer customer, int m)
        {
            if (goods[customer.cart[m]].Count <= 10 && !clime.Contains(customer.cart[m]))
            {
                clime.Add(customer.cart[m]);
            }
        }

        private static void Order(List<Good> goods, List<int> clime)
        {
            foreach (int pos in clime)
            {
                Console.Write(goods[pos].Name + "Дозаказ!\n");
                goods[pos].Count += 150;
            }
        }

      
       

   
}
}