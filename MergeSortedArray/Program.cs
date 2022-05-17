using System;

namespace MergeSortedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] testA = { 1, 2, 3, 0, 0, 0 };
            int[] testb = { 2, 5, 6 };
            int n = 3;
            int m = 3;

            Print(Merge(testA, n, testb, m));
        }

        public static void Print(int[] results)
        {
            foreach(var value in results)
            {
                Console.WriteLine(value);
            }
        }

        public static int[] Merge(int[] firstArray, int firstLength, int[] secondArray, int secondLength)
        {
            // Sanity check
            if(firstArray.Length < 1 || secondArray.Length < 1)
            {
                return new int[0];
            }

            // Variables
            int[] results = new int[firstLength + secondLength];
            int firstPointer = firstLength;
            int secondPointer = secondLength;

            for(int i = results.Length; i >= 0; i--)
            {
                if(firstArray[firstPointer] > secondArray[secondPointer])
                {
                    results[i] = firstArray[firstPointer];
                    firstPointer--;
                } secondPointer--;
            }
            return results;
        }
    }
}
