using System;

namespace Leet_Code
{
    class Testing
    {
        static void Main(string[] args)
        {
            PlusOneProblem test = new();
            int[] digits = { 1, 2, 3 };
            var result = test.PlusOne(digits);
            foreach(var item in result)
            {
                Console.WriteLine(item);
            }
            

        }
    }
}
