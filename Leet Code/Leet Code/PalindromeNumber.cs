using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leet_Code
{
    class PalindromeNumberProblem
    {
        public bool IsPalindrome(int x)
        {
            string num = x.ToString();
            int reverseCount = num.Length - 1;

            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] != num[reverseCount])
                {
                    return false;
                }
                reverseCount--;
            }
            return true;
        }
    }
}
