using ProblemSolver.exceptions;
using System;

namespace Solver.exceptions
{
    internal class MustBeLowerThanException : InvalidDataException
    {
        public MustBeLowerThanException(string variable, int nr)
            : base($"{variable} must be lower than {nr}")
        {
        }
    }
}