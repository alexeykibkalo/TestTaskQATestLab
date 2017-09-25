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
        private float capacity;
        private string description;
        private int count;
        private double profit;

        public Good(string name, double price, string category, string description)
        {
            profit = 0;
            this.name = name;
            this.price = price;
            this.category = category;
            this.description = description;
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
        public float Capacity
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

    }
}
