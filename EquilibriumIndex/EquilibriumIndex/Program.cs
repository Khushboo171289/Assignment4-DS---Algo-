using System;

namespace EquilibriumIndex
{
    class Program
    {
        public static void Equilibrium(int[] a1, int n)
        {
            int TotalSum = 0;
            int LeftSum = 0;
            foreach (var item in a1)
            {
                TotalSum = TotalSum + item;
            }
            for (int i = 0; i < n; i++)
            {
                LeftSum = LeftSum + a1[i];

                if (LeftSum == TotalSum)
                {
                    Console.WriteLine($"Equilbrium found at index {i}");

                }
                else if (i == n)
                {
                    Console.WriteLine(-1);
                }

                TotalSum = TotalSum - a1[i];
            }

        }
        static void Main(string[] args)
        {
            int[] a;
            a = new int[] { -7, 1, 5, 2, -4, 3, 0 };
            Equilibrium(a, a.Length);
            Console.WriteLine();
        }
    }
}
