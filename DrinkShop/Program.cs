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
            int days=0;
            while (true)
            {
                for (int i = 0; i < 7; i++)
                {
                    days++;
                    //Заяка на дозакупку товара
                    List<int> clime = new List<int>();
                    for (int j = 0; j < 13; j++)
                    {
                        Random rnd = new Random();
                        int count = rnd.Next(1, 10);
                        //Количество поситителей за час
                        Customer[] customers = new Customer[count];
                        //рассчет скидки
                        if (j % 2 == 0)
                            markup.calc(i, j);
                        for (int n = 0; n < count; n++)
                        {
                            Customer customer = new Customer(assortment - 1);
                            foreach (var key in customer.cart.Keys)
                            {
                                if (goods[key].Count >= customer.cart[key])
                                {
                                    goods[key].Count -= customer.cart[key];
                                    //Рассчет прибыли по каждому товару и подсчет количества продаж
                                    CalcProfit(goods, markup, customer, key);
                                    Console.Write(goods[key].Name + " " + goods[key].Count + "\n" + customer.cart[key] + "\n");
                                    //Добавление товара в заявку на закупку товара
                                    createClime(goods, clime, customer, key);
                                }
                                else
                                {
                                    Console.Write(goods[key].Name + "Продано!\n");
                                    //Добавления товара в заявку на закупку товара

                                }
                            }

                        }
                        System.Threading.Thread.Sleep(300);
                    }
                    Order(goods, clime);
                    Console.Write(goods[1].Profit + "профит!\n");
                    Console.WriteLine(goods[1].Sale);
                    Console.WriteLine(goods[1].Buy);
                } 
                if (days==30)
                { 
                    //do somethin
                }
                
            }
          
        }

        private static void CalcProfit(List<Good> goods, markup markup, Customer customer, int key)
        {
            goods[key].Sale = customer.cart[key];
            if (customer.cart[key] > 2)
            {
                goods[key].Profit = ((goods[key].Price * markup.Procent) * 2 + (goods[key].Price * 0.07) * (customer.cart[key] - 2));
                Console.WriteLine(goods[key].Profit);
            }
            else
            {
                goods[key].Profit = (goods[key].Price * markup.Procent * customer.cart[key]);
                Console.WriteLine(goods[key].Profit);
                
            }
        }

        private static void createClime(List<Good> goods, List<int> clime, Customer customer, int key)
        {
            if (goods[key].Count <= 10 && !clime.Contains(key))
            {
                clime.Add(key);
            }
        }

        private static void Order(List<Good> goods, List<int> clime)
        {
            foreach (int pos in clime)
            {
                Console.Write(goods[pos].Name + "Дозаказ!\n");
                goods[pos].Count += 150;
                goods[pos].Buy += 150;

            }
        }

      
       

   
}
}