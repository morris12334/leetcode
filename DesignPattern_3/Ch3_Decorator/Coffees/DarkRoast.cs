using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ch3_Decorator
{
    class DarkRoast : IBeverage
    {
        private string size;
        private string description;
        private double price;
        private double sizePrice;

        public DarkRoast()
        {
            description = "深度烘焙咖啡";
            price = .50;
        }

        public string GetDescription()
        {
            return description;
        }

        public double Cost()
        {
            return price;
        }

        public double CostWithSize()
        {
            return sizePrice + price;
        }

        public string GetDrink()
        {
            return string.Format("{0},{1}", size, description);
        }
    }
}
