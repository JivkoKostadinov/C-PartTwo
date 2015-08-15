using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ReverseNumber
{
    static string ReverseDigits(string number)
    {
        char[] charNumbers = number.ToCharArray();
        Array.Reverse(charNumbers);
        return new string(charNumbers);
    }

    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.Write("Enter decimal to reverse: ");
        string number = Console.ReadLine();
        Console.WriteLine("Reversed: {0}", ReverseDigits(number));
    }
}
