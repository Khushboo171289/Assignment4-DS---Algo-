using System;

namespace SubArrayOfGivenSum
{
    class Program
    {
        public static void SubArrayOfSum(int[] a1, int n, int sum)
        {
            int currsum = 0;
            int end;
            int start = 0;

            for (int i = 0; i < n; i++)
            {
                currsum = currsum + a1[i];
                end = i;

                while (currsum > sum && start < i)                
                {                    
                    currsum = currsum - a1[start];
                    start++;
                }
                if (currsum == sum && end != 0)
                {
                    Console.WriteLine($"Subarray sum {sum} is found between indexes {start} and {end}");
                    break;
                }
          
            }
            if(currsum != sum)
            Console.WriteLine($"No subarray with given sum {sum} found");
        }

        static void Main(string[] args)
        {
            int[] a;
            a = new int[] { 1, 4, 20, 3, 10, 5 };
            int sum =33;
            int n = a.Length;
            SubArrayOfSum(a,n,sum);
            Console.ReadLine();
        }
    }
}
