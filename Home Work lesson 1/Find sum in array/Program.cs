using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_sum_in_array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Size:");
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine("S:");
            int s = int.Parse(Console.ReadLine());
            Console.WriteLine("Array:");

            int[] numbers = new int[size];
            for (int i = 0; i < size; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }


            bool exists = false;


            // for every number, generate the combinations that start with him
            for (int i = 0; i < size && !exists; i++)
            {
                // helpers
                int sum = numbers[i];
                string sequence = numbers[i] + ",";

                for (int j = i + 1; j < size && !exists; j++)
                {
                    // update sum and sequence
                    sum += numbers[j];
                    sequence += numbers[j] + ",";

                    // if we find any valid sequence, print it and set exists, so we break the loops
                    if (sum == s)
                    {
                        Console.WriteLine(sequence.TrimEnd(','));
                        exists = true;
                    }

                }

            }
        }
    }
}




        