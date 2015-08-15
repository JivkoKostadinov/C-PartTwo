using System;

class RandomNumbers
{
    static void Main()
    {
        Random rnd = new Random();
        for (int i = 0; i < 10; i++)
        {
            Console.Write("{0} ", rnd.Next(100, 201));
        }
        Console.WriteLine();
    }
}
