using System;

namespace ContinuousSubarraySum
{
    class Program
    {
        static void Main(string[] args)
        {
            int target1 = 6;
            int[] test1 = { 1, 1, 4, 5 };
            Console.WriteLine("Results: " + findSubArray(test1, target1));

            int target2 = 8;
            int[] test2 = { 1, 2, 4, 5 };
            Console.WriteLine("Results: " + findSubArray(test2, target2));

            int target3 = 8;
            int[] test3 = { 1 };
            Console.WriteLine("Results: " + findSubArray(test3, target3));

            int target4 = 7;
            int[] test4 = { 23, 2, 4, 6, 6 };
            Console.WriteLine("Results: " + findSubArray(test4, target4));

        }

        public static bool findSubArray(int[] value, int target)
        {
            
            if(value.Length <= 1)
            {
                return false;
            }

            int runningTotal = 0;
            

            for(int i = 0; i < value.Length; i++)
            {
                runningTotal += value[i];
                for (int j = i + 1; j < value.Length; j++)
                {

                    runningTotal += value[j];

                    if (runningTotal > target)
                    {
                        runningTotal = 0;
                    }

                    if (runningTotal == target)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
