using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leet_Code
{
    class PlusOneProblem
    {
        public int[] PlusOne(int[] digits)
        {
            digits[digits.Length-1]++;
            return digits;
        }
    }
}
