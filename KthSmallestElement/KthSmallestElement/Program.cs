using System;

namespace KthSmallestElement
{
    class Program
    {
        public static void KthSmallestElement(int[] a1, int n)
        {
            int l = a1.Length;
            Array.Sort(a1);
            Console.WriteLine($"The {n}th smallest element in the array is {a1[l - n - 1]}");
        }
        static void Main(string[] args)
        {
            int[] a;
            a = new int[] { 7, 10, 4, 3, 20, 15 };
            int k = 4;
            Console.WriteLine($"For the below given array find the {k}th Smallest element from array");
            for (int i = 0; i < a.Length; i++)
            {                
                Console.Write($"{a[i]}, ");
            }
            Console.WriteLine();
            KthSmallestElement(a, k);
            Console.ReadLine();
            
        }
    }
}
