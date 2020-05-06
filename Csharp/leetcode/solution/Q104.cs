using System;
using System.Collections;
using System.Linq;

namespace leetcode.solution
{
    //definition for a binary tree node.
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

    class Q104
    {
        internal TreeNode BTree { get; }
        public int maxDepth = 0;
        public Q104(string[] strs)
        {
            BTree = buildBinaryTree(strs);
            maxDepth = MaxDepth(BTree);
        }

        internal TreeNode buildBinaryTree(string[] strs)
        {
            TreeNode binaryTree = null;
            Queue currentQ = new Queue();

            TreeNode current;
            int currentVal = 0;

            if (strs.Count() > 0)
            {
                currentVal = int.Parse(strs[0]);

                binaryTree = new TreeNode(currentVal);
                current = binaryTree;

                TreeNode newTree;

                for (int i = 1; i < strs.Count(); i++)
                {
                    if (int.TryParse(strs[i], out currentVal))// 處理current的leftchild
                    {
                        newTree = new TreeNode(currentVal);// call constructor TreeNode(char s)
                        current.left = newTree;
                        currentQ.Enqueue(newTree);
                    }

                    if (!(++i < strs.Count()))// 有可能char array含有奇數筆資料
                        break;// 所以在這裡結束迴圈


                    if (int.TryParse(strs[i], out currentVal))// 處理current的rightchild
                    {
                        newTree = new TreeNode(currentVal);// call constructor TreeNode()
                        current.right = newTree;
                        currentQ.Enqueue(newTree);
                    }

                    current = (TreeNode)currentQ.Dequeue();// 從queue中更新current
                }

            }

            return binaryTree;
        }
        public int MaxDepth(TreeNode root)
        {
            if (root != null)
            {
                Console.WriteLine(root.val + " ");
                return 1 + Math.Max(MaxDepth(root.left), MaxDepth(root.right));
            }
            else return 0;

            /*
            TreeNode current = root;
            Queue currentQ = new Queue();

            currentQ.Enqueue(root);

            while (currentQ.Count != 0)
            {
                current = (TreeNode)currentQ.Dequeue();
                currentVal = current.val;
                Console.WriteLine(currentVal + " ");
                currentVal++;

                if (current.left != null)
                {
                    currentQ.Enqueue(current.left);
                }
                //else output = currentVal > output ? currentVal : output;

                if (current.right != null)
                {
                    currentQ.Enqueue(current.right);
                }
                //else output = currentVal > output ? currentVal : output;
            }
            */

        }
    }
}
