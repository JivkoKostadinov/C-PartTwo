using System;
class SumIntegers
{
    static void Main()
    {
        Console.WriteLine("Enter numbers to sum.Separate them with \'space\'.");
        string[] input = Console.ReadLine().Split(' ');
        int sum = 0;
        for (int i = 0; i < input.Length; i++)
        {
            sum = sum + int.Parse(input[i].Trim());
        }
        Console.WriteLine(sum);
    }
}
