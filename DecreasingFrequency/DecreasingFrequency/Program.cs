using System;
using System.Collections.Generic;
using System.Linq;

namespace DecreasingFrequency
{
    class Program
    {
        public static void ElementFrequency(int[] a1, int n)
        {

            Dictionary<int, int> temp = new Dictionary<int, int>();
            
            int count = 1;
            for (int i = 0; i < n; i++)
            {

                if (!temp.ContainsKey(a1[i]))
                {
                    temp.Add(a1[i], count);
                }
                else
                {
                    temp[a1[i]]++;
                }
               
            }
            foreach (var item in temp.OrderByDescending(i => i.Value))
            {
                int occurance = item.Value;
                while (occurance != 0)
                {
                    Console.Write($"{item.Key}, ");
                    occurance--;
                }
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int[] a10;
            a10 = new int[] { 2, 5, 2, 6, -1, 9999999, 5, 8, 8, 8 };
            ElementFrequency(a10, a10.Length);
            Console.ReadLine();
        }
    }
}
