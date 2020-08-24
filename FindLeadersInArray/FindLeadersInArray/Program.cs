using System;

namespace FindLeadersInArray
{
    class Program
    {
        public static void FindLeaders(int[] a1, int n)
        {
            int max = 0;

            for (int i = n - 1; i >= 0; i--)
            {
                if (a1[i] > max)
                {
                    max = a1[i];
                    Console.WriteLine(a1[i]);
                }
            }
        }
        static void Main(string[] args)
        {
            int[] a7;
            a7 = new int[] { 16, 17, 4, 3, 5, 2 };
            FindLeaders(a7, a7.Length);
            Console.ReadLine();
            
        }
    }
}
