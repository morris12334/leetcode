using System.Linq;

namespace leetcode.solution
{
    class Q560
    {
        public int SubarraySum(int[] nums, int k)
        {
            int inputNum = k, output = 0, tempSum = 0;

            for (int i = 0; i < nums.Count(); i++)
            {
                tempSum = nums[i];

                if (tempSum == k) { output++; }
                for (int j = i + 1; j < nums.Count(); j++)
                {
                    tempSum = tempSum + nums[j];
                    if (tempSum == k) output++;
                }
            }
            return output;
        }
    }
}
