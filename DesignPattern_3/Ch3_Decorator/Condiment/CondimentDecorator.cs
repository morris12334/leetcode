using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ch3_Decorator
{
    public abstract class CondimentDecorator : IBeverage
    {
        IBeverage beverage = null;
        protected string description;
        protected double price;

        protected CondimentDecorator(IBeverage beverage)
        {
            this.beverage = beverage;
        }

        public string GetDescription()
        {
            return string.Format("{0},{1}", beverage.GetDescription(), description);
        }

        public double Cost()
        {
            return price + beverage.Cost();
        }

    }
}
