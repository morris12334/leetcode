using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ch3_Decorator
{
    class Decaf : IBeverage
    {
        private string description;
        private double price;

        public Decaf()
        {
            description = "低咖啡因";
            price = .90;
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
