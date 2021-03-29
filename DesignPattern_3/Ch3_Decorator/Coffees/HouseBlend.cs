using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ch3_Decorator
{
    public class HouseBlend : IBeverage
    {
        private string size;
        private string description;
        private double price;
        private double sizePrice;

        public HouseBlend()
        {
            description = "綜合咖啡";
            price = .89;
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
