using System;
using System.Runtime.Serialization;

namespace Solver.exceptions {

    public class InvalidInputDataException : Exception {

        public InvalidInputDataException() {
        }

        public InvalidInputDataException(string message) : base(message) {
        }

        public InvalidInputDataException(string message, Exception innerException) : base(message, innerException) {
        }

        protected InvalidInputDataException(SerializationInfo info, StreamingContext context) : base(info, context) {
        }
    }
}