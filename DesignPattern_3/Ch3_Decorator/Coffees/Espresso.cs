using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ch3_Decorator
{
    public class Espresso : IBeverage
    {
        private string description;
        private double price;

        public Espresso()
        {
            description = "Espresso";
            price = 1.99;
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
