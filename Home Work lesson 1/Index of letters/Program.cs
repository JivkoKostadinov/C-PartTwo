using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Index_of_letters
{
    class Program
    {
        static void Main(string[] args)
        {

            char[] alphabet = new char[26];

            for (int i = 0; i <= 25; i++)
            {
                alphabet[i] = Convert.ToChar(65 + i);
            }

            Console.WriteLine("Capital letter word:");
            string word = Console.ReadLine();

            foreach (char letter in word)
            {
                Console.WriteLine("{0} = {1}", letter, (int)letter - 65);
            }

        }
    }
}
