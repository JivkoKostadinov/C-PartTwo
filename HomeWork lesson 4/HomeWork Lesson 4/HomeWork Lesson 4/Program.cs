using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HomeWork_Lesson_4
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter positive decimal number: ");
            long input = long.Parse(Console.ReadLine());
            StringBuilder stringBuilder = new StringBuilder();
            Console.Write("Binary representation of {0} is ", input);
            while (input > 0)
            {
                stringBuilder.Insert(0, input % 2); // insert '0' or '1' at beginning of string
                input = input / 2;
            }
            Console.WriteLine(stringBuilder.ToString().PadLeft(32, '0'));
        }
    }
}
