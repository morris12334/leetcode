using System;
using System.Text;

namespace leetcode.solution
{
    class Q476
    {
        public int FindComplement(int num)
        {
            string numStr = Convert.ToString(num, 2);

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < numStr.Length; i++)
            {
                sb.Append(numStr[i] == '0' ? "1" : "0");
            }
            return Convert.ToInt32(sb.ToString(), 2);
        }
    }
}
