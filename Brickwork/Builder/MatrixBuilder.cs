using Brickwork.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Brickwork.Builder
{
    public static class MatrixBuilder // Class to hold matrix creation method according to user inputs.
    {
        public static int[,] InputMatrixBuild(int rowNumber, int colNumber) // Creates the X*Y matrix according to user inputs.
        {
            int[,] inputMatrix = new int[rowNumber, colNumber]; // Instance of the input X*Y matrix.

            for (int row = 0; row < inputMatrix.GetLength(0); row++)
            {
                int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();// The current row of the matrix inserted by he user.

                for (int col = 0; col < inputMatrix.GetLength(1); col++)
                {
                    inputMatrix[row, col] = input[col];
                }
            }

            return inputMatrix;
        }

    }
}
