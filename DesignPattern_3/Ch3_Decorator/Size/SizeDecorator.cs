using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ch3_Decorator
{
    public abstract class SizeDecorator : IBeverage
    {
        IBeverage beverage = null;
        protected string description;
        protected double price;
        protected string size;
        protected double sizePrice;

        protected SizeDecorator(IBeverage beverage)
        {
            this.beverage = beverage;
        }
        public string GetDescription()
        {
            return beverage.GetDescription();
        }

        public double Cost()
        {
            return beverage.Cost();
        }

        public double CostWithSize()
        {
            return sizePrice + beverage.Cost();
        }

        public string GetDrink()
        {
            return string.Format("{0},{1}", size, beverage.GetDescription());
        }

    }
}
