﻿using System;
using System.IO;



class LineNumbers
{
    static void Main()
    {
        StreamReader reader = new StreamReader(@"..\..\withoutLineNumbers.txt");

        using (reader)
        {
            string line = reader.ReadLine();
            StreamWriter writer = new StreamWriter(@"..\..\WITHLineNumbers.txt");
            int lineNum = 0;
            using (writer)
            {
                while (line != null)
                {
                    lineNum++;
                    writer.WriteLine("Line {0}: {1}", lineNum, line);
                    line = reader.ReadLine();
                }
            }
        }
        Console.WriteLine("Lines are with numbers now!");
    }
}
