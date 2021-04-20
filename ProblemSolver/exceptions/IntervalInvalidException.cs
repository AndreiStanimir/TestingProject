using System;
using System.Runtime.Serialization;

namespace Solver.exceptions {

    [Serializable]
    public class IntervalInvalidException : InvalidInputDataException {

        public IntervalInvalidException() {
        }

        public IntervalInvalidException(string message) : base(message) {
        }

        public IntervalInvalidException(string message, Exception innerException) : base(message, innerException) {
        }

        protected IntervalInvalidException(SerializationInfo info, StreamingContext context) : base(info, context) {
        }
    }
}