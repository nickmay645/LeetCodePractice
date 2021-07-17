using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leet_Code
{
    class LongestPalindromeProblem
    {
        public string LongestPalindrome(string s)
        {
			if (s.Length == 1) { return s; }

			string currentPalindrome;
			string longestPalindrome = String.Empty;

			int leftIndex;
			int rightIndex;
			for (int letterIndex = 0; letterIndex < s.Length - 1; letterIndex++)
			{
				if (longestPalindrome.Length / 2 > s.Length - letterIndex + 1) { break; }

				currentPalindrome = string.Empty;
				leftIndex = letterIndex;
				rightIndex = letterIndex;

				if (s[letterIndex].Equals(s[letterIndex + 1]))
				{
					var center = getCenter(s, rightIndex);
					currentPalindrome = center.Item1;
					rightIndex = center.Item2;
					leftIndex--;
				}

				while (leftIndex > -1 && rightIndex < s.Length && s[leftIndex].Equals(s[rightIndex]))
				{
					if (currentPalindrome.Equals(string.Empty))
					{
						currentPalindrome = s[rightIndex].ToString();
					}
					else
					{
						currentPalindrome = s[leftIndex] + currentPalindrome + s[rightIndex];
					}

					leftIndex--;
					rightIndex++;
				}

				if (currentPalindrome.Length > longestPalindrome.Length)
				{
					longestPalindrome = currentPalindrome;
				}
			}

			return longestPalindrome;
		}

		(string, int) getCenter(string s, int currentIndex)
		{
			string center = s[currentIndex].ToString();
			while (currentIndex < s.Length - 1 && s[currentIndex].Equals(s[currentIndex + 1]))
			{
				center += s[currentIndex];
				currentIndex++;
			}

			return (center, currentIndex + 1);
		}

    }
}
