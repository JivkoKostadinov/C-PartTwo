using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_5
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter length of the array: ");
            int n = int.Parse(Console.ReadLine());
            string[] arr = new string[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("arr[{0}]= ", i);
                arr[i] = Console.ReadLine();
            }
            Array.Sort(arr, (x, y) => x.Length.CompareTo(y.Length));
            foreach (string str in arr)
            {
                Console.WriteLine(str);
            }
            Console.WriteLine();
        }
    }
}
