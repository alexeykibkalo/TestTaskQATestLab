using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkShop
{
    class Good
    {
        private string name;
        private double price;
        private string category;
        private double capacity;
        private string description;
        private int count;
        private double profit;
        private int sale;
        private int buy;

        public Good(string goodDescription)
        {
            string[] drinkValues = null;
            drinkValues = goodDescription.Split(';');
            profit = 0;
            name = drinkValues[0];
            price = Convert.ToDouble(drinkValues[1]);
            category = drinkValues[2];
            capacity = Convert.ToDouble(drinkValues[3]);
            description = drinkValues[4];
            count = Convert.ToInt16(drinkValues[5]);
        }
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public double Price
        {
            get
            {
                return price;
            }

            set
            {
                price = value;
            }
        }
        public string Category
        {
            get
            {
                return category;
            }

            set
            {
                category = value;
            }
        }
        public double Capacity
        {
            get
            {
                return capacity;
            }

            set
            {
                capacity = value;
            }
        }
        public string Description
        {
            get
            {
                return description;
            }

            set
            {
                description = value;
            }
        }
        public int Count
        {
            get
            {
                return count;
            }

            set
            {
                count = value;
            }
        }
        public double Profit
        {
            get
            {
                return profit;
            }

            set
            {
                profit += value;
            }
        }
        public int Sale
        {
            get
            {
                return sale;
            }

            set
            {
                sale += value;
            }
        }
        public int Buy
        {
            get
            {
                return buy;
            }

            set
            {
                buy =+ value;
            }
        }

    }
}
