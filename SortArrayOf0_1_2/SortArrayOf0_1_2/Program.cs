using System;

namespace SortArrayOf0_1_2
{
    class Program
    {
        public static void SortArray(int[] a1, int n)
        {
            int c0 = 0, c1 = 0, c2 = 0;
            int count = 0;
            int i;
            for ( i = 0; i < n; i++)
            {
                if ((a1[i] * 1) == 0)
                {
                    c0++;                   
                }
                if ((a1[i] * 1) == 1)
                {
                    c1++;                
                }
                if ((a1[i] * 1) == 2)
                {
                    c2++;                  
                }
            }
            while (c0 > 0)
            {
                a1[count] = 0;
                count++;
                c0--;
            }
            while (c1 > 0)
            {
                a1[count] = 1;
                count++;
                c1--;
            }
            while (c2 > 0)
            {
                a1[count] = 2;
                count++;
                c2--;
            }
            for ( i = 0; i < n; i++)
            {
                Console.Write($"{a1[i]}, ");
            }
        }
        static void Main(string[] args)
        {
            int[] a;
            a = new int[] { 0, 2, 1, 0, 0, 1, 2, 0, 1, 2, 0 };
            int n = a.Length;
            SortArray(a, n);
            Console.ReadLine();
        }
    }
}
