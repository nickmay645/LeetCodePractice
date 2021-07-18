using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leet_Code
{
    class LengthofLastWord
    {
        public int LengthOfLastWord(string s)
        {
			var lastCount = 0;
			foreach (var c in s.Trim())
			{
				if (c == ' ')
				{
					lastCount = 0;
				}
				else
				{
					lastCount++;
				}
			}

			return lastCount;
		}
    }
}
