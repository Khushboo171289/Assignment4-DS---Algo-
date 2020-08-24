using System;

namespace MissingNumber
{
    class Program
    {
        public static void MissingNumInList(int[] a1, int n)
        {
            int listTotal = 0;
            foreach (var item in a1)
            {
                Console.Write($"{item} ,");
            }
            Console.WriteLine();
            foreach (var item in a1)
            {
                listTotal = listTotal + item;
            }
            int total = (n * (n + 1)) / 2;
            int missingNumber = total - listTotal;
            Console.WriteLine($"Missing number from the list of 1 to {n} is {missingNumber}");

        }
        static void Main(string[] args)
        {
            int[] a;
            a = new int[] { 1, 2, 3, 4, 5, 6, 8, 9 };
            int n = 9;

            MissingNumInList(a, n);
            Console.ReadLine();
        }
    }
}
