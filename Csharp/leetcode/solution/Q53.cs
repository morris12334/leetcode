using System.Collections.Generic;

namespace leetcode.solution
{
    class Q53
    {
        public int MaxSubArray(int[] nums)
        {
            int max = int.MinValue;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length - i; j++)
                {
                    int sum = nums.Skip(i).Take(j + 1).Sum();
                    max = Math.Max(max, sum);
                }

            }
            return max;
        }
    }
}