using System;
using System.Collections.Generic;
using System.Text;

namespace Brickwork.Contracts
{
    public interface ILogical // Interface with a method for second layer creation.
    {
        int[,] AddNewLayer(int[,] inputMatrix); // Method that creates the second layer.
    }
}
