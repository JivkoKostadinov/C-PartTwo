using System;
using System.IO;


class OddLines
{
    static void Main()
    {
        using (StreamReader reader = new StreamReader(@"..\..\test.txt"))
        {
            int lineNum = 0;
            string line = reader.ReadLine();
            while (line != null)
            {
                if (lineNum % 2 == 1)
                {
                    Console.WriteLine(line);
                }
                lineNum++;
                line = reader.ReadLine();
            }
        }

    }
}