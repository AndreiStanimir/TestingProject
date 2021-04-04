using ProblemSolver.exceptions;
using System;
using System.Runtime.Serialization;

namespace Solver.exceptions
{
    [Serializable]
    internal class IntervalInvalidException : InvalidDataException
    {
        public IntervalInvalidException()
        {
        }

        public IntervalInvalidException(string message) : base(message)
        {
        }

        public IntervalInvalidException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected IntervalInvalidException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}