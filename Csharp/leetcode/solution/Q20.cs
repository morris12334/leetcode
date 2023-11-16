using System.Collections.Generic;

namespace leetcode.solution
{
    class Q20
    {
        public bool IsValid(string s)
        {
            bool output = true;
            Stack<char> a = new Stack<char>();
            foreach (char now in s.ToCharArray())
            {
                if (output)
                {
                    switch (now)
                    {
                        case '{':
                            a.Push('{');
                            break;
                        case '[':
                            a.Push('[');
                            break;
                        case '(':
                            a.Push('(');
                            break;
                        case '}':
                            if (a.Count == 0)
                                output = false;
                            else if (a.Pop() != '{')
                                output = false;
                            break;
                        case ']':
                            if (a.Count == 0)
                                output = false;
                            else if (a.Pop() != '[')
                                output = false;
                            break;
                        case ')':
                            if (a.Count == 0)
                                output = false;
                            else if (a.Pop() != '(')
                                output = false;
                            break;
                    }
                }
                else
                    break;
            }
            if (a.Count != 0) output = false;
            return output;
        }
    }
}