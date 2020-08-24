using System;

namespace MaxSumContiguousArray
{
    class Program
    {
        public static void SubArrayOfMaxSum(int[] a1, int n)
        {
            int start = 0;
            int end = 0;
            int beg = 0;

            int maxsum = 0;
            int maxnow = 0;

            for (int i = 0; i < a1.Length; i++)
            {
                maxnow = maxnow + a1[i];
                if (maxnow < 0)
                {
                    maxnow = 0;
                    beg = i + 1;

                }
                if (maxsum < maxnow)
                {
                    maxsum = maxnow;
                    start = beg;
                    end = i;
                }
            }
            Console.WriteLine($"The max sum of contiguous subarray is {maxsum} , starting from index {start} to {end}");
        }
        static void Main(string[] args)
        {
            int[] a1;
            a1 = new int[] { -2, -1, 3, 0, 4, -2};
            int n = a1.Length;
            SubArrayOfMaxSum(a1, n);
            Console.ReadLine();
        }
    }
}
