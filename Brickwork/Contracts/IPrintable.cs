using System;
using System.Collections.Generic;
using System.Text;

namespace Brickwork.Contracts
{
    public interface IPrintable // Interface with the output method of the program.
    {
        string ReturnFancyBoard(int[,] matrix); // Output method.
    }
}
