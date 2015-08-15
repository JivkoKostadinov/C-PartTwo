using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maximal_K_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            // get size-related input
            Console.WriteLine("N:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("K");
            int k = int.Parse(Console.ReadLine());

            // allocate and initialize
            int[] arr = new int[n];
            Console.WriteLine("Array:");
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(arr);

            string elements = "";

            for (int i = arr.Length - 1; i > arr.Length - 1 - k; i--)
            {
                elements += arr[i] + ",";
            }

            Console.WriteLine(elements.TrimEnd(','));


        }
    }
}
