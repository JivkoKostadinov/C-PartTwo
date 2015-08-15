using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Problem_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a binary number:");
            string input = Console.ReadLine();
            BigInteger binaryNum = BigInteger.Parse(input);
            int power = 0;
            BigInteger result = 0;
            while (binaryNum > 0)
            {
                BigInteger digit = (BigInteger)binaryNum % 10;
                digit *= (int)Math.Pow(2, (double)power);
                result += digit;
                power++;
                binaryNum /= 10;
            }
            Console.WriteLine("Decimal: " + result.ToString());




        }
    }
}
