using System;

namespace Leet_Code
{
    class FindMedianSortedArraysProblem
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int length = nums1.Length + nums2.Length;
            var mergedArray = new int[length];
            double th = length / 2;

            int count = 0;

            for (int i = 0; i < nums1.Length; i++)
            {
                int item = nums1[i];
                mergedArray[count] = item; count++;
            }
            for (int i = 0; i < nums2.Length; i++)
            {
                int item = nums2[i];
                mergedArray[count] = item; count++;
            }
            Array.Sort(mergedArray);

            if (length % 2 == 1)
            {
                return mergedArray[(int)th];
            }
            else
            {
                double sum = mergedArray[(int)th] + mergedArray[(int)th - 1];

                return (double)(sum / 2);
            }
        }
    }
}