using System.Collections.Generic;
using System.Linq;

namespace leetcode.solution
{
    class Q349
    {
        public int[] Intersection(int[] nums1, int[] nums2)
        {
            //home made
            if (nums1.Count() < nums2.Count())
                return findIntersection(nums1, nums2);
            else
                return findIntersection(nums2, nums1);
            
            //built in
            IEnumerable<int> both = nums1.Intersect(nums2);
            return both.ToArray();
        }

        private int[] findIntersection(int[] nums1, int[] nums2)
        {
            List<int> ans = new List<int>();
            foreach (int num in nums1)
            {
                if (!ans.Contains(num) && nums2.Contains(num))
                    ans.Add(num);
            }
            return ans.ToArray();
        }
    }
}
