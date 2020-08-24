using System;

namespace PrintSpiral2DArray
{
    class Program
    {
        public static void SpiralArray(int[,] a1, int m, int n)
        {
            int T = 0, L = 0;
            int B = m - 1;
            int R = n - 1;
            int dir = 0;
            while (T <= B && L <= R)
            {
                if (dir == 0)
                {
                    for (int i = L; i <= R; i++)
                    {
                        Console.Write($"{a1[T, i]}, ");
                    }
                    T++;
                    dir = 1;
                }
                if (dir == 1)
                {
                    for (int i = T; i <= B; i++)
                    {
                        Console.Write($"{a1[i, R]}, ");
                    }
                    R--;
                    dir = 2;
                }
                if (dir == 2)
                {
                    for (int i = R; i >= L; i--)
                    {
                        Console.Write($"{a1[B, i]}, ");
                    }
                    B--;
                    dir = 3;
                }
                if (dir == 3)
                {
                    for (int i = B; i >= T; i--)
                    {
                        Console.Write($"{a1[i, L]}, ");
                    }
                    L++;
                    dir = 0;
                }
            }

        }
        static void Main(string[] args)
        {
            int[,] a;
            a = new int[,] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 }, { 13, 14, 15, 16 } };
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write($"{a[i, j]} ");
                }

                Console.WriteLine();
            }
            Console.WriteLine("Spiral Print of given 2D array");
            Console.WriteLine();
            SpiralArray(a, 4, 4);
            Console.WriteLine();
        }
    }
}
