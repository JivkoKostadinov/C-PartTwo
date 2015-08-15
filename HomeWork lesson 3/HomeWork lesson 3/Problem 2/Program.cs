using System;



class GetMax
{
    static int GetMaxs(int first, int second)
    {
        if (first > second)
        {
            return first;
        }
        else
        {
            return second;
        }
    }
    static void Main()
    {
        Console.Write("Enter first number: ");
        int firstNum = int.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        int secondNum = int.Parse(Console.ReadLine());
        Console.Write("Enter third number: ");
        int thirdNum = int.Parse(Console.ReadLine());
        Console.Write("Bigger number is: {0}", GetMaxs(GetMaxs(firstNum, secondNum), thirdNum));
        Console.WriteLine();
    }
}