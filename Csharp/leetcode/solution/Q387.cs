namespace leetcode.solution
{
    class Q387
    {
        public int FirstUniqChar(string s)
        {
            int[] charArr = new int[26];
            for (int i = 0; i < s.Length; i++)
            {
                charArr[s[i] - 'a']++;
            }

            for (int j = 0; j < s.Length; j++)
            {
                if (charArr[s[j] - 'a'] == 1) return j;
            }
            return -1;
        }
    }
}
