using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ch3_Decorator
{
    public class Whip : CondimentDecorator
    {
        public Whip(IBeverage beverage)
            : base(beverage)
        {
            this.description = "鮮奶油";
            this.price = .25;
        }
    }
}
