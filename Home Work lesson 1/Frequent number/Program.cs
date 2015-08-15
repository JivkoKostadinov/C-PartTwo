using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frequent_number
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


            // use array sort so we can use a simple algorithm
            Array.Sort(numbers);

            // declare helpers
            int count = 0, tempcount = 0;
            int Element = 0; // store the most frequent element here


            for (int i = 1; i < size; i++)
            {
                while (i < size)
                {
                    if (numbers[i - 1] == numbers[i])
                    {
                        tempcount++;
                        i++;
                    }
                    else
                    {
                        break;
                    }

                }

                if (count <= tempcount && Element < numbers[i - 1])
                {
                    Element = numbers[i - 1];
                    count = tempcount;
                    tempcount = 0;
                }
                // reset
                tempcount = 0;
            }

            Console.WriteLine(Element);



        }
    }
}
