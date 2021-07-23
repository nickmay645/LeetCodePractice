using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leet_Code
{
    class LongestCommonPrefixProblem
    {
        public string LongestCommonPrefix(string[] strs)
        {
            // pre = prefix
            // minValue = shortest string in array
            string pre = String.Empty;
            string minValue = strs[0];

            //get shortest string length
            foreach (var str in strs)
            {
                if (str.Length < minValue.Length)
                {
                    minValue = str;
                }
            }

            // iterate through characters in shortest string
            for (int i = 0; i < minValue.Length; i++)
            {
                // compare characters at index for each string in array to shortest string
                foreach (var str2 in strs)
                {
                    if (str2[i] != minValue[i])
                    {
                        return pre;
                    }
                }
                pre += minValue[i];
            }
            return pre;
        }
    }
}
