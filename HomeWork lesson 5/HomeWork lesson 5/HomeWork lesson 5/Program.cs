using System;
class LeapYear
{
    static void Main()
    {
        try
        {
            Console.Write("Enter year to check if it is leap: ");
            int inputYear = int.Parse(Console.ReadLine());
            Console.WriteLine("This year is leap? => {0}", DateTime.IsLeapYear(inputYear));
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

    }
}
