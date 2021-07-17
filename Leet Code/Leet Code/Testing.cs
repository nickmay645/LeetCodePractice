using System;

namespace Leet_Code
{
    class Testing
    {
        static void Main(string[] args)
        {
            PalindromeNumberProblem test = new();
            int x = -121;
            var result = test.IsPalindrome(x);
            Console.WriteLine(result);

        }
    }
}
