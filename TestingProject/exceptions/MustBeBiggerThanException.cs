using System;

namespace TestingProject.exceptions
{
    internal class MustBeBiggerThanException : Exception
    {
        public MustBeBiggerThanException(string variable, int nr)
            : base($"{variable} must be bigger than {nr}")
        {
        }
    }
}