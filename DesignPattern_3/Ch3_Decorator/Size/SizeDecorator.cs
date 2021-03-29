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

        protected SizeDecorator(IBeverage beverage)
        {
            this.beverage = beverage;
        }

        public string GetDescription()
        {
            return string.Format("{0},{1}", size, beverage.GetDescription());
        }

        public double Cost()
        {
            return price + beverage.Cost();
        }

    }
}
