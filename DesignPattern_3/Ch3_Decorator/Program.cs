using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ch3_Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
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

            IBeverage beverage4 = new Decaf();
            Display(beverage4);
            beverage4 = new Whip(beverage4);
            Display(beverage4);
            DisplayLine();

            IBeverage beverage5 = new Decaf();
            Display(beverage5);
            beverage5 = new Whip(beverage5);
            beverage5 = new Small(beverage5);
            Display(beverage5);
            DisplayLine();

            IBeverage beverage6 = new Decaf();
            Display(beverage6);
            beverage6 = new Whip(beverage6);
            beverage6 = new Medium(beverage6);
            Display(beverage6);
            DisplayLine();

            IBeverage beverage7 = new Decaf();
            Display(beverage6);
            beverage7 = new Whip(beverage7);
            beverage7 = new Medium(beverage7);
            beverage7 = new Medium(beverage7);
            Display(beverage7);
            DisplayLine();

            Console.ReadKey();
        }

        private static void Display(IBeverage beverage)
        {
            Console.WriteLine(beverage.GetDescription() + " $" + beverage.Cost());
        }
        private static void DisplayLine()
        {
            Console.WriteLine("=======================================");
            Console.WriteLine();
        }
    }
}
