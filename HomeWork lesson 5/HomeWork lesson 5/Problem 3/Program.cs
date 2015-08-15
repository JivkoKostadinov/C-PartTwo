using System;
class DayOfTheWeek
{
    static void Main()
    {
        DayOfWeek today = DateTime.Today.DayOfWeek;
        Console.WriteLine("Today is: {0}", today);
    }
}
