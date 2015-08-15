using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maximal_increasing_sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] integerArray = new int[]
        {
          3, 2, 3, 4, 2, 2, 4
        };
 
        int maxCount = 1;
     
        int tempMaxLength = 1;
        int startIndexTemp = 0;
        int endIndexTemp = 0;
        int endIndex = 0;
        bool aSequanceIsFound = false;
        int numberOfSequances = 0;
 
        for (int i = 0; i < integerArray.Length - 1; i++)
        {
            bool isSequanceFound = integerArray[i].CompareTo(integerArray[i + 1]) < 0;
 
            //1. Geting the length of the sequance
            if (isSequanceFound)
            {
                endIndex = i;
                maxCount++;
            }
            //2. Finding the end of the sequance
            else if (!isSequanceFound)
            {
                do
                {
                    //3.Compare the 2 length of the found sequnaces
                    bool comparingValueOfLength = maxCount > tempMaxLength;
                   
                    if (comparingValueOfLength && numberOfSequances > 0)
                    {
                       
                        aSequanceIsFound = true;                         // Telling that we faund a sequance
                        tempMaxLength = maxCount;                        //saving the length to a temp variable
                        endIndex = i;                                    //counting the last index
                        endIndexTemp = endIndex;                         //saving the last index to a temp value
                        startIndexTemp = endIndex + 1 - tempMaxLength;   //Calculating the start index of the sequance
                        maxCount = 1;                                    //reseting the length of the sequance
                    }
                    else if (!comparingValueOfLength)
                    {
                        numberOfSequances++; //countimg the found sequnaces
                        break;
                    }
                    else if (endIndex==integerArray.Length)
                    {
                        break;
                    }
 
                } while (!aSequanceIsFound);
 
                aSequanceIsFound = false; //4. reseting the flag of the faund sequance
            }
        }
        //5. Printing the Max sequance
        for (int i = startIndexTemp; i <= endIndexTemp; i++)
        {
            Console.Write(string.Join(",",integerArray[i]));
        }
        Console.WriteLine();
    


        }
    }
}
