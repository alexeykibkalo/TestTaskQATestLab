using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkShop
{
    class Finaliser
    {
        public  bool SaveReportToCSVfile(List<Good> goods)
        {
            try
            {
                double sum = 0;
                double costs = 0;
                StreamWriter sw = new StreamWriter(@"Report.csv", false, Encoding.Unicode);
                sw.WriteLine("Товар\tТовара продано\tТовара закуплено");
               
                foreach (Good good in goods)
                {
                    sw.Write(good.Name+"\t"+good.Sale.ToString()+"\t"+good.Buy.ToString());
                    sw.WriteLine();
                    sum += good.Profit;
                    costs += good.Buy * good.Price;
                }
                sw.WriteLine("\tПрибыль\t"+sum.ToString());
                sw.WriteLine("\tЗатраты на покупку товара\t" + costs.ToString());
                sw.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка доступа к файлу отчета");
                return false;
            }         
            return true;
        }

        public bool SaveBaseToCSVfile(List<Good> goods)
        {
            try
            {
                StreamWriter sw = new StreamWriter(@"Base.csv", false, Encoding.Unicode);
                foreach (Good good in goods)
                {
                    sw.WriteLine(good.Name + ";" + good.Price + ";" + good.Category + ";" + good.Capacity+ ";" + good.Description + ";" + good.Count);
                   
                }
                sw.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка доступа к файлу базы данных");
                return false;
            }
            return true;
        }
      
       
    }
}
