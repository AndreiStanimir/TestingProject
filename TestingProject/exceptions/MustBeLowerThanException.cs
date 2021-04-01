﻿using System;

namespace TestingProject.exceptions
{
    internal class MustBeLowerThanException : Exception
    {
        public MustBeLowerThanException(string variable, int nr)
            : base($"{variable} must be lower than {nr}")
        {
        }
    }
}