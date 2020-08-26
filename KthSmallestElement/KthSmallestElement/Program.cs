using System;

namespace KthSmallestElement
{
    class Program
    {
        public static int KthSmallestElement(int[] a, int k)
        {
            int n = a.Length;
            int left = 0;
            int right = n - 1;

            Random random = new Random(0);
            while (left <= right)            {
                int pivot = random.Next(right - left + 1) + left;
                int CorrectPivotPosition = partition(a, left, right, pivot);

                if (CorrectPivotPosition == (k-1))
                {
                    return a[CorrectPivotPosition];
                }
                else if(CorrectPivotPosition > (k-1))
                {
                    right = CorrectPivotPosition - 1;
                }
                else
                {
                    left = CorrectPivotPosition + 1;
                }
            }
            return -1;
        }

        private static int partition(int[] a, int left, int right, int pivot)
        {
            int pivotValue = a[pivot];
            int l = left;

            swap(a, pivot, right);

            for (int i = l; i <= right-1; i++)
            {
                if (a[i] < pivotValue)
                {
                    swap(a, i, l);
                    l++;
                }
            }
            swap(a, right, l);
            return l;
        }
        private static void swap(int[] a1, int i, int j)
        {
            int temp = a1[i];
            a1[i] = a1[j];
            a1[j] = temp;
        }

        static void Main(string[] args)
        {
            int[] a;
            a = new int[] { 7, 10, 4, 3, 20, 15 };
            int k = 4;
            int n = a.Length;
            Console.WriteLine($"For the below given array find the {k}th Smallest element from array");
            for (int i = 0; i < a.Length; i++)
            {                
                Console.Write($"{a[i]}, ");
            }
            Console.WriteLine();
              int kthElement = KthSmallestElement(a, k);            
            Console.WriteLine($"The {k}th smallest element in given array is {kthElement}.");
            Console.ReadLine();
            
        }
    }
}
