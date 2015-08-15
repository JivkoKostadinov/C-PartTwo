﻿using System;
using System.IO;



class DeletePrefix
{
    static void Main()
    {
        //files are in 'bin/Debug' directory of the project
        using (StreamReader reader = new StreamReader("test.txt"))
        {
            using (StreamWriter output = new StreamWriter("fixed.txt"))
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    if ((line[0] != 't') || (line[1] != 'e') || (line[2] != 's') || (line[3] != 't'))
                    {
                        output.WriteLine(line);
                    }
                    line = reader.ReadLine();
                }
            }
        }
        Console.WriteLine("All words starting with \"test\" removed.");
    }
}