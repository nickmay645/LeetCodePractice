using System;

namespace Leet_Code
{
    class Testing
    {
        static void Main(string[] args)
        {
            AddBinaryProblem test = new();
            var result = test.AddBinary("10001", "110110");
            Console.WriteLine(result);
            //foreach(var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            

        }
    }
}
