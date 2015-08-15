using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selection_sort
{
    class Program
    {
        static void Main(string[] args)
        {
            // demo arrays
            //int[] numbers = {1,-3,-1,12,5,801,229,-13};
            //int[] numbers = { 1, -3, -1, 12, 5, 203, -507, 282, -3, 56, 8, -25, -26, -27, 801, 229, -13 };
            //int[] numbers = { -1, -3};
            int[] numbers = { 1, -2, 3, -4, 5, -6, -7, 8, -9, 11, 10 };

            // one loop to iterate through all the elements
            for (int i = 0; i < numbers.Length; i++)
            {
                // min will hold the index of the next minimal element
                int min = i;
                // loop to find the next minimal element, starting from 1+i, because the other are sorted
                for (int j = 1 + i; j < numbers.Length; j++)
                {
                    // if the minimal elements is bigger than any other, we have a new minimum
                    if (numbers[min] > numbers[j])
                    {
                        min = j;
                    }
                }

                // if the i-th element is the minimum, there is no need to swap
                if (i != min)
                {
                    numbers[i] += numbers[min];
                    numbers[min] = numbers[i] - numbers[min];
                    numbers[i] -= numbers[min];
                }

            }

            // print
            foreach (var item in numbers)
            {
                Console.WriteLine(item + " ");
            }




        }
    }
}
