using System;
using System.Text;

namespace leetcode.solution
{
    class Q1138
    {
        public string AlphabetBoardPath(string target)
        {
            var output = new StringBuilder();
            int nowX = 0, nowY = 0;

            foreach (char a in target.ToCharArray())
            {
                int x = (a - 'a') % 5 - nowX;
                int y = (a - 'a') / 5 - nowY;

                if (checkNowZ(a))
                {
                    output.Append(moveRL(x));
                    output.Append(moveUD(y));
                }
                else
                {
                    output.Append(moveUD(y));
                    output.Append(moveRL(x));
                }

                nowX = (a - 'a') % 5;
                nowY = (a - 'a') / 5;

                output.Append("!");
            }
            return output.ToString();
        }

        private string moveRL(int x)
        {
            char move = 'L';
            if (x > 0) move = 'R';
            //else if (x < 0) move = 'L';

            return new string(move, Math.Abs(x));
        }
        private string moveUD(int y)
        {
            char move = 'U';
            if (y > 0) move = 'D';
            //else if (y < 0) move = 'U'; 

            return new string(move, Math.Abs(y));
        }

        private bool checkNowZ(char z) { return z == 'z'; }
    }
}
