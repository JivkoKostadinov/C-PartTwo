using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class FirstLargerThanNeighbours
{
    static int CheckNeighbors(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == 0)
            {
                if (arr[i] > arr[i + 1])
                {
                    return i;
                }
            }
            else if (arr[i] == arr.Length - 1)
            {
                if (arr[i] > arr[i - 1])
                {
                    return i;
                }
            }
            else if (arr[i] > arr[i + 1] && arr[i] > arr[i - 1])
            {
                return i;
            }
        }
        return -1;
    }

    static void Main()
    {
        int[] arr = { 2, 3, 1, 4, 7, 5, 10 };
        Console.WriteLine("First element larger that its neighbors has index: {0}", CheckNeighbors(arr));
    }
}
