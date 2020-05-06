using System;
using System.Collections.Generic;

namespace leetcode.solution._2020April
{
    //https://leetcode.com/explore/other/card/30-day-leetcoding-challenge/528/week-1/3284/
    class Q202
    {
        public bool IsHappy(int n)
        {
            bool bol = true;
            int inputNum = n;
            List<int> digits;
            double sumOfSquares = 0;
            List<int> appearedNum = new List<int>();
            do
            {
                if (appearedNum.Contains(inputNum))
                {
                    bol = false;
                    break;
                }
                else
                {
                    appearedNum.Add(inputNum);

                    digits = GetDigits(inputNum);
                    sumOfSquares = GetSumOfSquares(digits);

                    Console.Write("-");
                    inputNum = (int)sumOfSquares;
                    Console.WriteLine("->" + inputNum);
                }
            }
            while (Math.Log(sumOfSquares) % 1 != 0);

            return bol;
        }


        private List<int> GetDigits(int n)
        {
            List<int> digits = new List<int>();
            int i = 10;
            do
            {
                digits.Add(n % i);
                Console.Write(n % i + " ");
                n = n / i;
            }
            while (n / i > 0);

            digits.Add(n);
            Console.Write(n + " ");

            return digits;
        }


        private double GetSumOfSquares(List<int> nums)
        {
            double sum = 0;
            foreach (int eachNum in nums) { sum += Math.Pow(eachNum, 2); }
            return sum;
        }
    }
}
