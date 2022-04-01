using System;
using System.Collections.Generic;
using System.Text;

/*

Problem: Binary Search - 704  

Given an array of integers nums which is sorted in ascending order, and an integer target,
write a function to search target in nums. If target exists, then return its index. 
Otherwise, return -1.

You must write an algorithm with O(log n) runtime complexity.

*/

namespace leetCode20220331
{
    class Solution
    {
        static void Main(string[] args)
        {
            // Best Case:
            int[] nums = { -1, 0, 3, 5, 9, 12 };
            int target = 3;
            int test1 = Search(nums, target);
            Console.WriteLine("Result: {0}", test1);

            // Edge Cases:
            int[] nums2 = { -1, 0, 3, 5, 9, 12 };
            int target2 = -1;
            int test2 = Search(nums2, target2);
            Console.WriteLine("Result: {0}", test2);

            int[] nums3 = { -1, 0, 3, 5, 9, 12 };
            int target3 = 12;
            int test3 = Search(nums3, target3);
            Console.WriteLine("Result: {0}", test3);

            // Worst Case:
            int[] nums4 = { -1, 0, 3, 5, 9, 12 };
            int target4 = 2;    // 2 is not in the nums array; should return -1
            int test4 = Search(nums4, target4);
            Console.WriteLine("Result: {0}", test4);

            int[] nums5 = new int[0];   // Array is empty; should return -1
            int target5 = 12;
            int test5 = Search(nums5, target5);
            Console.WriteLine("Result: {0}", test5);

        }
        public static int Search(int[] nums, int target)
        {
            int low = 0;
            int high = nums.Length - 1;
            int mid = getNewMid(low, high);
           
            if(nums.Length == 0)
            {
                return -1;
            }
            
           while(low <= high)
           {
                if(nums[mid] == target)
                {
                    return mid;
                }

                if(nums[mid] < target)
                {
                    low = mid+1;
                    mid = getNewMid(low, high);
                }

                if(nums[mid] > target)
                {
                    high = mid-1;
                    mid = getNewMid(low, high);
                }
            }
            return -1;
        }

        public static int getNewMid(int low, int high)
        {
            return ((high + low) / 2);
        }
    }
}
