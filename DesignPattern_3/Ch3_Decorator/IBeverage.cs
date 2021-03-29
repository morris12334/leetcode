using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ch3_Decorator
{

    public interface IBeverage
    {
        string GetDescription();
        double CostWithSize();
        string GetDrink();
        double Cost();
    }
}
