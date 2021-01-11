using Brickwork.Builder;
using Brickwork.Contracts;
using Brickwork.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Brickwork.Core
{
    public class Engine : IRunnable // Main logic class.
    {
        private ILogical brickwork; // Class to hold second layer creation method.
        private IPrintable printMatrix; // Class to hold a method for printing the output on the console.
        public Engine(ILogical brickwork, IPrintable printMatrix)
        {
            this.brickwork = brickwork;
            this.printMatrix = printMatrix;
        }
        public void Run() // The main function of the program.
        {
            try
            {
                int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray(); // User inputs.
                int rowNumber = input[0]; // Number of rows.
                int colNumber = input[1]; // Number of columns.

                Validator.CheckMatrixDimensions(rowNumber, colNumber); // Validates matrix dimensions.

                int[,] inputMatrix = MatrixBuilder.InputMatrixBuild(rowNumber, colNumber); // Input matrix according to user inputs.
                Validator.ValidateMatrix(inputMatrix); // Matrix validation.
                Validator.CheckForSmallerBricks(inputMatrix); // Validates there is no smaller brick.

                int[,] resultMatrix = this.brickwork.AddNewLayer(inputMatrix); // Output matrix with the second layer.

                Validator.CheckSolution(resultMatrix); // Check the solution.

                string output = this.printMatrix.ReturnFancyBoard(resultMatrix); // Output matrix where each brick will be surrounded by '*'.

                Console.WriteLine(output); // Printing output on the console.
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message); // If there is an exception - > printiong the exception message.
            }
        }
    }
}
