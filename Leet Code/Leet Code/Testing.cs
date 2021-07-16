using System;

namespace Leet_Code
{
    class Testing
    {
        static void Main(string[] args)
        {
            FindMedianSortedArraysProblem test = new();
            int[] nums1 = { 1, 3 };
            int[] nums2 = { 2, 7 };
            double result = test.FindMedianSortedArrays(nums1, nums2);
            Console.WriteLine(result);

        }
    }
}
