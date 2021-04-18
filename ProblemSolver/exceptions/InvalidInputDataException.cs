using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Solver.exceptions
{
    public class InvalidInputDataException : Exception
    {
        public InvalidInputDataException()
        {
        }

        public InvalidInputDataException(string message) : base(message)
        {
        }

        public InvalidInputDataException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InvalidInputDataException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}

