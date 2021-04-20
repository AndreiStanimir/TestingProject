namespace Solver.exceptions {

    internal class MustBeLowerThanException : InvalidInputDataException {

        public MustBeLowerThanException(string variable, int nr)
            : base($"{variable} must be lower than {nr}") {
        }
    }
}