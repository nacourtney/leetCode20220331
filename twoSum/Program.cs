using System;
using System.Collections;
using System.Collections.Generic;

namespace twoSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int target = 6;
            int[] values = { 0, 1, 2, 3, 3 };

            Console.WriteLine("There are two numbers that add to target: " + findTwoSum(target, values));

            int target2 = 6;
            int[] values2 = { 0, 1, 2};

            Console.WriteLine("There are two numbers that add to target: " + findTwoSum(target2, values2));

            int target3 = 0;
            int[] values3 = { 1, 2, 3 };

            Console.WriteLine("There are two numbers that add to target: " + findTwoSum(target3, values3));

            int target4 = 1;
            int[] values4 = { };

            Console.WriteLine("There are two numbers that add to target: " + findTwoSum(target4, values4));
        }

        public static bool findTwoSum(int target, int[] values)
        {

            if(values.Length < 2)
            {
                throw new Exception("Enter a valid int array. ");
            }

            Hashtable sums = new Hashtable();

            foreach(var value in values)
            {
                if (!sums.ContainsKey(value))
                {
                    sums.Add(value, 1);
                } else
                {
                    sums[value] = (int)sums[value] + 1;
                }
            }

            foreach(var value in values)
            {
                if (sums.ContainsKey(target - value))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
