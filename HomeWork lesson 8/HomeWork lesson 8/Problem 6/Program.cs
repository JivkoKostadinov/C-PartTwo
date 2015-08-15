using System;
using System.Collections.Generic;
using System.IO;



class SaveSortedNames
{
    static void Main()
    {
        //file is in 'bin/Debug' directory of the project
        using (StreamReader unsorted = new StreamReader("unsorted.txt"))
        {
            List<string> names = new List<string>();
            for (string currName = unsorted.ReadLine(); currName != null; currName = unsorted.ReadLine())
            {
                names.Add(currName);
            }
            names.Sort();
            using (StreamWriter sorted = new StreamWriter("sorted.txt"))
            {
                foreach (string name in names)
                {
                    sorted.WriteLine(name);
                }
            }
        }
        Console.WriteLine("Names are sorted!");
    }
}
