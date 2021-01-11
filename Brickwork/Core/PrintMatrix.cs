using Brickwork.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Brickwork.Core
{
    public class PrintMatrix : IPrintable // Class to hold matrix printing method.
    {
        public string ReturnFancyBoard(int[,] matrix) //Return matrix as a string  where each brick is surrounded with "*".
        {
            StringBuilder output = new StringBuilder(); //Contains the string that will be outputed.

            output.AppendLine(new string('*', matrix.GetLength(1) * 2 + 1));

            StringBuilder currentRow = new StringBuilder();  //Contains the current row
            StringBuilder currentBottom = new StringBuilder();  //Contains the current bottom row

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                currentRow.Append("*");
                currentBottom.Append("*");

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    currentRow.Append(matrix[i, j].ToString());

                    if (j + 1 < matrix.GetLength(1))
                    {
                        if (matrix[i, j] == matrix[i, j + 1])
                        {
                            currentRow.Append(" ");
  
                        }
                        else
                        {
                            currentRow.Append("*");                         
                        }
                    }
                    else
                    {
                        currentRow.Append("*");
                    }

                    if (i + 1 < matrix.GetLength(0))
                    {
                        if (matrix[i, j] == matrix[i + 1, j])
                        {
                            currentBottom.Append(" ");
                        }
                        else
                        {
                            currentBottom.Append("*");
                        }
                    }
                    else
                    {
                        currentBottom.Append("*");
                    }
                    currentBottom.Append("*");
                }
                output.AppendLine(currentRow.ToString().TrimEnd());
                output.AppendLine(currentBottom.ToString().TrimEnd());

                currentRow.Clear();
                currentBottom.Clear();
            }
            return output.ToString().TrimEnd();
        }
    }
}
