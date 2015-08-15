using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = 10000000;
            bool[] isNotPrime = new bool[n];

            for (int i = 2; i < n; i++)
            {
                if (!isNotPrime[i])
                {
                    // generate all numbers that are a product
                    for (int j = 2; i * j < n; j++)
                    {
                        isNotPrime[i * j] = true;
                    }
                }
            }


            for (int i = 2; i < n; i++)
            {
                if (!isNotPrime[i])
                {
                    Console.Write(i + ",");
                }
            }
        }
    }
}



     
