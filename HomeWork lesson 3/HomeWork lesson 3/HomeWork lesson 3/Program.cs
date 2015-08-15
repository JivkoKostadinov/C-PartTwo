using System;

class SayHello
{
    static void PrintName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        Console.WriteLine("Hello, {0}", name);
    }
    static void Main()
    {
        PrintName();
    }
}