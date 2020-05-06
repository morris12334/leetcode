using System;

namespace leetcode.solution
{
    class Q201
    {
        public int RangeBitwiseAnd(int m, int n)
        {
            int output = 0;

            if (m == n) return m;

            for (int i = 0; ; i++)
            {
                if (n == 0) { break; }
                if (((m % 2) ^ (n % 2)) == 0)
                    output += (int)Math.Pow(2, i) * (m % 2);
                else
                    output = 0;

                m = m >> 1;
                n = n >> 1;
            }
            return output;
        }
    }
}
