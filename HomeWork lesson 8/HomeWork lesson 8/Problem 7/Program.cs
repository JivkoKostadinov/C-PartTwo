﻿﻿using System;
using System.Collections.Generic;
using System.IO;


class ReplaceSubstring
{
    static void Main()
    {
        //file is in 'bin/Debug' directory of the project
        using (StreamReader reader = new StreamReader("text.txt"))
        {
            using (StreamWriter output = new StreamWriter("result.txt"))
            {
                for (string line = reader.ReadLine(); line != null; line = reader.ReadLine())
                {
                    string newLine = line.Replace("start", "finish");
                    output.WriteLine(newLine);
                }
            }
        }
        Console.WriteLine("Replacing done!");
    }
}