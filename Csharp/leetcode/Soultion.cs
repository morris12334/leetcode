using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode
{
    public class Solution
    {
        public int Q58(string s)
        {
            string[] strs = s.Split();
            Console.WriteLine("strs: " + strs + "@@ Length" + strs.Length);

            if (0 == strs.Length) { return 0; }
            else
            {
                int output = 0;
                foreach (string str in strs.Reverse())
                {
                    output = str.Length;
                    if (0 != output) break;
                }
                return output;
            }
        }
        public int Q70(int num)
        {
            int output = 0;
            int n2 = num / 2;
            if (n2 > 1)
                output += Q70(num);
            else
                return 2;

            return output;
        }
        public string Q334(string s)
        {
            string output = "";
            var a = s.ToArray();
            for (int i = a.Count() - 1; i >= 0; i--)
            {
                output += a[i].ToString();
            }
            return output;
        }
        public int Q509(int N)
        {
            int[] table;
            //DP Dynamic Programming
            if (N <= 1) return N;
            table = new int[N + 1];
            table[0] = 0;
            table[1] = 1;
            for (int i = 2; i <= N; i++) { table[i] = table[i - 1] + table[i - 2]; }
            return table[N];

            //Recursive
            /*
            switch (N)
            {
                case 1: return 1;
                case 0: return 0;
                default: return Q509(N - 1) + Q509(N - 2);
            }
            */
        }
        public IList<int> Q970(int x, int y, int bound)
        {
            if (bound == 0) return new int[] { };
            List<int> table2 = new List<int>();
            double x1 = Math.Floor(Math.Log(bound, x));
            double y1 = Math.Floor(Math.Log(bound, y));
            for (int i = 0; i < 20 && Math.Pow(x, i) <= bound; i++)
            {
                for (int j = 0; j < 20 && Math.Pow(y, j) <= bound; j++)
                {
                    int sum = Convert.ToInt32(Math.Pow(x, i) + Math.Pow(y, j));
                    if (sum <= bound) table2.Add(sum);
                }
            }
            return table2.Distinct().ToList();
        }
    }
}
