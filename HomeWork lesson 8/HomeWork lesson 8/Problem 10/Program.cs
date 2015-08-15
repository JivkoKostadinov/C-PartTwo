﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;



class ExtractTextFromXML
{
    static void Main()
    {
        //file is in 'bin/Debug' directory of the project
        using (StreamReader reader = new StreamReader("xml.txt"))
        {
            string line = reader.ReadLine();
            string extract = string.Empty;
            while (line != null)
            {
                for (int i = 1; i < line.Length; i++)
                {
                    if (line[i - 1] == '>')
                    {
                        while (line[i] != '<')
                        {
                            extract += line[i];
                            i++;
                        }
                        if (extract != "")
                        {
                            Console.WriteLine(extract.TrimStart(' '));
                            extract = "";
                        }
                    }
                }
                line = reader.ReadLine();
            }
        }
    }
}