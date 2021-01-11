using System;
using System.Collections.Generic;
using System.Text;

namespace Brickwork.Validations
{
    public static class Validator
    {
        public static void CheckMatrixDimensions(int row, int col) // Validating matrix dimensions.
        {
            if (row > 100 || col > 100 || row < 2 || col < 2)
            {
                throw new Exception("Invalid input. The numbers must be between 2 and 100!");
            }

            if (row % 2 != 0 || col % 2 != 0)
            {
                throw new Exception("Invalid input.The numbers must be even!");
            }
        }

        public static void ValidateMatrix(int[,] matrix) //Validates if there is any brick that is 3 long or high or if there are holes.
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == 0)
                    {
                        throw new Exception("Invalid brick placement.");
                    }
                    
                    if (i + 2 < matrix.GetLength(0))
                    {
                        if (matrix[i, j] == matrix[i + 2, j] && matrix[i, j] == matrix[i + 1, j])
                        {
                            throw new Exception("Brick to big.");
                        }
                    }
                    if (j + 2 < matrix.GetLength(1))
                    {
                        if (matrix[i, j] == matrix[i, j + 2] && matrix[i, j] == matrix[i, j + 1])
                        {
                            throw new Exception("Brick to big.");
                        }
                    }
                }
            }
        }

        public static void CheckForSmallerBricks(int[,] matrix) // Validates that the brick is not 1X1. Not Working.... for now
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j+=2)
                {                   
                    if ((i < matrix.GetLength(0) - 1 && matrix[i, j] != matrix[i + 1, j]) && (j < matrix.GetLength(1) - 1 && matrix[i, j] != matrix[i, j + 1]))
                    {
                        throw new Exception("Brick too small.");
                    }
                }
            }
        }

        public static void CheckSolution(int[,] matrix) // Validates the output. If there is a brick with "0" - no solution exists.
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if(matrix[row, col] == 0)
                    {
                        Console.WriteLine("-1");
                        Console.WriteLine("No solution exists");
                        Environment.Exit(0);
                    }
                }
            }
        }
    }
}
