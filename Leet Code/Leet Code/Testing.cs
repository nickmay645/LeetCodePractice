using System;

namespace Leet_Code
{
    class Testing
    {
        static void Main(string[] args)
        {
            ValidParentheses test = new();
            string strs = "(]";
            var result = test.IsValid(strs);
            Console.WriteLine(result);

        }
    }
}
