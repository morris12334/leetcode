using System;

namespace leetcode.solution
{
    class Q124
    {
        public Q124(string[] strs) {
            TreeNode BTree = new Q104(strs).BTree;
            maxPathSum = MaxPathSum(BTree);
        }

        public int maxPathSum = int.MinValue;
        public int MaxPathSum(TreeNode root)
        {
            SinglePathMax(root);
            return maxPathSum;
        }

        private int SinglePathMax(TreeNode root)
        {
            if (root == null) return 0;

            int leftMax = Math.Max(SinglePathMax(root.left), 0);
            int rightMax = Math.Max(SinglePathMax(root.right), 0);

            maxPathSum = Math.Max(maxPathSum, root.val + leftMax + rightMax);

            return root.val + Math.Max(leftMax, rightMax);
        }
    }
}
