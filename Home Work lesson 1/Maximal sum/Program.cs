using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maximal_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            // input size and allocate
            Console.WriteLine("Size:");
            int size = int.Parse(Console.ReadLine());
            int[] numbers = new int[size];

            // initialize
            Console.WriteLine("Array:");
            for (int i = 0; i < size; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            // declare helpers

            // start and end will hold the beggining and the end of the sequence with the largest sum,
            // tempStart will be used for comparison
            int start, end, tempStart;
            start = end = tempStart = 0;
            int maxSum = int.MinValue, sum = 0;

            // iterate through the elements
            for (int i = 0; i < size; i++)
            {
                // update the sum
                sum += numbers[i];
                // if sum > maxSum, we have a new largest sum
                if (sum > maxSum)
                {
                    maxSum = sum;
                    end = i; // if new largest sum, we'll also have a new end
                    start = tempStart;
                }
                // if the sum of the current sequence is <= 0, it is meaningless to add it to the sequence, so we reset
                if (sum <= 0)
                {
                    sum = 0;
                    tempStart = i + 1; // we'll be looking for a new sequence, so we'll start from the next element
                }

            }

            // print the sequence
            for (int i = start; i <= end; i++)
            {
                Console.Write(numbers[i] + (i != end ? ", " : ""));
            }

            Console.WriteLine();



        }
    }
}
