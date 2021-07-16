using System;
using System.Collections.Generic;

namespace Leet_Code
{
    class LengthOfLongestSubstringProblem
    {
        public int LengthOfLongestSubstring(string s)
        {
            var result = 0;
            var list = new List<char>();

            for (var i = 0; i < s.Length; i++)
            {
                var pos = list.IndexOf(s[i]);
                if (pos != -1)
                {
                    list.RemoveRange(0, pos + 1);
                }
                list.Add(s[i]);
                result = Math.Max(result, list.Count);
            }

            return result;

        
        }
    }
}