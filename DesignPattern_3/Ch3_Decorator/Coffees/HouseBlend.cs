using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ch3_Decorator
{
    public class HouseBlend : IBeverage
    {
        private string description;
        private double price;

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
    }
}
