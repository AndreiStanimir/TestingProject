using Solver.exceptions;
using System;

namespace Solver.exceptions
{
    public class MustBeBiggerThanException : InvalidInputDataException
    {
        public MustBeBiggerThanException(string variable, int nr)
            : base($"{variable} must be bigger than {nr}")
        {
        }
    }
}