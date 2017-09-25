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
            string[] drinkValues = null;
            foreach(string drink in drinks)
            {
                drinkValues = drink.Split(';');
            }
            markup markup = new markup();
            //for (int i = 0; i < 7; i++)
            //{
            //    for(int j = 0; j<13; j++)
            //    {
            //        if (j % 2 == 0)
            //            markup.calc(i, j);

            //        Console.Write(i + "days" + " " + j + "hours\nDiscount "+markup.Procent+"\n");

            //        System.Threading.Thread.Sleep(300);
            //    }
            //}

        }

      
       

   
}
}