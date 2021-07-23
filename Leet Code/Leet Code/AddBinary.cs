using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leet_Code
{
    class AddBinaryProblem
    {
        public string AddBinary(string a, string b)
        {
            var n1 = a.Length - 1;
            var n2 = b.Length - 1;
            var carry = 0;

            var result = new StringBuilder();

            while (carry > 0 || n1 >= 0 || n2 >= 0)
            {
                var c1 = n1 >= 0 ? a[n1] : '0';
                var c2 = n2 >= 0 ? b[n2] : '0';

                var sum = carry + (c1 - '0') + (c2 - '0');
                if (sum > 1)
                {
                    carry = 1;
                    sum = sum - 2;
                }
                else
                {
                    carry = 0;
                }

                result.Insert(0, sum);

                n1--;
                n2--;
            }

            return result.ToString();
        }
    }
}
