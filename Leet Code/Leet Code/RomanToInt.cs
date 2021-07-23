using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leet_Code
{
    class RomanToIntProblem
    {
        public int RomanToInt(string s)
        {
            Dictionary<string, int> romanMap = new Dictionary<string, int>();
            romanMap.Add("I", 1);
            romanMap.Add("IV", 4);
            romanMap.Add("V", 5);
            romanMap.Add("IX", 9);
            romanMap.Add("X", 10);
            romanMap.Add("XL", 40);
            romanMap.Add("L", 50);
            romanMap.Add("XC", 90);
            romanMap.Add("C", 100);
            romanMap.Add("CD", 400);
            romanMap.Add("D", 500);
            romanMap.Add("CM", 900);
            romanMap.Add("M", 1000);

            int val = 0;

            for (int i = 0; i < s.Length; i++)
            {
                //check for pair
                if (i< s.Length-1 && romanMap.ContainsKey(s.Substring(i, 2)))
                {
                    val += romanMap[s.Substring(i, 2)];
                    i++;
                }
                else
                {
                    val += romanMap[s[i].ToString()];
                }


            }
            return val;
        }
    }
}
