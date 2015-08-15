using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //read first array
            Console.WriteLine("Enter first word :");
            char[] firstWord = Console.ReadLine().ToCharArray();
           
            //read second array

            Console.WriteLine("Enter second word :");
            char[] secondWord = Console.ReadLine().ToCharArray();

            string lexicographicallyFirst = firstWord.ToString();
            int lenght = Math.Min(firstWord.Length, secondWord.Length);
            for (int i = 0; i < lenght; i++)
            {
                if (firstWord[i] > secondWord[i])
                {
                    lexicographicallyFirst = secondWord.ToString();
                    break;
                }

            }

            Console.WriteLine("lexicographicallyFirst is :{0}", lexicographicallyFirst);

        }
    }
}
