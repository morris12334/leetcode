using leetcode.solution;
using System;
using System.Collections.Generic;

namespace leetcode
{
    class Program
    {
        static void Main(string[] args)
        {
            string exitCode = "";
            Solution leetcode = new Solution();
            while (exitCode == "")
            {
                Console.WriteLine("輸入exit離開");
                string cmdtxt = Console.ReadLine();
                string str, ans;
                string[] strs;
                int num, num1, num2;
                int[] nums, nums1, nums2;
                bool bol;
                char[][] matrix;
                List<object[]> matrix2 = new List<object[]>();

                switch (cmdtxt)
                {
                    case "exit":
                    case "e":
                        exitCode = "exit";
                        break;

                    case "20"://https://leetcode.com/problems/valid-parentheses/description/
                        Console.WriteLine("20. Valid Parentheses");
                        str = Console.ReadLine();
                        Console.WriteLine("return = " + leetcode.Q20(str));
                        break;

                    case "53"://https://leetcode.com/problems/maximum-subarray/description/
                        Console.WriteLine("53. Maximum Subarray");
                        strs = Console.ReadLine().Split(',');
                        nums = Array.ConvertAll(strs, int.Parse);
                        Console.WriteLine("return = " + leetcode.Q53(nums));
                        break;

                    case "58"://https://leetcode.com/problems/length-of-last-word/description/
                        Console.WriteLine("58. Length of Last Word");
                        str = Console.ReadLine();
                        Console.WriteLine("return = " + leetcode.Q58(str));
                        break;
                    case "70"://https://leetcode.com/problems/climbing-stairs/description/
                        //TODO
                        Console.WriteLine("70. Climbing Stairs");
                        num = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("return = " + leetcode.Q70(num));
                        break;

                    case "104"://https://leetcode.com/problems/maximum-depth-of-binary-tree/
                        Console.WriteLine("104. Maximum Depth of Binary Tree");
                        strs = Console.ReadLine().Split(',');
                        num = new Q104(strs).maxDepth;
                        Console.WriteLine("return = " + num);
                        break;

                    case "124"://https://leetcode.com/problems/binary-tree-maximum-path-sum/
                    case "3314"://https://leetcode.com/explore/other/card/30-day-leetcoding-challenge/532/week-5/3314/
                        Console.WriteLine("124. Binary Tree Maximum Path Sum");
                        strs = Console.ReadLine().Split(',');
                        num = new Q124(strs).maxPathSum;
                        Console.WriteLine("return = " + num);
                        break;

                    case "136"://https://leetcode.com/problems/single-number/
                    case "3283"://https://leetcode.com/explore/other/card/30-day-leetcoding-challenge/528/week-1/3283/
                        Console.WriteLine("136. Single Number");
                        strs = Console.ReadLine().Split(',');
                        nums = Array.ConvertAll(strs, int.Parse);
                        num = new Q136().SingleNumber(nums);
                        Console.WriteLine("return = " + num);
                        break;

                    case "169"://https://leetcode.com/problems/majority-element/
                        Console.WriteLine("169. Majority Element");
                        strs = Console.ReadLine().Split(',');
                        nums = Array.ConvertAll(strs, int.Parse);
                        num = new Q169().MajorityElement(nums);
                        Console.WriteLine("return = " + num);
                        break;

                    case "201"://https://leetcode.com/problems/bitwise-and-of-numbers-range/
                    case "3308"://https://leetcode.com/explore/other/card/30-day-leetcoding-challenge/531/week-4/3308/
                        Console.WriteLine("201. Bitwise AND of Numbers Range");
                        strs = Console.ReadLine().Split(',');
                        nums = Array.ConvertAll(strs, int.Parse);
                        num = new Q201().RangeBitwiseAnd(nums[0], nums[1]);
                        Console.WriteLine("return = " + num);
                        break;

                    case "202"://https://leetcode.com/problems/happy-number/
                    case "3284"://https://leetcode.com/explore/other/card/30-day-leetcoding-challenge/528/week-1/3284/
                        Console.WriteLine("202. Happy Number");
                        num = Convert.ToInt32(Console.ReadLine());
                        bol = new Q202().IsHappy(num);
                        Console.WriteLine("return = " + bol);
                        break;

                    case "221"://https://leetcode.com/problems/maximal-square/
                    case "3312"://https://leetcode.com/explore/other/card/30-day-leetcoding-challenge/531/week-4/3312/
                        Console.WriteLine("221. Maximal Square");
                        //matrix2.Add = Console.ReadLine().Split(',');
                        matrix = new char[][] {
                           new char[]  {'1'}
                            /*
                           new char[]  {'1','1','1','0','0'},
                           new char[]  {'1','0','1','1','1'},
                           new char[]  {'1','1','1','1','1'},
                           new char[]  {'1','0','0','1','0'}
                           */
                        };
                        num = new Q221().MaximalSquare(matrix);
                        Console.WriteLine("return = " + num);
                        break;

                    case "334"://https://leetcode.com/problems/reverse-string/description/
                        Console.WriteLine("344. Reverse String");
                        str = Console.ReadLine();
                        Console.WriteLine("return = " + leetcode.Q334(str));
                        break;
                    case "349"://https://leetcode.com/problems/intersection-of-two-arrays/
                        Console.WriteLine("349. Intersection of Two Arrays");
                        nums1 = Array.ConvertAll(Console.ReadLine().Split(','), int.Parse);
                        nums2 = Array.ConvertAll(Console.ReadLine().Split(','), int.Parse);
                        Console.WriteLine("return = " + new Q349().Intersection(nums1, nums2));
                        break;

                    case "383"://https://leetcode.com/problems/ransom-note/
                        Console.WriteLine("383. Ransom Note");
                        strs = Console.ReadLine().Split(',');
                        bol = new Q383().CanConstruct(strs[0], strs[1]);
                        Console.WriteLine("return = " + bol);
                        break;

                    case "387"://https://leetcode.com/problems/first-unique-character-in-a-string/
                        Console.WriteLine("387. First Unique Character in a String");
                        str = Console.ReadLine();
                        num = new Q387().FirstUniqChar(str);
                        Console.WriteLine("return = " + num);
                        break;

                    case "476"://https://leetcode.com/problems/number-complement/
                        Console.WriteLine("476. Number Complement");
                        num = Convert.ToInt32(Console.ReadLine());
                        num = new Q476().FindComplement(num);
                        Console.WriteLine("return = " + num);
                        break;

                    case "509"://https://leetcode.com/problems/fibonacci-number/
                        Console.WriteLine("509. Fibonacci Number");
                        num = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("return = " + leetcode.Q509(num));
                        break;

                    case "970"://https://leetcode.com/problems/powerful-integers/
                        Console.WriteLine("970. Powerful Integers");
                        strs = Console.ReadLine().Split(',');
                        nums = Array.ConvertAll(strs, int.Parse);
                        Console.WriteLine("return = " + String.Join(",", leetcode.Q970(nums[0], nums[1], nums[2])));
                        break;

                    case "993"://https://leetcode.com/problems/cous
                        Console.WriteLine("993. Cousins in Binary Tree");
                        strs = Console.ReadLine().Split(',');
                        num1 = Convert.ToInt32(Console.ReadLine());
                        num2 = Convert.ToInt32(Console.ReadLine());
                        bol = new Q993(strs, num1, num2).isCousins;
                        Console.WriteLine("return = " + bol);
                        break;

                    case "1138"://https://leetcode.com/problems/alphabet-board-path/
                        Console.WriteLine("1138. Alphabet Board Path");
                        str = Console.ReadLine();
                        ans = new Q1138().AlphabetBoardPath(str);
                        Console.WriteLine("return = " + ans);
                        break;

                    case "560"://https://leetcode.com/problems/subarray-sum-equals-k/
                    case "3307"://https://leetcode.com/explore/other/card/30-day-leetcoding-challenge/531/week-4/3307/
                        Console.WriteLine("560. Subarray Sum Equals K");
                        strs = Console.ReadLine().Split(',');
                        nums = Array.ConvertAll(strs, int.Parse);
                        num = Convert.ToInt32(Console.ReadLine());
                        num = new Q560().SubarraySum(nums, num);
                        Console.WriteLine("return = " + num);
                        break;
                }
            }
        }
    }
}