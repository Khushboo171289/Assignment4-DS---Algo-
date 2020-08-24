using System;
using System.Collections.Generic;

namespace SubArrayOfSum
{
    class Program
    {
        public static void SubArraysOfSum(int[] a1, int sum , int n)
        {
            //variable to keep the track of the sum of subarray till the i'th index in each loop
            int currsum =0;
            //variable to store the start of subarray with given sum
            int start = 0;  
            // a check to see if the sub array with given sum do not exist.. if check value will be same as '0' at the end of for loop
            // then the sub array with given index do not exist.
            int check=0;
            //to store the subarray sum from start of array till the i'th index in each iteration
            Dictionary<int, int> subarraySum = new Dictionary<int, int>();
          
            for (int i = 0; i < n; i++)
            {
                //add the i'th element of the array to the currsum
                currsum = currsum + a1[i];

                // If we get the desired sum by adding the elements from 0 to i, then print the result and exit from the loop.
                if (currsum == sum)
                {
                    Console.WriteLine($"Sum = {sum} found between indexes {start} and {i}");
                    check = i;
                    break;
                }
                //// If the cursum till i index minus the sum value is present in the hashmap.. we will print the result where the sub array with
                ///// given sum satrts at hashmap[currsum -sum] and end at i.
                if (subarraySum.ContainsKey(currsum - sum))
                {
                   
                    start = subarraySum[currsum - sum] + 1;
                    Console.WriteLine($"Sum = {sum} found between indexes {start} and {i}");
                    check = i;
                    break;
                }
                // if the key value pair of (currsum -sum) , is not present in the hash map add the surrntsum key pair value
                subarraySum[currsum] = i;     
            }
            if ( check == 0)
            {
                Console.WriteLine($"No subarray with given sum = {sum} exists");
            }
        }
        static void Main(string[] args)
        {
            int[] a;
            a = new int[] { -10, 0, 2, -2, -20, 10 };
            int sum =20;
            int n = a.Length;
            SubArraysOfSum(a, sum, n);
            Console.ReadLine();
        }
    }
}
