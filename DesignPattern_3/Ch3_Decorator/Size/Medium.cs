using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ch3_Decorator
{
    public class Medium : SizeDecorator
    {
        public Medium(IBeverage beverage) : base(beverage)
        {
            this.size = "中杯";
            this.price = .30;
        }
    }
}
