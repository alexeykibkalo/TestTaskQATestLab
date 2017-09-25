using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkShop
{
    class markup
    {
        private double procent;

        public double Procent
        {
            get
            {
                return procent;
            }

            set
            {
                procent = value;
            }
        }
        public void calc(int day, int hour)
        {
            procent = 0.1;
            if (hour == 6)
            {
                procent = 0.08;
            }
            else if(day>5)
            {
                procent = 0.15;
                               
            }
           
        }
    }
}
