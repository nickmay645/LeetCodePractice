using System;

namespace Leet_Code
{
    class TwoSumProblem
    {
        //static void Main(string[] args)
        //{

        //    TwoSumProblem prog = new TwoSumProblem();
            
        //    // Testing Variables and Code
        //    int[] nums = { 2, 7, 11, 15 };
        //    int target = 9;
        //    int[] a = prog.TwoSum(nums, target);
        //    foreach (var item in a)
        //    {
        //        Console.WriteLine(item);
        //    }
        //}

        /*
        Given an array of integers nums and an integer target, 
        return indices of the two numbers such that they add up to target.

        You may assume that each input would have exactly one solution, 
        and you may not use the same element twice.

        You can return the answer in any order.
         */
        public int[] TwoSum(int[] nums, int target)
        {
        for(int i = 0; i<nums.Length; i++)
            {
                for(int j = i+1; j<nums.Length; j++)
                {
                    if(nums[j] == target - nums[i])
                    {
                        return new int[] { i, j };
                    }
                }
            }
        throw new ArgumentException("Not found");
        }
    
    }
}


