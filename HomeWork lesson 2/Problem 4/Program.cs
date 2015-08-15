﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter length of the array: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter max value: ");
            int k = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            int maxValue = 0;
            for (int i = 0; i < n; i++)
            {
                Console.Write("arr[{0}]= ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(arr);
            for (int i = 0; i < n; i++)
            {

                if (arr[i] < k)
                {
                    maxValue = arr[i];
                }
            }
            Array.BinarySearch(arr, maxValue);
            if (arr[0] > k)
            {
                Console.WriteLine("No number is lesser than the given max value.");
            }
            else
            {
                Console.WriteLine("Max number lesser than the given max value is: {0}", maxValue);

            }
        }
    }
}
