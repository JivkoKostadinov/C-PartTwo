using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maximal_sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Enter elements of the array in one lane separated by ',' (each element can contain more than one symbol):");
            string input = "2, 1, 1, 2, 3, 3, 2, 2, 2, 1"; //Console.ReadLine();

            string[] inputToArray = input.Split(',');

            string maxSecuence = "";
            string tempMaxSec = "";

            for (int i = 0; i < inputToArray.Length; i++)
            {


                if (((i < inputToArray.Length - 1) && ((inputToArray[i] == inputToArray[i + 1]))))
                {
                    tempMaxSec += inputToArray[i] + ",";
                }
                else if (((i > 0) && ((inputToArray[i] == inputToArray[i - 1]))))
                {
                    tempMaxSec += inputToArray[i] + ",";
                }
                if ((i < inputToArray.Length - 1) && (inputToArray[i] != inputToArray[i + 1]))
                {

                    //          if (tempMaxSec.Length > maxSecuence.Length)
                    //          {
                    //
                    //              maxSecuence = tempMaxSec;
                    //              tempMaxSec = "";
                    //          }
                    //          else
                    //          {
                    //              tempMaxSec = "";
                    //          }
                    //
                    //      }
                    //
                    //  }
                }
                if (tempMaxSec.Length > maxSecuence.Length)
                {

                    maxSecuence = tempMaxSec;
                    tempMaxSec = "";
                }

                Console.WriteLine("The longest secuence of equal symbols is:");
                for (int j = 0; j < maxSecuence.Length - 1; j++)
                {

                    Console.Write("{0}", maxSecuence[j]);
                }
                Console.WriteLine();
            }
        }
    }
}
   





        
    

