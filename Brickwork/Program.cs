using Brickwork.Contracts;
using Brickwork.Core;
using Brickwork.Logic;
using System;
using System.Linq;

namespace Brickwork
{
    class Program
    {
        static void Main(string[] args)
        {
            ILogical brickwork = new Logical();   // Instance of the class with second layer creation method.
            IPrintable printMatrix = new PrintMatrix();   // Instance of the matrix printing class.
            IRunnable engine = new Engine(brickwork, printMatrix);   //Creates an instance of the main logic class

            engine.Run(); // Starting point of the program.
        }
    }
}
