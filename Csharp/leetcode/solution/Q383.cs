using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.solution
{
    class Q383
    {
        public bool CanConstruct(string ransomNote, string magazine)
        {
            int[] charArr = new int[26];
            for (int i = 0; i < magazine.Length; i++)
            {
                charArr[magazine[i] - 'a']++;
            }

            for (int j = 0; j < ransomNote.Length; j++)
            {
                if (--charArr[ransomNote[j] - 'a'] < 0) return false;
            }
            return true;
        }
    }
}
