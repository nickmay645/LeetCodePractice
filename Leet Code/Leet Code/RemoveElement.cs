using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leet_Code
{
    class RemoveElementProblem
    {
        public int RemoveElement(int[] nums, int val)
        {
			int res = 0;

			for (int i = 0; i < nums.Length; i++)
			{
				if (nums[i] != val)
				{
					nums[res] = nums[i];
					res++;
				}
			}

			return res;
		}
    }
}
