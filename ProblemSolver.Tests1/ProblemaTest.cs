// <copyright file="ProblemaTest.cs" company="Avira Operations GmbH &amp; Co. KG;">Copyright © Avira Operations GmbH &amp; Co. KG; 2021</copyright>
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using NUnit.Framework;
using Solver;

namespace Solver.Tests
{
    /// <summary>This class contains parameterized unit tests for Problema</summary>
    [PexClass(typeof(Problema))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestFixture]
    public partial class ProblemaTest
    {
        /// <summary>Test stub for Solve()</summary>
        [PexMethod]
        public Interval SolveTest([PexAssumeUnderTest]Problema target)
        {
            Interval result = target.Solve();
            return result;
            // TODO: add assertions to method ProblemaTest.SolveTest(Problema)
        }
    }
}
