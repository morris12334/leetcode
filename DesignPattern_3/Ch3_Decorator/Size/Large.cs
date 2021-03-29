using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ch3_Decorator
{
    public class Large : SizeDecorator
    {
        public Large(IBeverage beverage) : base(beverage)
        {
            this.size = "大杯";
            this.price = .50;
        }
    }
}
