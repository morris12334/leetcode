using System.Collections.Generic;

namespace leetcode.solution
{
    //https://leetcode.com/explore/other/card/30-day-leetcoding-challenge/528/week-1/3283/
    class Q136
    {
        public int SingleNumber(int[] nums)
        {
            List<int> numsList = new List<int>();
            foreach (int n in nums)
            {
                if (numsList.Contains(n))
                {
                    numsList.Remove(n);
                    continue;
                }
                numsList.Add(n);
            }
            return numsList[0];
        }
    }
}
