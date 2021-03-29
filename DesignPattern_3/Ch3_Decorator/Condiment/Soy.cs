using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ch3_Decorator
{
    class Soy : CondimentDecorator
    {
        public Soy(IBeverage beverage)
            : base(beverage)
        {
            this.description = "豆漿";
            this.price = .10;
        }
    }
}
