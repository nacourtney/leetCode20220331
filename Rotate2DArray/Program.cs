using System;

namespace Rotate2DArray
{
    class Program
    {
        private static int N = 4;
        static void Main(string[] args)
        {
            int[,] test1 = { 
                { 1, 1, 1, 1 },
                { 2, 2, 2, 2 },
                { 3, 3, 3, 3 },
                { 4, 4, 4, 4 }
            };

            int[,] test2 = new int[N, N];

            Transpose(test1, test2);
        }

        public static int[,] Transpose(int[,] original, int[,] filler)
        {
            for(int i = 0; i < N; i++)
            {
                for(int j = 0; j < N; j++)
                {
                    filler[i, j] = original[j, i];
                }
            }


            return filler;
        }
    }
}
