using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work_lesson_1
{
    class Program
    {
        static void Main()
        {
            int[] arr = new int[20];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i * 5;
            }
            Console.WriteLine(string.Join(",",arr));


        }
    }
}
