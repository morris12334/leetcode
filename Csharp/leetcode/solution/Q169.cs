using System.Collections.Generic;

namespace leetcode.solution
{
    class Q169
    {
        public int MajorityElement(int[] nums)
        {
            Dictionary<int, int> outputDict = new Dictionary<int, int>();

            int count = nums.Length;
            int temp;
            if (count == 1) return nums[0];

            for (int i = 0; i < count; i++)
            {
                if (outputDict.TryGetValue(nums[i], out temp))
                {
                    if (temp + 1 > count / 2) return nums[i];
                    else outputDict[nums[i]]++;
                }
                else outputDict.Add(nums[i], 1);
            }
            return 0;
        }
    }
}
