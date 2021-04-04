using ProblemSolver.exceptions;
using System;

namespace Solver.exceptions
{
    internal class MustBeBiggerThanException : InvalidDataException
    {
        public MustBeBiggerThanException(string variable, int nr)
            : base($"{variable} must be bigger than {nr}")
        {
        }
    }
}