using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ch3_Decorator
{
    public class Mocha : CondimentDecorator
    {
        public Mocha(IBeverage beverage) : base(beverage)
        {
            this.description = "摩卡";
            this.price = .20;
        }
    }
}
