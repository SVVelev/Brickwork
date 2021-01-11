using Brickwork.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Brickwork.Logic
{
    public class Logical : ILogical // Class to hold second layer creation.
    {
        public int[,] AddNewLayer(int[,] inputMatrix) //Lays the 2nd layer.
        {
            int[,] resultMatrix = ResultMatrixBuild(inputMatrix.GetLength(0), inputMatrix.GetLength(1)); // Output matrix filled initially with zeros.
            int brick = 1; // The number of the next brick;

            for (int row = 0; row < resultMatrix.GetLength(0); row++)
            {
                for (int col = 0; col < resultMatrix.GetLength(1); col++)
                {
                    if (inputMatrix[row, col] == brick && resultMatrix[row, col] == 0)
                    {
                        if (col < inputMatrix.GetLength(1) - 1 && inputMatrix[row, col + 1] != brick && resultMatrix[row, col + 1] == 0)
                        {
                            resultMatrix[row, col] = brick;
                            resultMatrix[row, col + 1] = brick;
                            brick++;
                        }
                        else if (row < inputMatrix.GetLength(0) - 1 && inputMatrix[row + 1, col] != brick && resultMatrix[row + 1, col] == 0)
                        {
                            resultMatrix[row, col] = brick;
                            resultMatrix[row + 1, col] = brick;
                            brick++;
                        }
                    }
                    else if (inputMatrix[row, col] != brick && resultMatrix[row, col] == 0)
                    {
                        if (col < inputMatrix.GetLength(1) - 1 && resultMatrix[row, col + 1] == 0)
                        {
                            resultMatrix[row, col] = brick;
                            resultMatrix[row, col + 1] = brick;
                            brick++;
                        }
                        else if (row < inputMatrix.GetLength(0) - 1 && resultMatrix[row + 1, col] == 0)
                        {
                            resultMatrix[row, col] = brick;
                            resultMatrix[row + 1, col] = brick;
                            brick++;
                        }
                    }
                }
            }

            return resultMatrix;
        }

        private  int[,] ResultMatrixBuild(int rowNumber, int colNumber)// Creates the output X*Y matrix and fills it with "0";
        {
            int[,] resultMatrix = new int[rowNumber, colNumber]; // Instance of the X*Y matrix with the same dimeonsions as the input matrix.

            for (int row = 0; row < resultMatrix.GetLength(0); row++)
            {
                for (int col = 0; col < resultMatrix.GetLength(1); col++)
                {
                    resultMatrix[row, col] = 0;
                }
            }

            return resultMatrix;
        }
    }
}
