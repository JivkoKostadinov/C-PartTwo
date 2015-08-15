using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_search
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            //Console.WriteLine("Kashon.Length");
            //int size = int.Parse(Console.ReadLine());
            //int[] Kashon = new int[size];

            // initialize
            //for (int i = 0; i < Kashon.Length; i++)
            //{
            //    Kashon[i] = int.Parse(Console.ReadLine());
            //}

            // demo arrays
            int[] Kashon = Enumerable.Range(-20, 40).ToArray();
            // int[] Kashon = Enumerable.Range(0, 30).ToArray();
            // int[] Kashon = Enumerable.Range(-100,50).ToArray();



            // input key
            Console.WriteLine("Key:");
            int key = int.Parse(Console.ReadLine());

            // declare bounds, index and store variables
            int lowerBound = 0, upperBound = Kashon.Length, index = lowerBound + (upperBound - lowerBound) / 2;
            int found;

            // binary search algo
            do
            {
                // if the key of the item we're looking for is bigger then the current item, we operate on the right
                if (key > Kashon[index])
                {
                    lowerBound = index;
                }
                else if (key < Kashon[index]) // else operate on the left
                {
                    upperBound = index;
                }

                // update index
                index = lowerBound + (upperBound - lowerBound) / 2;


            } while (Kashon[index] != key && upperBound - lowerBound > 1);


            // print
            Console.WriteLine(Kashon[index] == key ? "Item with key {0} was found at {1}" : "Item with key {0} was not found", key, index);


        }
    }
}
