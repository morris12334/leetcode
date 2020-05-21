using System.Collections.Generic;

namespace leetcode.solution
{
    class Q993
    {
        public Q993(string[] strs, int x, int y)
        {
            TreeNode BTree = new Q104(strs).BTree;
            isCousins = IsCousins(BTree, x, y);
        }
        public bool isCousins;

        bool findVal(TreeNode node, int x, int y)
        {
            return node != null && (node.val == x || node.val == y);
        }

        public bool IsCousins(TreeNode root, int x, int y)
        {
            TreeNode current = root;
            Queue<TreeNode> currentQ = new Queue<TreeNode>();

            currentQ.Enqueue(root);

            while (currentQ.Count != 0)
            {
                int levelCount = 0;
                int levelNodeCount = currentQ.Count;
                for (int i = 0; i < levelNodeCount; i++)
                {
                    current = currentQ.Dequeue();
                    if (current == null) { continue; }

                    int nodeCount = 0;

                    if (findVal(current.left, x, y)) nodeCount++;
                    if (findVal(current.right, x, y)) nodeCount++;

                    if (nodeCount == 2) return false;

                    currentQ.Enqueue(current.left);
                    currentQ.Enqueue(current.right);

                    levelCount += nodeCount;

                    if (levelCount == 2) return true;
                }
            }
            return false;
        }
    }
}
