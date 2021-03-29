using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ch3_Decorator
{
    class Program
    {
        static void Main(string[] args)
        {/*
            IBeverage beverage = new Espresso();
            Display(beverage);
            beverage = new Mocha(beverage);
            Display(beverage);
            DisplayLine();

            IBeverage beverage2 = new DarkRoast();
            Display(beverage2);
            beverage2 = new Mocha(beverage2);
            Display(beverage2);
            beverage2 = new Mocha(beverage2);
            Display(beverage2);
            beverage2 = new Whip(beverage2);
            Display(beverage2);
            DisplayLine();
            
            IBeverage beverage3 = new HouseBlend();
            Display(beverage3);
            beverage3 = new Soy(beverage3);
            beverage3 = new Mocha(beverage3);
            beverage3 = new Whip(beverage3);
            Display(beverage3);
            DisplayLine();
            */
            IBeverage beverage4 = new Decaf();
            Display(beverage4);
            Display2(beverage4);
            beverage4 = new Whip(beverage4);
            Display(beverage4);
            Display2(beverage4);
            DisplayLine();
            
            IBeverage beverage5 = new Decaf();
            Display(beverage5);
            Display2(beverage5);
            beverage5 = new Whip(beverage5);
            Display(beverage5);
            Display2(beverage5);
            beverage5 = new Small(beverage5);
            Display(beverage5);
            Display2(beverage5);
            beverage5 = new Medium(beverage5);
            Display(beverage5);
            Display2(beverage5);
            beverage5 = new Mocha(beverage5);
            Display(beverage5);
            Display2(beverage5);
            beverage5 = new Large(beverage5);
            Display(beverage5);
            Display2(beverage5);
            beverage5 = new Soy(beverage5);
            Display(beverage5);
            Display2(beverage5);
            DisplayLine();
            
            Console.ReadKey();
        }

        private static void Display(IBeverage beverage)
        {
            Console.WriteLine(beverage.GetDescription() + " $" + beverage.Cost());
        }
        private static void Display2(IBeverage beverage)
        {
            Console.WriteLine("=>"+beverage.GetDrink() + " $" + beverage.CostWithSize());
        }
        private static void DisplayLine()
        {
            Console.WriteLine("=======================================");
            Console.WriteLine();
        }
    }
}
