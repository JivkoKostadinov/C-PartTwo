﻿using System;
using System.IO;



class MaxSumInMatrix
{
    static int[,] ReadMatrix()
    {
        //file is in 'bin/Debug' directory of the project
        using (StreamReader reader = new StreamReader("matrix.txt"))
        {
            int n = int.Parse(reader.ReadLine());
            int[,] matrix = new int[n, n];
            string rowInfo;

            for (int row = 0; row < n; row++)           //Removing whitespaces
            {
                rowInfo = reader.ReadLine();
                string[] rowCells = rowInfo.Split(' ');
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = int.Parse(rowCells[col]);
                }
            }
            return matrix;
        }
    }

    static int MaxSum(int[,] matrix)
    {
        int maxSum = int.MinValue;
        for (int row = 0; row < matrix.GetLength(0) - 1; row++)     //Finding max sum
        {
            for (int col = 0; col < matrix.GetLength(1) - 1; col++)
            {
                int currentSum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];
                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                }
            }
        }
        return maxSum;
    }

    static void PrintResult(int maxSum)
    {
        using (StreamWriter result = new StreamWriter("result.txt"))
        {
            result.WriteLine(maxSum);
        }
    }

    static void Main()
    {
        PrintResult(MaxSum(ReadMatrix()));
        Console.WriteLine("Max sum calculated!");
    }
}
