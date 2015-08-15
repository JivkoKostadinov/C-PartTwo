using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Problem_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter some hexadecimal number: ");
            string input = Console.ReadLine().ToUpper();
            BigInteger result = 0;
            for (int i = 0; i < input.Length; i++)
            {
                result = result * 16;
                if (input[i] < '9')
                    result = result + (input[i] - 48); // input[i] is a char value. '1'(as char) - 45 = 1 (as int)
                else
                    result = result + (input[i] - 55); // input[i] is a char value. 'A'(as char)= 65. 65 - 55 = 10
            }
            Console.WriteLine("Decimal representation of hexadecimal number 0x{0} is {1}", input, result);


        }
    }
}
