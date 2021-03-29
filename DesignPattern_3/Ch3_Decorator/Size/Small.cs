using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ch3_Decorator
{
    public class Small : SizeDecorator
    {
        public Small(IBeverage beverage) : base(beverage)
        {
            this.size = "小杯";
            this.price = .00;
        }
    }
}
